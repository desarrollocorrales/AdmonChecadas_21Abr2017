namespace AdmonChecadas.GUIs
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbServidorMs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBaseDeDatosMs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProbarConMysql = new System.Windows.Forms.Button();
            this.tbContraseniaMs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsuarioMs = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbServidorMs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbBaseDeDatosMs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnProbarConMysql);
            this.groupBox2.Controls.Add(this.tbContraseniaMs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbUsuarioMs);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 267);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MySQL";
            // 
            // tbServidorMs
            // 
            this.tbServidorMs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbServidorMs.Location = new System.Drawing.Point(13, 42);
            this.tbServidorMs.Name = "tbServidorMs";
            this.tbServidorMs.Size = new System.Drawing.Size(235, 24);
            this.tbServidorMs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Servidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario";
            // 
            // tbBaseDeDatosMs
            // 
            this.tbBaseDeDatosMs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbBaseDeDatosMs.Location = new System.Drawing.Point(13, 189);
            this.tbBaseDeDatosMs.Name = "tbBaseDeDatosMs";
            this.tbBaseDeDatosMs.Size = new System.Drawing.Size(235, 24);
            this.tbBaseDeDatosMs.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label5.Location = new System.Drawing.Point(10, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña";
            // 
            // btnProbarConMysql
            // 
            this.btnProbarConMysql.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProbarConMysql.Location = new System.Drawing.Point(75, 225);
            this.btnProbarConMysql.Name = "btnProbarConMysql";
            this.btnProbarConMysql.Size = new System.Drawing.Size(106, 23);
            this.btnProbarConMysql.TabIndex = 11;
            this.btnProbarConMysql.Text = "Probar Conexión";
            this.btnProbarConMysql.UseVisualStyleBackColor = true;
            this.btnProbarConMysql.Click += new System.EventHandler(this.btnProbarConMysql_Click);
            // 
            // tbContraseniaMs
            // 
            this.tbContraseniaMs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbContraseniaMs.Location = new System.Drawing.Point(13, 141);
            this.tbContraseniaMs.Name = "tbContraseniaMs";
            this.tbContraseniaMs.Size = new System.Drawing.Size(235, 24);
            this.tbContraseniaMs.TabIndex = 9;
            this.tbContraseniaMs.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label6.Location = new System.Drawing.Point(10, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Base de Datos";
            // 
            // tbUsuarioMs
            // 
            this.tbUsuarioMs.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbUsuarioMs.Location = new System.Drawing.Point(13, 90);
            this.tbUsuarioMs.Name = "tbUsuarioMs";
            this.tbUsuarioMs.Size = new System.Drawing.Size(235, 24);
            this.tbUsuarioMs.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(164, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbServidorMs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBaseDeDatosMs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProbarConMysql;
        private System.Windows.Forms.TextBox tbContraseniaMs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsuarioMs;
        private System.Windows.Forms.Button btnGuardar;
    }
}