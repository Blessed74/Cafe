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
    public partial class formHistory : Form
    {

        SqlConnection cnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        public formHistory()
        {
            InitializeComponent();
        }

        private void formHistory_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"SELECT id_заказ, CAST(Дата as DATE) as Дата, Сумма, Статус FROM Заказы WHERE id_клиент = {Properties.Settings.Default.userId}");
            sqlCommand.Connection = cnct;
            cnct.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgvOrders.DataSource = dt;
            cnct.Close();









        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand($"Состав_заказ");
            sqlCommand.Connection = cnct;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "Состав_заказ";
            sqlCommand.Parameters.AddWithValue("@ид_заказ", Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value));




            cnct.Open();
            SqlDataReader rdr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgvItems.DataSource = dt;
            cnct.Close();
            dgvItems.Columns[0].Visible = false;




        }



        private void dgvOrders_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = dgvOrders.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex == -1) return;

                if (dgvOrders.CurrentRow == null) return;


                if (e.Button == MouseButtons.Right)
                {
                    dgvOrders.ClearSelection();
                    dgvOrders.Rows[rowIndex].Selected = true;

                    contextMenuStrip1.Show(dgvOrders, e.Location);



                }

                if (Convert.ToBoolean(dgvOrders.Rows[rowIndex].Cells[3].Value) == true)
                    отменитьЗаказToolStripMenuItem.Visible = false;
                else
                    отменитьЗаказToolStripMenuItem.Visible = true;
            }
            catch { }


        }

        private void отменитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sqlCommand = new SqlCommand($"Отменить_заказ");
                sqlCommand.Connection = cnct;
                cnct.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ид_заказ", Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value));
                sqlCommand.ExecuteNonQuery();
                cnct.Close();


                formHistory_Load(sender, e);



            }
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все элементы выбранного заказа будут добавлены в корзину, продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Good> listGoods = new List<Good>();
                int id;
                string name;
                int amount;
                int price;
                string info = "";
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader reader;
                sqlCommand.Connection = cnct;


                //добавляем все товары, проходя по строкам таблицы по очереди
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {

                    bool isDel;
                    id = Convert.ToInt32(dgvItems.Rows[i].Cells[0].Value);
                    //проверка - есть ли такое блюдо в нашем меню на текущий момент
                    cnct.Close();
                    sqlCommand.CommandText = $"SELECT id_блюдо FROM Блюдо WHERE Id_блюдо = {id} AND дата_удаления IS NOT NULL";
                    cnct.Open();
                    reader = sqlCommand.ExecuteReader();
                    reader.Read();
                    isDel = reader.HasRows;
                    cnct.Close();
                    

                 
                    
                    if (isDel)
                    {
                        info += $"\n-{dgvItems.Rows[i].Cells[1].Value.ToString()}";


                    }
                   
                    else
                    {


                        cnct.Open();

                        name = dgvItems.Rows[i].Cells[1].Value.ToString();
                        amount = Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value);
                        //товар может оказаться акционным, поэтому цену нужно сверять с акциями
                        sqlCommand.CommandText = $"SELECT Цена FROM Актуальные_цены WHERE Id_блюдо = {id}";
                        reader = sqlCommand.ExecuteReader();
                        reader.Read();
                        price = Convert.ToInt32(reader["Цена"]);

                        cnct.Close();





                        listGoods.Add(new Good(id, name, amount, price));
                        cnct.Close();
                    }

                    //манипулируем объектами на главной форме, добавляем все товары туда
                    formClient fm = (formClient)Application.OpenForms["formClient"];
                    fm.goods = listGoods;
                    fm.checkBasket();
                    fm.lblQuant.Text = listGoods.Count.ToString();
                    fm.lblSum.Text = fm.sumBasket().ToString();
                    this.Close();
                }


                MessageBox.Show($"К сожалению, мы больше не можем приготовить следующие блюда: {info}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }



        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = Application.OpenForms["formClient"];
            fm.Show();
            this.Close();
        }
    }
}
