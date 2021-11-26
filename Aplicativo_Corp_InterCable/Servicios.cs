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
using System.IO;

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
            generaRecibo.Visible = false;
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
            generaRecibo.Visible = true;
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
            generaRecibo.Visible = false;   
            TablaServicios.DataSource = "";
            TablaServicios.Refresh();
            TablaRecibos.DataSource = "";
            TablaRecibos.Refresh();
            NroRecibo.Clear();
        }

        private void generaRecibo_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();
                    int nroRecibo = int.Parse(NroRecibo.Text);


                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_genera_recibo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@CodClie";
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = nroRecibo;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader2 = cmd.ExecuteReader();
                    if (reader2.Read())
                    {
                       
                        TextWriter write = new StreamWriter(reader2["NumRecibo"].ToString()+" "+DateTime.Now.ToString("dd-MM-yyyy")+".txt");
                        write.WriteLine("----------------------------");
                        write.WriteLine(" *INTERCABLE    LINKS*");
                        write.WriteLine("RUC: 20601304571");
                        write.WriteLine("Calle Sánchez Trujillo 232");
                        write.WriteLine("Miraflores");
                        write.WriteLine("Telf. 054-265000");
                        write.WriteLine("----------------------------");
                        write.WriteLine("PERIODO       : 2021-09");
                        write.WriteLine("F.EMISION     : 30/"+DateTime.Now.Month+"/"+DateTime.Now.Year);
                        write.WriteLine("F.VENCIMIENTO : 08/"+ (DateTime.Now.Month+1 )+ "/" + DateTime.Now.Year);
                        write.WriteLine("----------------------------");
                        write.WriteLine("*ABONADO:*");
                        write.WriteLine(reader2["ApellidosNombres"].ToString().ToUpper());
                        write.WriteLine("CODIGO     : "+ reader2["CodCliente"].ToString());
                        write.WriteLine("DIRECCION  :");
                        write.WriteLine(reader2["Direccion"].ToString());
                        write.WriteLine(reader2["Distrito"].ToString());
                        write.WriteLine("----------------------------");
                        write.WriteLine("*TARIFA       : S/      "+ reader2["TarifaM"].ToString()+"*");
                        write.WriteLine("MONTO A PAGAR : S/      "+ reader2["MontoPagar"].ToString() + "*");
                        write.WriteLine("----------------------------");
                        write.WriteLine("PAGAR RECIBOS en Agentes de CAJA AREQUIPA");
                        write.WriteLine("Indicando nombre de la Empresa Intercable y codigo");
                        write.WriteLine("O pagar en Agente BCP cuenta corriente soles");
                        write.WriteLine("a nombre de Intercable Links, enviar foto del deposito");
                        write.WriteLine("indicando nombre del cliente o comunicar a la oficina");
                        write.Close();
                        MessageBox.Show("Recibos Generados Correctamente", "Mensaje el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    reader2.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void AllRecibo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();
            
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sp_recibos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    SqlDataReader reader2 = cmd.ExecuteReader();

                    string output = "";

                    while (reader2.Read())
                    {
                       // output = output + reader2.GetString(0)+"\n";
                                            
                        TextWriter write = new StreamWriter(reader2["NumRecibo"].ToString() + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".txt");
                        write.WriteLine("----------------------------");
                        write.WriteLine(" *INTERCABLE    LINKS*");
                        write.WriteLine("RUC: 20601304571");
                        write.WriteLine("Calle Sánchez Trujillo 232");
                        write.WriteLine("Miraflores");
                        write.WriteLine("Telf. 054-265000");
                        write.WriteLine("----------------------------");
                        write.WriteLine("PERIODO       : 2021-09");
                        write.WriteLine("F.EMISION     : 30/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                        write.WriteLine("F.VENCIMIENTO : 08/" + (DateTime.Now.Month + 1) + "/" + DateTime.Now.Year);
                        write.WriteLine("----------------------------");
                        write.WriteLine("*ABONADO:*");
                        write.WriteLine(reader2["ApellidosNombres"].ToString().ToUpper());
                        write.WriteLine("CODIGO     : " + reader2["CodCliente"].ToString());
                        write.WriteLine("DIRECCION  :");
                        write.WriteLine(reader2["Direccion"].ToString());
                        write.WriteLine(reader2["Distrito"].ToString());
                        write.WriteLine("----------------------------");
                        write.WriteLine("*TARIFA       : S/      " + reader2["TarifaM"].ToString() + "*");
                        write.WriteLine("MONTO A PAGAR : S/      " + reader2["MontoPagar"].ToString() + "*");
                        write.WriteLine("----------------------------");
                        write.WriteLine("PAGAR RECIBOS en Agentes de CAJA AREQUIPA");
                        write.WriteLine("Indicando nombre de la Empresa Intercable y codigo");
                        write.WriteLine("O pagar en Agente BCP cuenta corriente soles");
                        write.WriteLine("a nombre de Intercable Links, enviar foto del deposito");
                        write.WriteLine("indicando nombre del cliente o comunicar a la oficina");
                        write.Close();
                    }
                    MessageBox.Show("Recibos Generados Correctamente", "Mensaje el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //MessageBox.Show(output, "Mensaje el Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader2.Close();
                    cmd.Dispose();
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
