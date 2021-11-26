namespace Aplicativo_Corp_InterCable
{
    partial class AgregarServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodPlan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioPlan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butonPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar un nuevo Servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CodPlan
            // 
            this.CodPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CodPlan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CodPlan.FormattingEnabled = true;
            this.CodPlan.Items.AddRange(new object[] {
            "Mariano Melgar",
            "Miraflores"});
            this.CodPlan.Location = new System.Drawing.Point(32, 65);
            this.CodPlan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.CodPlan.Name = "CodPlan";
            this.CodPlan.Size = new System.Drawing.Size(118, 25);
            this.CodPlan.TabIndex = 33;
            this.CodPlan.SelectedIndexChanged += new System.EventHandler(this.Distrito_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Plan:";
            // 
            // PrecioPlan
            // 
            this.PrecioPlan.Location = new System.Drawing.Point(237, 70);
            this.PrecioPlan.Name = "PrecioPlan";
            this.PrecioPlan.Size = new System.Drawing.Size(72, 20);
            this.PrecioPlan.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butonPrueba
            // 
            this.butonPrueba.Location = new System.Drawing.Point(156, 68);
            this.butonPrueba.Name = "butonPrueba";
            this.butonPrueba.Size = new System.Drawing.Size(75, 22);
            this.butonPrueba.TabIndex = 37;
            this.butonPrueba.Text = "Ver Precio";
            this.butonPrueba.UseVisualStyleBackColor = true;
            this.butonPrueba.Click += new System.EventHandler(this.butonPrueba_Click);
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.butonPrueba);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrecioPlan);
            this.Controls.Add(this.CodPlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.AgregarServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CodPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioPlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butonPrueba;
    }
}