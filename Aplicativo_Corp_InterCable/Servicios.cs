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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void ListarServ_Click(object sender, EventArgs e)
        {
            TablaServicios.Visible = true;
            TablaRecibos.Visible = false;
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * from SERVICIO";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    TablaServicios.DataSource = dt;
                    TablaServicios.Refresh();

                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TablaServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (TablaServicios.SelectedRows.Count > 0)
            {
                CampoModificar.Visible = true;
                CodCliServ.Enabled = false;
                VerPrecio.Enabled = false;
                CodCliServ.Text = TablaServicios.SelectedRows[0].Cells[0].Value.ToString();
                PlanServ.Text = TablaServicios.SelectedRows[0].Cells[1].Value.ToString();
                VerPrecio.Text = TablaServicios.SelectedRows[0].Cells[3].Value.ToString();


            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            CampoModificar.Visible = false;
            TablaServicios.Visible = true;
            TablaRecibos.Visible = false;
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT CodTarifa from Planes";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CodTarifa", typeof(string));
                    dt.Load(reader);
                    PlanServ.ValueMember = "CodTarifa";
                    PlanServ.DataSource = dt;
                    PlanServ.SelectedIndex = -1;

                    string sql2 = "SELECT TarifaM from PLANES where CodTarifa = '" + PlanServ.Text.ToString() + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        VerPrecio.Text = reader2["TarifaM"].ToString();
                    }



                    

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewPrecio_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql2 = "SELECT TarifaM from PLANES where CodTarifa = '" + PlanServ.Text.ToString() + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        VerPrecio.Text = reader2["TarifaM"].ToString();
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("sp_modificar_servicio", connection);
                    connection.Open();
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@CodCliente", SqlDbType.NVarChar, 7).Value = CodCliServ.Text;
                    adapter.SelectCommand.Parameters.Add("@NuevoCodTarifa", SqlDbType.NVarChar, 4).Value = PlanServ.Text;
                    adapter.SelectCommand.Parameters.Add("@NuevoMonto", SqlDbType.Float, 6).Value = VerPrecio.Text;
                    adapter.SelectCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Servicio Modificado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.None);
                    CampoModificar.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CampoModificar.Visible = false;
            TablaServicios.Visible = false;
            TablaRecibos.Visible = true;   
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_recibos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    TablaRecibos.DataSource = dt;
                    TablaRecibos.Refresh();

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TablaRecibos_SelectionChanged(object sender, EventArgs e)
        {
            if (TablaRecibos.SelectedRows.Count > 0)
            {

                NroRecibo.Text = TablaRecibos.SelectedRows[0].Cells[0].Value.ToString();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TablaServicios.DataSource = "";
            TablaServicios.Refresh();
            TablaRecibos.DataSource = "";
            TablaRecibos.Refresh();
            NroRecibo.Clear();
        }
    }
}
