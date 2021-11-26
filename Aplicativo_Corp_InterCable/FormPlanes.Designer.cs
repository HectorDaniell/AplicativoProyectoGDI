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
            this.button4 = new System.Windows.Forms.Button();
            this.AgregarPlan = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tv = new System.Windows.Forms.CheckBox();
            this.mbps = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.precioPlan = new System.Windows.Forms.TextBox();
            this.CodPlan = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePlanes)).BeginInit();
            this.AgregarPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePlanes
            // 
            this.TablePlanes.AllowUserToAddRows = false;
            this.TablePlanes.AllowUserToDeleteRows = false;
            this.TablePlanes.AllowUserToOrderColumns = true;
            this.TablePlanes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablePlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePlanes.Location = new System.Drawing.Point(38, 16);
            this.TablePlanes.Name = "TablePlanes";
            this.TablePlanes.ReadOnly = true;
            this.TablePlanes.Size = new System.Drawing.Size(537, 480);
            this.TablePlanes.TabIndex = 1;
            this.TablePlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TablePlanes.SelectionChanged += new System.EventHandler(this.TablePlanes_SelectionChanged);
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
            this.ListarPlanes.Location = new System.Drawing.Point(607, 76);
            this.ListarPlanes.Name = "ListarPlanes";
            this.ListarPlanes.Size = new System.Drawing.Size(115, 29);
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
            this.Clear.Location = new System.Drawing.Point(2, 471);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(30, 25);
            this.Clear.TabIndex = 6;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar Plan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar Plan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(607, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Clientes/Plan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AgregarPlan
            // 
            this.AgregarPlan.Controls.Add(this.button6);
            this.AgregarPlan.Controls.Add(this.button5);
            this.AgregarPlan.Controls.Add(this.label4);
            this.AgregarPlan.Controls.Add(this.label3);
            this.AgregarPlan.Controls.Add(this.tv);
            this.AgregarPlan.Controls.Add(this.mbps);
            this.AgregarPlan.Controls.Add(this.label2);
            this.AgregarPlan.Controls.Add(this.label1);
            this.AgregarPlan.Controls.Add(this.precioPlan);
            this.AgregarPlan.Controls.Add(this.CodPlan);
            this.AgregarPlan.Location = new System.Drawing.Point(603, 255);
            this.AgregarPlan.Name = "AgregarPlan";
            this.AgregarPlan.Size = new System.Drawing.Size(185, 217);
            this.AgregarPlan.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Agregar Plan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tv";
            // 
            // tv
            // 
            this.tv.AutoSize = true;
            this.tv.Location = new System.Drawing.Point(63, 96);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(15, 14);
            this.tv.TabIndex = 7;
            this.tv.UseVisualStyleBackColor = true;
            this.tv.CheckedChanged += new System.EventHandler(this.tv_CheckedChanged);
            // 
            // mbps
            // 
            this.mbps.Items.Add("10");
            this.mbps.Items.Add("8");
            this.mbps.Items.Add("6");
            this.mbps.Items.Add("4");
            this.mbps.Items.Add("2");
            this.mbps.Location = new System.Drawing.Point(63, 61);
            this.mbps.Name = "mbps";
            this.mbps.Size = new System.Drawing.Size(60, 20);
            this.mbps.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mbps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // precioPlan
            // 
            this.precioPlan.Location = new System.Drawing.Point(63, 128);
            this.precioPlan.Name = "precioPlan";
            this.precioPlan.Size = new System.Drawing.Size(73, 20);
            this.precioPlan.TabIndex = 3;
            // 
            // CodPlan
            // 
            this.CodPlan.Location = new System.Drawing.Point(63, 27);
            this.CodPlan.Name = "CodPlan";
            this.CodPlan.Size = new System.Drawing.Size(100, 20);
            this.CodPlan.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(762, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 25);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AgregarPlan);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.FiltroPlanes);
            this.Controls.Add(this.ListarPlanes);
            this.Controls.Add(this.InputVelPlan);
            this.Controls.Add(this.BusquedaVelPlan);
            this.Controls.Add(this.TablePlanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(223, 45);
            this.Name = "FormPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.FormPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePlanes)).EndInit();
            this.AgregarPlan.ResumeLayout(false);
            this.AgregarPlan.PerformLayout();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel AgregarPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precioPlan;
        private System.Windows.Forms.TextBox CodPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox tv;
        private System.Windows.Forms.DomainUpDown mbps;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
    }
}