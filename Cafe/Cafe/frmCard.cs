using Cafe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class frmCard : Form
    {

        int id;
        SqlConnection sqlCnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        public frmCard(string name, int id)
        {
            InitializeComponent();
            this.id = id; 
            this.Text = name;
        }

        private void frmCard_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Изображение, Описание FROM Блюдо WHERE id_блюдо = {id}");
            cmd.Connection = sqlCnct;
            sqlCnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                if (!(reader.IsDBNull(0)))
                {
                    pictureBox1.Image = DBImage.LoadImage((byte[])reader["Изображение"]);

                 
                }
                rtbText.Text = reader["Описание"].ToString();

            }




            sqlCnct.Close();




        }

        private void frmCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            rtbText.Text = " ";
            pictureBox1.Image = Resources.empty_picture;

        }
    }
}
