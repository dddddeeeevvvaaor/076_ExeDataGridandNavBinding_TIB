using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "Zandev";
            string password = "123";



            if (textUser.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi !!");
            }
            else if (textUser.Text != username || textPassword.Text != password)
            {
                MessageBox.Show("Username atau password yang anda masukkan salah !!");
            }
            else if (textUser.Text == username && textPassword.Text == password && checkBox1.Checked)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Harap setuju Term and Condition");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
