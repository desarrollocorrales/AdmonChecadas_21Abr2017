using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdmonChecadas.Negocio;

namespace AdmonChecadas.GUIs
{
    public partial class frmEmpleados : Form
    {
        private IConsultasMySQLNegocio _consultasMySQLNegocio;
        private List<Modelos.Empleados> _empleados = new List<Modelos.Empleados>();

        public frmEmpleados()
        {
            InitializeComponent();

            this._consultasMySQLNegocio = new ConsultasMySQLNegocio();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                // carga lista de empleados
                this.cargaEmpleados();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void cargaEmpleados()
        {
            this._empleados = this._consultasMySQLNegocio.cargaEmpleados();

            this.gcEmpleados.DataSource = null;
            this.gcEmpleados.DataSource = this._empleados;

            this.gridView1.BestFitColumns();

            this.tbIdInterno.Text = string.Empty;
            this.tbEmpleado.Text = string.Empty;
            this.tbIdInterno.Text = string.Empty;
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this._empleados.Count == 0)
                    return;

                List<Modelos.Empleados> seleccion = new List<Modelos.Empleados>();

                string texto = this.tbBusqueda.Text;

                seleccion = this._empleados
                    .Where(w => w.idInterno.ToString().ToUpper().Contains((texto.ToUpper())) || w.nombreEmpleado.Contains(texto.ToUpper())).ToList();

                this.gcEmpleados.DataSource = null;
                this.gcEmpleados.DataSource = seleccion;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                // carga lista de empleados
                this.cargaEmpleados();

                this.tbBusqueda.Text = string.Empty;
                this.cmbDepto.DataSource = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gcEmpleados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView1.GetSelectedRows().Count() == 0)
                    return;


                List<Modelos.Departamentos> deptos = this._consultasMySQLNegocio.getDeptos();

                // llena el catalogo de departamentos disponibles
                this.cmbDepto.DataSource = deptos;
                this.cmbDepto.DisplayMember = "departamento";
                this.cmbDepto.ValueMember = "idDepto";

                Modelos.Empleados ent = new Modelos.Empleados();

                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    var dr1 = this.gridView1.GetRow(i);

                    ent = (Modelos.Empleados)dr1;
                }

                this.tbIdInterno.Text = Convert.ToString(ent.idInterno);
                this.tbEmpleado.Text = ent.nombreEmpleado;

                this.cmbDepto.SelectedValue = ent.idDepto;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                if (string.IsNullOrEmpty(this.tbIdInterno.Text))
                    throw new Exception("Selecione un empleado");

                if (string.IsNullOrEmpty(this.tbEmpleado.Text))
                    throw new Exception("Defina un nombre para el empleado");

                if (this.cmbDepto.SelectedIndex == -1)
                    throw new Exception("Seleccione un departamento");

                string empleado = this.tbEmpleado.Text;
                int depto = (int)this.cmbDepto.SelectedValue;
                int idInterno = Convert.ToInt32(this.tbIdInterno.Text);

                bool resultado = this._consultasMySQLNegocio.actEmpleado(idInterno, empleado, depto);

                if (resultado)
                    MessageBox.Show("Proceso Concluido", "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
