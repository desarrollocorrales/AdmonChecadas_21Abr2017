using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdmonChecadas.GUIs;
using System.IO;
using AdmonChecadas.Negocio;
using AdmonChecadas.GUIs.Reportes;

namespace AdmonChecadas
{
    public partial class FormPrincipal : Form
    {
        private IConsultasMySQLNegocio _consultasMySQLNegocio;

        private bool _defConfig;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = Modelos.Utilerias.Transform("p4ssw0rd");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\AdmonChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion 
                    frmConfiguracion form = new frmConfiguracion();
                    var resultado = form.ShowDialog();

                    if (resultado != System.Windows.Forms.DialogResult.OK)
                    {
                        this._defConfig = false;
                        throw new Exception("No se ha definido la configuración");
                    }
                }

                file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                // si existe
                // obtener la cadena de conexion del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                    // MySQL
                    string servidorMs = list[0].Substring(2);   // servidor mysql
                    string usuarioMs = list[1].Substring(2);    // usuario mysql
                    string contraMs = list[2].Substring(2);     // contraseña
                    string baseDatosMs = list[3].Substring(2);  // base de datos

                    Modelos.ConectionString.conn = string.Format(
                                "Data Source={0};database={1};User Id={2};password={3};",
                                servidorMs,
                                baseDatosMs,
                                usuarioMs,
                                contraMs);

                }

                this._defConfig = true;

                this._consultasMySQLNegocio = new ConsultasMySQLNegocio();

                // obtiene el numero de checador
                this.cmbNumChecador.DataSource = this._consultasMySQLNegocio.getNumChec();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntConfig_Click(object sender, EventArgs e)
        {
            frmAcceso formA = new frmAcceso();

            var respuesta = formA.ShowDialog();

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                frmConfiguracion form = new frmConfiguracion();
                var resultado = form.ShowDialog();

                if (resultado == System.Windows.Forms.DialogResult.OK)
                    this.FormPrincipal_Load(null, null);
            }
        }

        private void cbPorEmpl_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbNombre.DataSource = null;
            this.btnActNombres.Enabled = this.cbPorEmpl.Checked;
            this.label6.Enabled = this.cbPorEmpl.Checked;
            this.cmbNombre.Enabled = this.cbPorEmpl.Checked;
        }

        private void cbDepto_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbDpto.DataSource = null;
            this.btnActDpto.Enabled = this.cbDepto.Checked;
            this.label7.Enabled = this.cbDepto.Checked;
            this.cmbDpto.Enabled = this.cbDepto.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");
                
                if (this.cmbNumChecador.Items.Count == 0)
                    throw new Exception("No se han realizado descargas en checador");

                if (string.IsNullOrEmpty(this.dtpFechaInicio.Text))
                    throw new Exception("Defina una fecha de inicio");

                if (string.IsNullOrEmpty(this.dtpFechaFin.Text))
                    throw new Exception("Defina una fecha final");

                if (this.cbPorEmpl.Checked)
                    if (this.cmbNombre.SelectedIndex == -1)
                        throw new Exception("Seleccione un Empleado");

                if (this.cbDepto.Checked)
                    if (this.cmbDpto.SelectedIndex == -1)
                        throw new Exception("Seleccione un Departamento");

                // fechas
                string fechaIni = this.dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                string fechaFin = this.dtpFechaFin.Value.AddHours(24).ToString("yyyy-MM-dd");

                int nombre = -1, depto = -1;

                if (this.cbPorEmpl.Checked) nombre = ((Modelos.Empleados)this.cmbNombre.SelectedItem).idInterno;
                if (this.cbDepto.Checked) depto = ((Modelos.Departamentos)this.cmbDpto.SelectedItem).idDepto;

                // busqueda
                List<Modelos.Checadas> resultado =
                    this._consultasMySQLNegocio.getChecadas(
                        fechaIni, fechaFin,
                        this.cbPorEmpl.Checked, this.cbDepto.Checked,
                        nombre, depto, (int)this.cmbNumChecador.SelectedValue);

                if (resultado.Count == 0)
                {
                    this.gcChecadas.DataSource = new List<Modelos.Checadas>();

                    throw new Exception("Sin resultados");
                }

                this.gcChecadas.DataSource = null;
                this.gcChecadas.DataSource = resultado;

                this.gridView1.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActNombres_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");
                
                List<Modelos.Empleados> empleados = this._consultasMySQLNegocio.getEmpleados();

                // llena el catalogo de empleados disponibles
                this.cmbNombre.DataSource = empleados;
                this.cmbNombre.DisplayMember = "nombreEmpleado";
                this.cmbNombre.ValueMember = "idInterno";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActDpto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");
                
                List<Modelos.Departamentos> deptos = this._consultasMySQLNegocio.getDeptos();

                // llena el catalogo de departamentos disponibles
                this.cmbDpto.DataSource = deptos;
                this.cmbDpto.DisplayMember = "departamento";
                this.cmbDpto.ValueMember = "idDepto";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados form = new frmEmpleados();

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig)
                    throw new Exception("No se ha definido la configuración");
                
                if (this.gridView1.RowCount == 0)
                    throw new Exception("Realice una consulta");

                frmhistorialChec form = new frmhistorialChec();

                List<Modelos.Checadas> seleccionados =
                    ((List<Modelos.Checadas>)this.gridView1.DataSource).Select(s => s).ToList();

                form._periodoIni = this.dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                form._periodoFin = this.dtpFechaFin.Value.ToString("yyyy-MM-dd");
                form._numChec = (int)this.cmbNumChecador.SelectedItem;

                form._checadas = seleccionados;

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
