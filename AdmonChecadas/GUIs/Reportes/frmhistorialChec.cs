using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;

namespace AdmonChecadas.GUIs.Reportes
{
    public partial class frmhistorialChec : Form
    {
        public string _periodoIni;
        public string _periodoFin;
        public int _numChec;

        public string _periodoCompleto;

        public List<Modelos.Checadas> _checadas = new List<Modelos.Checadas>();

        public frmhistorialChec()
        {
            InitializeComponent();
        }

        private void frmhistorialChec_Load(object sender, EventArgs e)
        {
            try
            {
                this._periodoCompleto = this._periodoIni + " - " + this._periodoFin;

                //Limpiemos el DataSource del informe
                this.reportViewer1.LocalReport.DataSources.Clear();
                //
                //Establezcamos los parámetros que enviaremos al reporte
                //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
                //
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("pPeriodoIni", Convert.ToString(this._periodoIni));
                parameters[1] = new ReportParameter("pPeriodoFin", Convert.ToString(this._periodoFin));
                parameters[2] = new ReportParameter("pNumChec", Convert.ToString(this._numChec));
                parameters[3] = new ReportParameter("pPerComp", Convert.ToString(this._periodoCompleto));
                //
                //Establezcamos la lista como Datasource del informe
                //
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsChecadas", this._checadas));
                //
                //Enviemos la lista de parametros
                //
                this.reportViewer1.LocalReport.SetParameters(parameters);

                this.reportViewer1.RefreshReport();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.reportViewer1.RefreshReport();
        }

        private void frmhistorialChec_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}
