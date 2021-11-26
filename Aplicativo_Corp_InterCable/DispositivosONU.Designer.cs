namespace Aplicativo_Corp_InterCable
{
    partial class DispositivosONU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispositivosONU));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaOnu = new System.Windows.Forms.DataGridView();
            this.codOn = new System.Windows.Forms.TextBox();
            this.NombOnu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInsertOnu = new System.Windows.Forms.Panel();
            this.AgreOnu = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaOnu)).BeginInit();
            this.panelInsertOnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(159, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(41, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 39);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ver Dispositivos \r\nDisponibles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(274, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 39);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar nuevo ONU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eliminar ONU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿Que accion desea realizar?";
            // 
            // ListaOnu
            // 
            this.ListaOnu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListaOnu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaOnu.Location = new System.Drawing.Point(24, 223);
            this.ListaOnu.Name = "ListaOnu";
            this.ListaOnu.Size = new System.Drawing.Size(337, 167);
            this.ListaOnu.TabIndex = 8;
            // 
            // codOn
            // 
            this.codOn.Location = new System.Drawing.Point(49, 11);
            this.codOn.Name = "codOn";
            this.codOn.Size = new System.Drawing.Size(78, 20);
            this.codOn.TabIndex = 9;
            // 
            // NombOnu
            // 
            this.NombOnu.Location = new System.Drawing.Point(183, 11);
            this.NombOnu.Name = "NombOnu";
            this.NombOnu.Size = new System.Drawing.Size(151, 20);
            this.NombOnu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // panelInsertOnu
            // 
            this.panelInsertOnu.Controls.Add(this.Eliminar);
            this.panelInsertOnu.Controls.Add(this.AgreOnu);
            this.panelInsertOnu.Controls.Add(this.label6);
            this.panelInsertOnu.Controls.Add(this.codOn);
            this.panelInsertOnu.Controls.Add(this.NombOnu);
            this.panelInsertOnu.Controls.Add(this.label5);
            this.panelInsertOnu.Location = new System.Drawing.Point(24, 149);
            this.panelInsertOnu.Name = "panelInsertOnu";
            this.panelInsertOnu.Size = new System.Drawing.Size(337, 68);
            this.panelInsertOnu.TabIndex = 13;
            // 
            // AgreOnu
            // 
            this.AgreOnu.Location = new System.Drawing.Point(118, 42);
            this.AgreOnu.Name = "AgreOnu";
            this.AgreOnu.Size = new System.Drawing.Size(75, 23);
            this.AgreOnu.TabIndex = 13;
            this.AgreOnu.Text = "Aceptar";
            this.AgreOnu.UseVisualStyleBackColor = true;
            this.AgreOnu.Click += new System.EventHandler(this.AgreOnu_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(17, 42);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 14;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // DispositivosONU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(390, 402);
            this.Controls.Add(this.ListaOnu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelInsertOnu);
            this.Location = new System.Drawing.Point(400, 138);
            this.Name = "DispositivosONU";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DispositivosONU";
            this.Load += new System.EventHandler(this.DispositivosONU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaOnu)).EndInit();
            this.panelInsertOnu.ResumeLayout(false);
            this.panelInsertOnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListaOnu;
        private System.Windows.Forms.TextBox codOn;
        private System.Windows.Forms.TextBox NombOnu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelInsertOnu;
        private System.Windows.Forms.Button AgreOnu;
        private System.Windows.Forms.Button Eliminar;
    }
}