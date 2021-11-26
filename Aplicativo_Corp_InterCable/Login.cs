using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Corp_InterCable
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario(InputUser.Text, InputPass.Text))
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","Mensaje del sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private Boolean ValidarUsuario(string user, string password)
        {
            bool valid = false;
            if (user== "intercable" && password == "intercable")
            {
                valid = true;
            }
            return valid;
        }
        

    }
}
