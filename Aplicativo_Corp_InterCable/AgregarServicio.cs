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
    public partial class AgregarServicio : Form
    {
        

        public AgregarServicio()
        {
            InitializeComponent();
            
        }

        private void Cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT CodTarifa from PLANES";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CodTarifa", typeof(string));
                    dt.Load(reader);
                    CodPlan.ValueMember = "CodTarifa";
                    CodPlan.DataSource = dt;
                    CodPlan.SelectedIndex = -1;

                    string sql2 = "SELECT TarifaM from PLANES where CodTarifa = '" + CodPlan.Text.ToString() + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        PrecioPlan.Text = reader2["TarifaM"].ToString();
                    }



                    //reader.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("sp_insertar_servicios", connection);
                    connection.Open();
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@CodClie", SqlDbType.NVarChar, 7).Value = AgregarCliente.codCliente;
                    adapter.SelectCommand.Parameters.Add("@CodTarifa", SqlDbType.NVarChar, 4).Value = CodPlan.Text;
                    adapter.SelectCommand.Parameters.Add("@NumRecibo", SqlDbType.NVarChar, 8).Value = AgregarCliente.codCliente;
                    adapter.SelectCommand.Parameters.Add("@MontoPagar", SqlDbType.Float, 6).Value = PrecioPlan.Text;
                    adapter.SelectCommand.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Servicio Agregado Correctamente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Distrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butonPrueba_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();
                                       
                    string sql2 = "SELECT TarifaM from PLANES where CodTarifa = '" + CodPlan.Text.ToString() + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        PrecioPlan.Text = reader2["TarifaM"].ToString();
                    }



                    //reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
