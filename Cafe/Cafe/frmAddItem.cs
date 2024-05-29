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
    public partial class frmAddItem : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbItem.Text == "")
                return;


            SqlCommand cmd = new SqlCommand($"SELECT Название FROM Ингредиент WHERE Название='{tbItem.Text}'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();  
            if(rdr.HasRows)
            {
                MessageBox.Show("Такой ингредиент уже есть в базе данных", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            conn.Close();

            cmd.CommandText = $"INSERT INTO Ингредиент (Название) VALUES ('{tbItem.Text}')";
            conn.Open ();
            cmd.ExecuteNonQuery();
            conn.Close ();

            this.DialogResult = DialogResult.OK;







        }
    }
}
