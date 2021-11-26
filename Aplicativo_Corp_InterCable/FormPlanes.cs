using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Corp_InterCable
{
    public partial class FormPlanes : Form
    {
        public FormPlanes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarPlanes_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * from PLANES";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    TablePlanes.DataSource = dt;
                    TablePlanes.Refresh();

                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BusquedaVelPlan_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();
                    int velocidadPlan = int.Parse(InputVelPlan.Text);


                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_buscar_plan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@VelocidadNet";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = velocidadPlan;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    TablePlanes.DataSource = dt;
                    TablePlanes.Refresh();

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FiltroPlanes_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroPlanes.Checked == true)
            {
                BusquedaVelPlan.Visible = true;
                InputVelPlan.Visible = true;
            }
            else
            {
                BusquedaVelPlan.Visible = false;
                InputVelPlan.Visible = false;
            }
        }

        private void FormPlanes_Load(object sender, EventArgs e)
        {
            BusquedaVelPlan.Visible = false;
            InputVelPlan.Visible = false;
            AgregarPlan.Visible = false;
            button1.Enabled = false;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TablePlanes.DataSource = "";
            TablePlanes.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_cuenta_clientes_plan";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    TablePlanes.DataSource = dt;
                    TablePlanes.Refresh();

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarPlan.Visible = true;
            button5.Visible = true;
            CodPlan.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("sp_insertar_planes", connection);
                    connection.Open();
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@CodTarifa", SqlDbType.NVarChar, 4).Value = CodPlan.Text;
                    adapter.SelectCommand.Parameters.Add("@VelocidadNet", SqlDbType.NVarChar, 3).Value = mbps.Text;
                    
                    if (tv.Checked)
                    {
                        adapter.SelectCommand.Parameters.Add("@TV", SqlDbType.NVarChar, 1).Value =1;
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.Add("@TV", SqlDbType.NVarChar, 1).Value =0;
                    }
                    adapter.SelectCommand.Parameters.Add("@TarifaM", SqlDbType.NVarChar, 6).Value = precioPlan.Text;
                    adapter.SelectCommand.ExecuteNonQuery();

                    connection.Close();
                    AgregarPlan.Visible = false;
                    MessageBox.Show("Registro Insertado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarPlan.Visible = false;
        }

        private void TablePlanes_SelectionChanged(object sender, EventArgs e)
        {
            button5.Visible = false;
            button1.Enabled = true;
            CodPlan.Enabled = false;
            if (TablePlanes.SelectedRows.Count > 0)
            {
                AgregarPlan.Visible = true;
                CodPlan.Text = TablePlanes.SelectedRows[0].Cells[0].Value.ToString();
                mbps.Text = TablePlanes.SelectedRows[0].Cells[1].Value.ToString();
                tv.Text= TablePlanes.SelectedRows[0].Cells[2].Value.ToString();
                if(tv.Text =="True")
                {
                    tv.Checked = true;
                }
                else
                {
                    tv.Checked = false;
                }
                precioPlan.Text = TablePlanes.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("sp_modificar_planes", connection);
                    connection.Open();
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@CodTarifa", SqlDbType.NVarChar, 4).Value = CodPlan.Text;
                    adapter.SelectCommand.Parameters.Add("@NuevaVelocidad ", SqlDbType.NVarChar, 3).Value = mbps.Text;
                    if(tv.Checked)
                    {
                        adapter.SelectCommand.Parameters.Add("@NuevoTV", SqlDbType.NVarChar, 1).Value = 1;
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.Add("@NuevoTV", SqlDbType.NVarChar, 1).Value = 0;
                    }
                    
                    adapter.SelectCommand.Parameters.Add("@NuevaTarifaM", SqlDbType.Float, 6).Value = precioPlan.Text;
                    adapter.SelectCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Plan Modificado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.None);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CodPlan.Text = "";
            mbps.Text = "";
            tv.Checked = false;
            precioPlan.Text = "";
        }
    }
}
