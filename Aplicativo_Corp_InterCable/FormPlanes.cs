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
            if( FiltroPlanes.Checked == true)
            {
                BusquedaVelPlan.Enabled = true;
                InputVelPlan.Enabled = true;
            }
            else
            {
                BusquedaVelPlan.Enabled = false;
                InputVelPlan.Enabled = false;
            }
        }

        private void FormPlanes_Load(object sender, EventArgs e)
        {
            BusquedaVelPlan.Enabled = false;
            InputVelPlan.Enabled = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TablePlanes.DataSource = "";
            TablePlanes.Refresh();
        }
    }
}
