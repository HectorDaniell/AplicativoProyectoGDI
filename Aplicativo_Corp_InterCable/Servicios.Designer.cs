namespace Aplicativo_Corp_InterCable
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.TablaServicios = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.Button();
            this.ListarServ = new System.Windows.Forms.Button();
            this.listaRecibo = new System.Windows.Forms.Button();
            this.NroRecibo = new System.Windows.Forms.TextBox();
            this.CampoModificar = new System.Windows.Forms.Panel();
            this.CodCliServ = new System.Windows.Forms.TextBox();
            this.viewPrecio = new System.Windows.Forms.Button();
            this.PlanServ = new System.Windows.Forms.ComboBox();
            this.VerPrecio = new System.Windows.Forms.TextBox();
            this.TablaRecibos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.generaRecibo = new System.Windows.Forms.Button();
            this.AllRecibo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaServicios)).BeginInit();
            this.CampoModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaServicios
            // 
            this.TablaServicios.AllowUserToAddRows = false;
            this.TablaServicios.AllowUserToDeleteRows = false;
            this.TablaServicios.AllowUserToOrderColumns = true;
            this.TablaServicios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaServicios.Location = new System.Drawing.Point(25, 14);
            this.TablaServicios.Name = "TablaServicios";
            this.TablaServicios.ReadOnly = true;
            this.TablaServicios.Size = new System.Drawing.Size(585, 401);
            this.TablaServicios.TabIndex = 2;
            this.TablaServicios.SelectionChanged += new System.EventHandler(this.TablaServicios_SelectionChanged);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(658, 70);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(130, 33);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar Servicio";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // ListarServ
            // 
            this.ListarServ.Location = new System.Drawing.Point(658, 23);
            this.ListarServ.Name = "ListarServ";
            this.ListarServ.Size = new System.Drawing.Size(130, 31);
            this.ListarServ.TabIndex = 4;
            this.ListarServ.Text = "Listar Servicios";
            this.ListarServ.UseVisualStyleBackColor = true;
            this.ListarServ.Click += new System.EventHandler(this.ListarServ_Click);
            // 
            // listaRecibo
            // 
            this.listaRecibo.Location = new System.Drawing.Point(658, 247);
            this.listaRecibo.Name = "listaRecibo";
            this.listaRecibo.Size = new System.Drawing.Size(130, 35);
            this.listaRecibo.TabIndex = 5;
            this.listaRecibo.Text = "Listar Recibos Activos";
            this.listaRecibo.UseVisualStyleBackColor = true;
            this.listaRecibo.Click += new System.EventHandler(this.button3_Click);
            // 
            // NroRecibo
            // 
            this.NroRecibo.Location = new System.Drawing.Point(658, 288);
            this.NroRecibo.Name = "NroRecibo";
            this.NroRecibo.Size = new System.Drawing.Size(129, 20);
            this.NroRecibo.TabIndex = 6;
            this.NroRecibo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CampoModificar
            // 
            this.CampoModificar.Controls.Add(this.CodCliServ);
            this.CampoModificar.Controls.Add(this.viewPrecio);
            this.CampoModificar.Controls.Add(this.PlanServ);
            this.CampoModificar.Controls.Add(this.VerPrecio);
            this.CampoModificar.Location = new System.Drawing.Point(659, 129);
            this.CampoModificar.Name = "CampoModificar";
            this.CampoModificar.Size = new System.Drawing.Size(129, 111);
            this.CampoModificar.TabIndex = 7;
            // 
            // CodCliServ
            // 
            this.CodCliServ.Location = new System.Drawing.Point(10, 12);
            this.CodCliServ.Name = "CodCliServ";
            this.CodCliServ.Size = new System.Drawing.Size(102, 20);
            this.CodCliServ.TabIndex = 5;
            // 
            // viewPrecio
            // 
            this.viewPrecio.Location = new System.Drawing.Point(10, 71);
            this.viewPrecio.Name = "viewPrecio";
            this.viewPrecio.Size = new System.Drawing.Size(64, 24);
            this.viewPrecio.TabIndex = 4;
            this.viewPrecio.Text = "Ver Precio";
            this.viewPrecio.UseVisualStyleBackColor = true;
            this.viewPrecio.Click += new System.EventHandler(this.viewPrecio_Click);
            // 
            // PlanServ
            // 
            this.PlanServ.FormattingEnabled = true;
            this.PlanServ.Location = new System.Drawing.Point(10, 44);
            this.PlanServ.Name = "PlanServ";
            this.PlanServ.Size = new System.Drawing.Size(102, 21);
            this.PlanServ.TabIndex = 1;
            // 
            // VerPrecio
            // 
            this.VerPrecio.Location = new System.Drawing.Point(80, 75);
            this.VerPrecio.Name = "VerPrecio";
            this.VerPrecio.Size = new System.Drawing.Size(32, 20);
            this.VerPrecio.TabIndex = 0;
            // 
            // TablaRecibos
            // 
            this.TablaRecibos.AllowUserToAddRows = false;
            this.TablaRecibos.AllowUserToDeleteRows = false;
            this.TablaRecibos.AllowUserToOrderColumns = true;
            this.TablaRecibos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablaRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRecibos.Location = new System.Drawing.Point(25, 37);
            this.TablaRecibos.Name = "TablaRecibos";
            this.TablaRecibos.ReadOnly = true;
            this.TablaRecibos.Size = new System.Drawing.Size(585, 401);
            this.TablaRecibos.TabIndex = 8;
            this.TablaRecibos.SelectionChanged += new System.EventHandler(this.TablaRecibos_SelectionChanged);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(616, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 25);
            this.button4.TabIndex = 45;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // generaRecibo
            // 
            this.generaRecibo.Location = new System.Drawing.Point(658, 314);
            this.generaRecibo.Name = "generaRecibo";
            this.generaRecibo.Size = new System.Drawing.Size(130, 35);
            this.generaRecibo.TabIndex = 46;
            this.generaRecibo.Text = "Generar Recibo";
            this.generaRecibo.UseVisualStyleBackColor = true;
            this.generaRecibo.Click += new System.EventHandler(this.generaRecibo_Click);
            // 
            // AllRecibo
            // 
            this.AllRecibo.Location = new System.Drawing.Point(659, 355);
            this.AllRecibo.Name = "AllRecibo";
            this.AllRecibo.Size = new System.Drawing.Size(128, 35);
            this.AllRecibo.TabIndex = 47;
            this.AllRecibo.Text = "Generar Todos los Recibos";
            this.AllRecibo.UseVisualStyleBackColor = true;
            this.AllRecibo.Click += new System.EventHandler(this.AllRecibo_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllRecibo);
            this.Controls.Add(this.generaRecibo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TablaRecibos);
            this.Controls.Add(this.CampoModificar);
            this.Controls.Add(this.NroRecibo);
            this.Controls.Add(this.listaRecibo);
            this.Controls.Add(this.ListarServ);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.TablaServicios);
            this.Location = new System.Drawing.Point(223, 60);
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaServicios)).EndInit();
            this.CampoModificar.ResumeLayout(false);
            this.CampoModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaServicios;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button ListarServ;
        private System.Windows.Forms.Button listaRecibo;
        private System.Windows.Forms.TextBox NroRecibo;
        private System.Windows.Forms.Panel CampoModificar;
        private System.Windows.Forms.Button viewPrecio;
        private System.Windows.Forms.ComboBox PlanServ;
        private System.Windows.Forms.TextBox VerPrecio;
        private System.Windows.Forms.TextBox CodCliServ;
        private System.Windows.Forms.DataGridView TablaRecibos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button generaRecibo;
        private System.Windows.Forms.Button AllRecibo;
    }
}