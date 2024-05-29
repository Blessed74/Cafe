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

namespace Cafe
{
    public partial class formAdmin : Form
    {

        static SqlConnection sqlCnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        SqlCommand cmd = new SqlCommand("", sqlCnct);
        public formAdmin()
        {
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPromotions frmPromotions = new frmPromotions();
            this.Hide();
            frmPromotions.ShowDialog();
            this.Show();
            
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            this.Close();
            formClient fClient = (formClient)Application.OpenForms["formClient"];
            if (fClient == null)
                fClient = new formClient();
            fClient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            formAuthorization frmAuth = (formAuthorization)Application.OpenForms["formAuthorization"];
            frmAuth.Show();
            this.Close();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal frPers= new frmPersonal();
            this.Hide();
            frPers.ShowDialog();
            this.Show();
            
            
        }
    }
}
