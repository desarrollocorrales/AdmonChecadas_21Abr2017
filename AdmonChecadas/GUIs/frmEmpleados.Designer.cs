namespace AdmonChecadas.GUIs
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.btnActEmpl = new System.Windows.Forms.Button();
            this.cmbDepto = new System.Windows.Forms.ComboBox();
            this.btnGuardaCambios = new System.Windows.Forms.Button();
            this.gcEmpleados = new DevExpress.XtraGrid.GridControl();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdInterno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(107, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualización de Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Interno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empleado";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(119, 86);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(343, 30);
            this.tbBusqueda.TabIndex = 4;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(166, 403);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(352, 30);
            this.tbEmpleado.TabIndex = 5;
            // 
            // btnActEmpl
            // 
            this.btnActEmpl.Image = ((System.Drawing.Image)(resources.GetObject("btnActEmpl.Image")));
            this.btnActEmpl.Location = new System.Drawing.Point(468, 75);
            this.btnActEmpl.Name = "btnActEmpl";
            this.btnActEmpl.Size = new System.Drawing.Size(50, 50);
            this.btnActEmpl.TabIndex = 6;
            this.btnActEmpl.UseVisualStyleBackColor = true;
            this.btnActEmpl.Click += new System.EventHandler(this.btnActEmpl_Click);
            // 
            // cmbDepto
            // 
            this.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(166, 446);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(352, 31);
            this.cmbDepto.TabIndex = 7;
            // 
            // btnGuardaCambios
            // 
            this.btnGuardaCambios.Location = new System.Drawing.Point(183, 499);
            this.btnGuardaCambios.Name = "btnGuardaCambios";
            this.btnGuardaCambios.Size = new System.Drawing.Size(189, 39);
            this.btnGuardaCambios.TabIndex = 8;
            this.btnGuardaCambios.Text = "Guardar Cambios";
            this.btnGuardaCambios.UseVisualStyleBackColor = true;
            this.btnGuardaCambios.Click += new System.EventHandler(this.btnGuardaCambios_Click);
            // 
            // gcEmpleados
            // 
            this.gcEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcEmpleados.DataSource = this.empleadosBindingSource;
            this.gcEmpleados.Location = new System.Drawing.Point(12, 131);
            this.gcEmpleados.MainView = this.gridView1;
            this.gcEmpleados.Name = "gcEmpleados";
            this.gcEmpleados.Size = new System.Drawing.Size(530, 213);
            this.gcEmpleados.TabIndex = 9;
            this.gcEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcEmpleados.DoubleClick += new System.EventHandler(this.gcEmpleados_DoubleClick);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(AdmonChecadas.Modelos.Empleados);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidInterno,
            this.colnombreEmpleado,
            this.colidDepto,
            this.coldepartamento});
            this.gridView1.GridControl = this.gcEmpleados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Empleados";
            // 
            // colidInterno
            // 
            this.colidInterno.AppearanceCell.Options.UseTextOptions = true;
            this.colidInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidInterno.Caption = "Id Interno";
            this.colidInterno.FieldName = "idInterno";
            this.colidInterno.Name = "colidInterno";
            this.colidInterno.OptionsColumn.AllowEdit = false;
            this.colidInterno.Visible = true;
            this.colidInterno.VisibleIndex = 0;
            // 
            // colnombreEmpleado
            // 
            this.colnombreEmpleado.Caption = "Empleado";
            this.colnombreEmpleado.FieldName = "nombreEmpleado";
            this.colnombreEmpleado.Name = "colnombreEmpleado";
            this.colnombreEmpleado.OptionsColumn.AllowEdit = false;
            this.colnombreEmpleado.Visible = true;
            this.colnombreEmpleado.VisibleIndex = 1;
            // 
            // colidDepto
            // 
            this.colidDepto.FieldName = "idDepto";
            this.colidDepto.Name = "colidDepto";
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamento";
            // 
            // tbIdInterno
            // 
            this.tbIdInterno.Location = new System.Drawing.Point(166, 360);
            this.tbIdInterno.Name = "tbIdInterno";
            this.tbIdInterno.ReadOnly = true;
            this.tbIdInterno.Size = new System.Drawing.Size(75, 30);
            this.tbIdInterno.TabIndex = 11;
            this.tbIdInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 564);
            this.Controls.Add(this.tbIdInterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gcEmpleados);
            this.Controls.Add(this.btnGuardaCambios);
            this.Controls.Add(this.cmbDepto);
            this.Controls.Add(this.btnActEmpl);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Button btnActEmpl;
        private System.Windows.Forms.ComboBox cmbDepto;
        private System.Windows.Forms.Button btnGuardaCambios;
        private DevExpress.XtraGrid.GridControl gcEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdInterno;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colidDepto;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
    }
}