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
    public partial class AgregarCliente : Form
    {
        DataTable tablaCliente = new DataTable();
        DataTable tablaTelefono = new DataTable();
        
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT CodONU from ONU";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CodONU", typeof(string));
                    dt.Load(reader);
                    CodOnu.ValueMember = "CodONU";
                    CodOnu.DataSource = dt;
                    CodOnu.SelectedIndex = -1;


                    //reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * from CLIENTE";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    ListaCliente.DataSource = dt;
                    ListaCliente.Refresh();

                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = ConectorBD.ConnectToDB())
            {
                try
                {
                   
                    SqlDataAdapter adapter = new SqlDataAdapter("InsertClie",connection);
                    connection.Open();
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@CodClie", SqlDbType.NVarChar, 7).Value= Cod.Text;
                    adapter.SelectCommand.Parameters.Add("@ApellNomb", SqlDbType.NVarChar, 40).Value=ApellNomb.Text;
                    adapter.SelectCommand.Parameters.Add("@Dni", SqlDbType.NVarChar, 8).Value=Dni.Text;
                    adapter.SelectCommand.Parameters.Add("@Estado", SqlDbType.NVarChar, 6).Value=Estado.Text;
                    adapter.SelectCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value=Direccion.Text ;
                    adapter.SelectCommand.Parameters.Add("@Distrito", SqlDbType.NVarChar, 15).Value=Distrito.Text;
                    
                    if(CodOnu.Text == "")
                    {
                        adapter.SelectCommand.Parameters.Add("@CodOnu", SqlDbType.NVarChar, 4).Value = DBNull.Value;
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.Add("@CodOnu", SqlDbType.NVarChar, 4).Value = CodOnu.Text;
                    }
                    
                    
                    adapter.SelectCommand.Parameters.Add("@Olt", SqlDbType.NVarChar, 7).Value=Olt.Text;
                    adapter.SelectCommand.Parameters.Add("@Alta", SqlDbType.Date).Value = Alta.Value;
                    adapter.SelectCommand.Parameters.Add("@Deuda", SqlDbType.NVarChar, 6).Value=Deuda.Text;
                    adapter.SelectCommand.Parameters.Add("@Comentario", SqlDbType.NVarChar, 100).Value=Comen.Text;
                    adapter.SelectCommand.ExecuteNonQuery();

                    connection.Close();




                    SqlDataAdapter adapter2 = new SqlDataAdapter("InsertTele", connection);
                    connection.Open();
                    adapter2.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter2.SelectCommand.Parameters.Add("@CodClie", SqlDbType.NVarChar, 7).Value = Cod.Text;
                    adapter2.SelectCommand.Parameters.Add("@Telf", SqlDbType.NVarChar,9).Value = Telef.Text;
                    adapter2.SelectCommand.ExecuteNonQuery();

                    connection.Close();


                    MessageBox.Show("Registro Insertado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CodOnu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
