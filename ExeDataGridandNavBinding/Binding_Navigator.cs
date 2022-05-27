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

namespace ExeDataGridandNavBinding
{
    public partial class Binding_Navigator : Form
    {
        public Binding_Navigator()
        {
            InitializeComponent();
        }

        SqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        string connstring = "data source=DESKTOP-CRFOF2E; database=ProdiTI; Integrated Security=True; User ID=sa;Password=Zandev";
        private void Form2_Load(object sender, EventArgs e)
        {
            dadapter = new SqlDataAdapter("select * from Mahasiswa", connstring);
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator1.BindingSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Binding_Navigator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            this.CenterToScreen();
        }
    }
}
