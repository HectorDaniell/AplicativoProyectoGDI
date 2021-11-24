namespace Aplicativo_Corp_InterCable
{
    partial class FormPlanes
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
            this.TablePlanes = new System.Windows.Forms.DataGridView();
            this.BusquedaVelPlan = new System.Windows.Forms.Button();
            this.InputVelPlan = new System.Windows.Forms.TextBox();
            this.ListarPlanes = new System.Windows.Forms.Button();
            this.FiltroPlanes = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePlanes
            // 
            this.TablePlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePlanes.Location = new System.Drawing.Point(65, 132);
            this.TablePlanes.Name = "TablePlanes";
            this.TablePlanes.Size = new System.Drawing.Size(643, 256);
            this.TablePlanes.TabIndex = 1;
            this.TablePlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BusquedaVelPlan
            // 
            this.BusquedaVelPlan.Location = new System.Drawing.Point(635, 42);
            this.BusquedaVelPlan.Name = "BusquedaVelPlan";
            this.BusquedaVelPlan.Size = new System.Drawing.Size(75, 23);
            this.BusquedaVelPlan.TabIndex = 2;
            this.BusquedaVelPlan.Text = "Buscar";
            this.BusquedaVelPlan.UseVisualStyleBackColor = true;
            this.BusquedaVelPlan.Click += new System.EventHandler(this.BusquedaVelPlan_Click);
            // 
            // InputVelPlan
            // 
            this.InputVelPlan.Location = new System.Drawing.Point(529, 42);
            this.InputVelPlan.Name = "InputVelPlan";
            this.InputVelPlan.Size = new System.Drawing.Size(100, 20);
            this.InputVelPlan.TabIndex = 3;
            // 
            // ListarPlanes
            // 
            this.ListarPlanes.Location = new System.Drawing.Point(65, 37);
            this.ListarPlanes.Name = "ListarPlanes";
            this.ListarPlanes.Size = new System.Drawing.Size(48, 23);
            this.ListarPlanes.TabIndex = 4;
            this.ListarPlanes.Text = "Listar";
            this.ListarPlanes.UseVisualStyleBackColor = true;
            this.ListarPlanes.Click += new System.EventHandler(this.ListarPlanes_Click);
            // 
            // FiltroPlanes
            // 
            this.FiltroPlanes.AutoSize = true;
            this.FiltroPlanes.Location = new System.Drawing.Point(392, 44);
            this.FiltroPlanes.Name = "FiltroPlanes";
            this.FiltroPlanes.Size = new System.Drawing.Size(119, 17);
            this.FiltroPlanes.TabIndex = 5;
            this.FiltroPlanes.Text = "Filtrar por Velocidad";
            this.FiltroPlanes.UseVisualStyleBackColor = true;
            this.FiltroPlanes.CheckedChanged += new System.EventHandler(this.FiltroPlanes_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(65, 66);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(48, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Limpiar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // FormPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.FiltroPlanes);
            this.Controls.Add(this.ListarPlanes);
            this.Controls.Add(this.InputVelPlan);
            this.Controls.Add(this.BusquedaVelPlan);
            this.Controls.Add(this.TablePlanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(223, 15);
            this.Name = "FormPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPlanes";
            this.Load += new System.EventHandler(this.FormPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablePlanes;
        private System.Windows.Forms.Button BusquedaVelPlan;
        private System.Windows.Forms.TextBox InputVelPlan;
        private System.Windows.Forms.Button ListarPlanes;
        private System.Windows.Forms.CheckBox FiltroPlanes;
        private System.Windows.Forms.Button Clear;
    }
}