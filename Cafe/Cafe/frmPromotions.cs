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
    public partial class frmPromotions : Form
    {
        SqlConnection cnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        public frmPromotions()
        {
            InitializeComponent();
        }

        private void frmPromotions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet1.Список_акций". При необходимости она может быть перемещена или удалена.
            this.список_акцийTableAdapter.Fill(this.cafeDataSet1.Список_акций);


            loadDishes();


            if (Properties.Settings.Default.roleId == 2)
                btnNew.Visible = true;
            else btnNew.Visible = false;


            //SqlCommand



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            

            if (Properties.Settings.Default.roleId == 1)
            {
                Form fm = Application.OpenForms["formClient"];
                fm.Show();
            }

            else
            {
                formAdmin fm = new formAdmin();
                fm.Show();

            }

            this.Close();

        }

        private void lbList_Click(object sender, EventArgs e)
        {


            loadDishes();

        }



        private void loadDishes()
        {
          
            cnct.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnct;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Блюда_акция";
            cmd.Parameters.AddWithValue("@ид_акции", lbList.SelectedValue);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvDishes.DataSource = dt;
            dgvDishes.Columns[2].Visible = false;
            cnct.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            formNewPromotion frmNewPrm = new formNewPromotion();
            this.Hide();
            frmNewPrm.ShowDialog();
            frmPromotions_Load(sender,e);
            this.Show();
        }

        private void lbList_MouseDown(object sender, MouseEventArgs e)
        {
            //отображение контекстного меню
            if (Properties.Settings.Default.roleId != 2)
                return;

                var rowIndex = lbList.IndexFromPoint(e.X, e.Y);


            if (rowIndex == -1) return;

            if (lbList.SelectedIndex == null) return;


            if (e.Button == MouseButtons.Right)
            {

                lbList.SelectedIndex = rowIndex;
                
                    contextMenuStrip1.Show(lbList, e.Location);
               





            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNewPromotion frm = new formNewPromotion(Convert.ToInt32(lbList.SelectedValue));
            this.Hide();
            
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                frmPromotions_Load(sender,e);


            }
            this.Show();

        }

        private void завершитьДосрочноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Акции SET дата_окончания = GETDATE() WHERE id_акция = {lbList.SelectedValue} DELETE FROM Акция_Блюдо WHERE id_акция={lbList.SelectedValue}");
                
                cmd.Connection = cnct;
                cnct.Open();
                cmd.ExecuteNonQuery();
                cnct.Close();
                frmPromotions_Load(sender, e);
            }
        }
    }
}
