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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanes));
            this.TablePlanes = new System.Windows.Forms.DataGridView();
            this.BusquedaVelPlan = new System.Windows.Forms.Button();
            this.InputVelPlan = new System.Windows.Forms.TextBox();
            this.ListarPlanes = new System.Windows.Forms.Button();
            this.FiltroPlanes = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePlanes
            // 
            this.TablePlanes.AllowUserToAddRows = false;
            this.TablePlanes.AllowUserToDeleteRows = false;
            this.TablePlanes.AllowUserToOrderColumns = true;
            this.TablePlanes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablePlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePlanes.Location = new System.Drawing.Point(12, 12);
            this.TablePlanes.Name = "TablePlanes";
            this.TablePlanes.ReadOnly = true;
            this.TablePlanes.Size = new System.Drawing.Size(577, 426);
            this.TablePlanes.TabIndex = 1;
            this.TablePlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BusquedaVelPlan
            // 
            this.BusquedaVelPlan.Location = new System.Drawing.Point(713, 37);
            this.BusquedaVelPlan.Name = "BusquedaVelPlan";
            this.BusquedaVelPlan.Size = new System.Drawing.Size(75, 23);
            this.BusquedaVelPlan.TabIndex = 2;
            this.BusquedaVelPlan.Text = "Buscar";
            this.BusquedaVelPlan.UseVisualStyleBackColor = true;
            this.BusquedaVelPlan.Click += new System.EventHandler(this.BusquedaVelPlan_Click);
            // 
            // InputVelPlan
            // 
            this.InputVelPlan.Location = new System.Drawing.Point(607, 39);
            this.InputVelPlan.Name = "InputVelPlan";
            this.InputVelPlan.Size = new System.Drawing.Size(100, 20);
            this.InputVelPlan.TabIndex = 3;
            // 
            // ListarPlanes
            // 
            this.ListarPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarPlanes.Location = new System.Drawing.Point(643, 80);
            this.ListarPlanes.Name = "ListarPlanes";
            this.ListarPlanes.Size = new System.Drawing.Size(115, 39);
            this.ListarPlanes.TabIndex = 4;
            this.ListarPlanes.Text = "Listar Planes";
            this.ListarPlanes.UseVisualStyleBackColor = true;
            this.ListarPlanes.Click += new System.EventHandler(this.ListarPlanes_Click);
            // 
            // FiltroPlanes
            // 
            this.FiltroPlanes.AutoSize = true;
            this.FiltroPlanes.Location = new System.Drawing.Point(603, 16);
            this.FiltroPlanes.Name = "FiltroPlanes";
            this.FiltroPlanes.Size = new System.Drawing.Size(119, 17);
            this.FiltroPlanes.TabIndex = 5;
            this.FiltroPlanes.Text = "Filtrar por Velocidad";
            this.FiltroPlanes.UseVisualStyleBackColor = true;
            this.FiltroPlanes.CheckedChanged += new System.EventHandler(this.FiltroPlanes_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.Location = new System.Drawing.Point(595, 412);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(30, 26);
            this.Clear.TabIndex = 6;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(643, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar Plan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(643, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar Plan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(643, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar Plan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(643, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Clientes/Plan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Text = "Planes";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}