using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdmonChecadas.Negocio;
using System.IO;

namespace AdmonChecadas.GUIs
{
    public partial class frmConfiguracion : Form
    {
        private string _path = string.Empty;
        private IConsultasMySQLNegocio _consultasMySQLNegocio;

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\AdmonChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    // si existe
                    // cargar los datos en los campos
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        if (list.Count() < 4)
                        {
                            foreach (Control x in this.Controls)
                            {
                                if (x is TextBox)
                                {
                                    ((TextBox)x).Text = string.Empty;
                                }
                            }
                        }
                        else
                        {
                            // MYSQL
                            this.tbServidorMs.Text = list[0].Substring(2);      // SERVIDOR
                            this.tbUsuarioMs.Text = list[1].Substring(2);       // USUARIO
                            this.tbContraseniaMs.Text = list[2].Substring(2);   // CONTRASEÑA
                            this.tbBaseDeDatosMs.Text = list[3].Substring(2);   // BASE DE DATOS
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnProbarConMysql_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.ConectionString.conn = string.Format(
                            "Data Source={0};database={1};User Id={2};password={3};",
                            this.tbServidorMs.Text,
                            this.tbBaseDeDatosMs.Text,
                            this.tbUsuarioMs.Text,
                            this.tbContraseniaMs.Text);

                this._consultasMySQLNegocio = new ConsultasMySQLNegocio();

                bool pruebaConn = this._consultasMySQLNegocio.pruebaConn();

                if (pruebaConn)
                    MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    throw new Exception("Falló la conexión a la base de datos del Microsip");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.groupBox2.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                // define texto del archivo
                string cadena = string.Empty;

                // MYSQL
                cadena += "S_" + this.tbServidorMs.Text + "||";
                cadena += "U_" + this.tbUsuarioMs.Text + "||";
                cadena += "C_" + this.tbContraseniaMs.Text + "||";
                cadena += "B_" + this.tbBaseDeDatosMs.Text + "||";

                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    // mysql
                    Modelos.ConectionString.conn = string.Format(
                                "Data Source={0};database={1};User Id={2};password={3};",
                                this.tbServidorMs.Text,
                                this.tbBaseDeDatosMs.Text,
                                this.tbUsuarioMs.Text,
                                this.tbContraseniaMs.Text);

                    MessageBox.Show("Se cargó correctamente la información", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
