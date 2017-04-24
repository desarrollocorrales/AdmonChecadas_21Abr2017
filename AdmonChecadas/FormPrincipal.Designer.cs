namespace AdmonChecadas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.bntConfig = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActNombres = new System.Windows.Forms.Button();
            this.cbPorEmpl = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDepto = new System.Windows.Forms.CheckBox();
            this.btnActDpto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.gcChecadas = new DevExpress.XtraGrid.GridControl();
            this.checadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumChecador = new System.Windows.Forms.ComboBox();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChecadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.Location = new System.Drawing.Point(147, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Checadas";
            // 
            // bntConfig
            // 
            this.bntConfig.Image = ((System.Drawing.Image)(resources.GetObject("bntConfig.Image")));
            this.bntConfig.Location = new System.Drawing.Point(12, 35);
            this.bntConfig.Margin = new System.Windows.Forms.Padding(2);
            this.bntConfig.Name = "bntConfig";
            this.bntConfig.Size = new System.Drawing.Size(60, 60);
            this.bntConfig.TabIndex = 1;
            this.bntConfig.UseVisualStyleBackColor = true;
            this.bntConfig.Click += new System.EventHandler(this.bntConfig_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(136, 120);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(91, 24);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(241, 120);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(91, 24);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnActNombres);
            this.panel1.Controls.Add(this.cbPorEmpl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbNombre);
            this.panel1.Location = new System.Drawing.Point(68, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 44);
            this.panel1.TabIndex = 16;
            // 
            // btnActNombres
            // 
            this.btnActNombres.Enabled = false;
            this.btnActNombres.Image = ((System.Drawing.Image)(resources.GetObject("btnActNombres.Image")));
            this.btnActNombres.Location = new System.Drawing.Point(160, 6);
            this.btnActNombres.Name = "btnActNombres";
            this.btnActNombres.Size = new System.Drawing.Size(30, 30);
            this.btnActNombres.TabIndex = 11;
            this.btnActNombres.UseVisualStyleBackColor = true;
            this.btnActNombres.Click += new System.EventHandler(this.btnActNombres_Click);
            // 
            // cbPorEmpl
            // 
            this.cbPorEmpl.AutoSize = true;
            this.cbPorEmpl.Location = new System.Drawing.Point(14, 12);
            this.cbPorEmpl.Name = "cbPorEmpl";
            this.cbPorEmpl.Size = new System.Drawing.Size(112, 21);
            this.cbPorEmpl.TabIndex = 20;
            this.cbPorEmpl.Text = "Por Empleado";
            this.cbPorEmpl.UseVisualStyleBackColor = true;
            this.cbPorEmpl.CheckedChanged += new System.EventHandler(this.cbPorEmpl_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(201, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.DropDownWidth = 300;
            this.cmbNombre.Enabled = false;
            this.cmbNombre.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(259, 10);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(202, 23);
            this.cmbNombre.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbDepto);
            this.panel2.Controls.Add(this.btnActDpto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbDpto);
            this.panel2.Location = new System.Drawing.Point(68, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 44);
            this.panel2.TabIndex = 17;
            // 
            // cbDepto
            // 
            this.cbDepto.AutoSize = true;
            this.cbDepto.Location = new System.Drawing.Point(14, 12);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(141, 21);
            this.cbDepto.TabIndex = 21;
            this.cbDepto.Text = "Por Departamento";
            this.cbDepto.UseVisualStyleBackColor = true;
            this.cbDepto.CheckedChanged += new System.EventHandler(this.cbDepto_CheckedChanged);
            // 
            // btnActDpto
            // 
            this.btnActDpto.Enabled = false;
            this.btnActDpto.Image = ((System.Drawing.Image)(resources.GetObject("btnActDpto.Image")));
            this.btnActDpto.Location = new System.Drawing.Point(160, 6);
            this.btnActDpto.Name = "btnActDpto";
            this.btnActDpto.Size = new System.Drawing.Size(30, 30);
            this.btnActDpto.TabIndex = 11;
            this.btnActDpto.UseVisualStyleBackColor = true;
            this.btnActDpto.Click += new System.EventHandler(this.btnActDpto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(201, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Depto.";
            // 
            // cmbDpto
            // 
            this.cmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto.DropDownWidth = 300;
            this.cmbDpto.Enabled = false;
            this.cmbDpto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.Location = new System.Drawing.Point(259, 10);
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(202, 24);
            this.cmbDpto.TabIndex = 6;
            // 
            // gcChecadas
            // 
            this.gcChecadas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcChecadas.DataSource = this.checadasBindingSource;
            this.gcChecadas.Location = new System.Drawing.Point(12, 325);
            this.gcChecadas.MainView = this.gridView1;
            this.gcChecadas.Name = "gcChecadas";
            this.gcChecadas.Size = new System.Drawing.Size(590, 322);
            this.gcChecadas.TabIndex = 18;
            this.gcChecadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // checadasBindingSource
            // 
            this.checadasBindingSource.DataSource = typeof(AdmonChecadas.Modelos.Checadas);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidInterno,
            this.colempleado,
            this.colidDepto,
            this.coldepartamento,
            this.colfechaHora});
            this.gridView1.GridControl = this.gcChecadas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Checadas";
            // 
            // colidInterno
            // 
            this.colidInterno.AppearanceCell.Options.UseTextOptions = true;
            this.colidInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidInterno.AppearanceHeader.Options.UseTextOptions = true;
            this.colidInterno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidInterno.Caption = "Id Interno";
            this.colidInterno.FieldName = "idInterno";
            this.colidInterno.Name = "colidInterno";
            this.colidInterno.Visible = true;
            this.colidInterno.VisibleIndex = 0;
            // 
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 2;
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
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 3;
            this.coldepartamento.Width = 90;
            // 
            // colfechaHora
            // 
            this.colfechaHora.Caption = "Fecha y Hora";
            this.colfechaHora.FieldName = "fechaHora";
            this.colfechaHora.Name = "colfechaHora";
            this.colfechaHora.Visible = true;
            this.colfechaHora.VisibleIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnBuscar.Location = new System.Drawing.Point(238, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 40);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(340, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Núm. Checador";
            // 
            // cmbNumChecador
            // 
            this.cmbNumChecador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumChecador.DropDownWidth = 93;
            this.cmbNumChecador.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cmbNumChecador.FormattingEnabled = true;
            this.cmbNumChecador.Location = new System.Drawing.Point(343, 120);
            this.cmbNumChecador.Name = "cmbNumChecador";
            this.cmbNumChecador.Size = new System.Drawing.Size(93, 23);
            this.cmbNumChecador.TabIndex = 21;
            // 
            // btnImpresion
            // 
            this.btnImpresion.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnImpresion.Location = new System.Drawing.Point(445, 653);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(139, 40);
            this.btnImpresion.TabIndex = 22;
            this.btnImpresion.Text = "Impresión";
            this.btnImpresion.UseVisualStyleBackColor = true;
            this.btnImpresion.Click += new System.EventHandler(this.btnImpresion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 705);
            this.Controls.Add(this.btnImpresion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNumChecador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gcChecadas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.bntConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checadas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChecadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntConfig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActDpto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDpto;
        private DevExpress.XtraGrid.GridControl gcChecadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource checadasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colidDepto;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaHora;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbPorEmpl;
        private System.Windows.Forms.CheckBox cbDepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNumChecador;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnImpresion;
    }
}

