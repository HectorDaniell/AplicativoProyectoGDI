namespace Aplicativo_Corp_InterCable
{
    partial class AgregarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Deuda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Comen = new System.Windows.Forms.RichTextBox();
            this.Alta = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Olt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Distrito = new System.Windows.Forms.ComboBox();
            this.Cod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.TextBox();
            this.CodOnu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellNomb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ListaCliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Telef = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Telef);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Deuda);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.Comen);
            this.groupBox1.Controls.Add(this.Alta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Olt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Distrito);
            this.groupBox1.Controls.Add(this.Cod);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Dni);
            this.groupBox1.Controls.Add(this.CodOnu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ApellNomb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 249);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(286, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Agregar Nuevo Cliente";
            // 
            // Deuda
            // 
            this.Deuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Deuda.Location = new System.Drawing.Point(663, 131);
            this.Deuda.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Deuda.Name = "Deuda";
            this.Deuda.Size = new System.Drawing.Size(88, 25);
            this.Deuda.TabIndex = 39;
            this.Deuda.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(660, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Deuda:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Comentario:";
            // 
            // Comen
            // 
            this.Comen.Location = new System.Drawing.Point(25, 186);
            this.Comen.Name = "Comen";
            this.Comen.Size = new System.Drawing.Size(308, 50);
            this.Comen.TabIndex = 36;
            this.Comen.Text = "";
            // 
            // Alta
            // 
            this.Alta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Alta.Location = new System.Drawing.Point(554, 131);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(103, 25);
            this.Alta.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Alta:";
            // 
            // Olt
            // 
            this.Olt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Olt.Location = new System.Drawing.Point(451, 131);
            this.Olt.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Olt.Name = "Olt";
            this.Olt.Size = new System.Drawing.Size(88, 25);
            this.Olt.TabIndex = 33;
            this.Olt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ubicacion OLT:";
            // 
            // Distrito
            // 
            this.Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Distrito.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Distrito.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Distrito.FormattingEnabled = true;
            this.Distrito.Items.AddRange(new object[] {
            "Mariano Melgar",
            "Miraflores"});
            this.Distrito.Location = new System.Drawing.Point(633, 77);
            this.Distrito.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Distrito.Name = "Distrito";
            this.Distrito.Size = new System.Drawing.Size(118, 25);
            this.Distrito.TabIndex = 31;
            // 
            // Cod
            // 
            this.Cod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cod.Location = new System.Drawing.Point(25, 77);
            this.Cod.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(113, 25);
            this.Cod.TabIndex = 30;
            this.Cod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Codigo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Estado
            // 
            this.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Estado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.Estado.Location = new System.Drawing.Point(524, 77);
            this.Estado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(103, 25);
            this.Estado.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Distrito:";
            // 
            // Dni
            // 
            this.Dni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dni.Location = new System.Drawing.Point(413, 77);
            this.Dni.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(105, 25);
            this.Dni.TabIndex = 24;
            // 
            // CodOnu
            // 
            this.CodOnu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodOnu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CodOnu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CodOnu.FormattingEnabled = true;
            this.CodOnu.Location = new System.Drawing.Point(363, 131);
            this.CodOnu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.CodOnu.Name = "CodOnu";
            this.CodOnu.Size = new System.Drawing.Size(76, 25);
            this.CodOnu.TabIndex = 23;
            this.CodOnu.SelectedIndexChanged += new System.EventHandler(this.CodOnu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "DNI:";
            // 
            // Direccion
            // 
            this.Direccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Direccion.Location = new System.Drawing.Point(25, 131);
            this.Direccion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(332, 25);
            this.Direccion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Direccion:";
            // 
            // ApellNomb
            // 
            this.ApellNomb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ApellNomb.Location = new System.Drawing.Point(144, 77);
            this.ApellNomb.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.ApellNomb.Name = "ApellNomb";
            this.ApellNomb.Size = new System.Drawing.Size(264, 25);
            this.ApellNomb.TabIndex = 18;
            this.ApellNomb.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellidos y Nombres:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "CodOnu";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(640, 572);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 37);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevo.Location = new System.Drawing.Point(482, 176);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 36);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ListaCliente
            // 
            this.ListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCliente.Location = new System.Drawing.Point(37, 276);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(715, 210);
            this.ListaCliente.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(640, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Listar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(640, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(58, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Buscar por Nombre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 501);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(58, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 34);
            this.button4.TabIndex = 26;
            this.button4.Text = "Buscar Clientes Activos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(58, 572);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 34);
            this.button5.TabIndex = 27;
            this.button5.Text = "Nro. Clientes Activos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Telef
            // 
            this.Telef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Telef.Location = new System.Drawing.Point(339, 187);
            this.Telef.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.Telef.Name = "Telef";
            this.Telef.Size = new System.Drawing.Size(118, 25);
            this.Telef.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(336, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Telefono:";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 631);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(223, 6);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellNomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dni;
        private System.Windows.Forms.ComboBox CodOnu;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Distrito;
        private System.Windows.Forms.TextBox Olt;
        private System.Windows.Forms.TextBox Deuda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox Comen;
        private System.Windows.Forms.DateTimePicker Alta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView ListaCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Telef;
        private System.Windows.Forms.Label label13;
    }



}