using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cafe
{

    

    public partial class formClient : Form
    {

       public List <Good> goods = new List <Good> ();

        static SqlConnection sqlCnct =  new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        SqlCommand cmd = new SqlCommand("", sqlCnct);

        public formClient()
        {
            InitializeComponent();
        }

        private void formClient_Load(object sender, EventArgs e)
        {




            Properties.Settings.Default.closedByButton = false;
            this.категорииTableAdapter.Fill(this.cafeDataSet.Категории);
            lbCategories.SelectedIndex = 0;


            if (Properties.Settings.Default.roleId == 2)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                btnAdd.Visible = true;
                btnHistory.Visible = false;
                btnNewItem.Visible = true;


            }

            else
            {

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnAdd.Visible = false;
                btnHistory.Visible = true;
                btnNewItem.Visible = false;


            }






            loadDishes();

 //          dgvDishes.Rows[0].Selected = true;
            loadDishContent();
            //настройка отображения элементов формы для администратора




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDishes();
            loadDishContent();
            lblAct.Visible = false;
        }


        private void loadDishes()
        {
         

            if (lbCategories.SelectedValue != null)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT id_блюдо, Название,  Цена FROM Блюдо WHERE id_категория={lbCategories.SelectedValue} AND  дата_удаления IS  NULL";
                sqlCnct.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                dgvDishes.DataSource = dataTable;
                sqlCnct.Close();






                foreach (DataGridViewRow row in dgvDishes.Rows)
                {
                    cmd.CommandText = $"SELECT * FROM Блюдо_в_акции WHERE id_блюдо = {Convert.ToInt32(row.Cells[0].Value)}";
                    sqlCnct.Open();
                    sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        //акционные товары подсвечиваются
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7fff00");
                        row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) * (1 - (0.01 * Convert.ToInt32(sqlDataReader["Процент_скидки"])));



                    }




                    sqlCnct.Close();


                }
            }




            


        }

        //подгрузка состава блюдо
        private void loadDishContent()
        {
           
            



            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Состав_блюда";
            cmd.Parameters.Clear();
            int id;
            //проверка на NULL, чтобы процедура не пыталась вызываться при пустой dgview
            if (dgvDishes.CurrentRow != null)
                id = Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value);
            else
                id = 0;

            cmd.Parameters.AddWithValue("@id_блюдо", Convert.ToInt32(id));

           
                sqlCnct.Open();

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                dgvIngredients.DataSource = dataTable;

                sqlCnct.Close();






            }
          
        

 
        private void dgvDishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDishes.CurrentRow.Selected = true;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"SELECT * FROM Блюдо_в_акции WHERE id_блюдо = {Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value)}";
            sqlCnct.Open() ;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
               
                lblAct.Text = "Акция!" + " " + sqlDataReader["Название"].ToString()+" "+sqlDataReader["Дата"].ToString();
                lblAct.Visible = true;
            }
            else
            {
                lblAct.Visible=false;
                lblAct.Text = "Акция!";

            }
            sqlCnct.Close();


            loadDishContent();
        }

        private void formClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //closedByButton - переменная, которая хранит в себе флаг: событие FormClosing было вызвано нажатием на кнопку "назад" или "крестиком" (true - кнопкой, false - крестиком)
            if (!Properties.Settings.Default.closedByButton)
            {
                DialogResult dr = MessageBox.Show("Вы уверены что хотите завершить работу с приложением? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.OpenForms["formAuthorization"].Close();

                }
                else
                    e.Cancel = true; //отмена события
            }
         
        }

      

 

        private void dgvDishes_MouseDown(object sender, MouseEventArgs e)
        {
            //ищем номер текущей строки по координатам щелчка мыши
            int rowIndex = dgvDishes.HitTest(e.X, e.Y).RowIndex;


            if (rowIndex == -1) return;

            if (dgvDishes.CurrentRow == null) return;
    

            if (e.Button == MouseButtons.Right)
            { 
                dgvDishes.ClearSelection();
                dgvDishes.Rows[rowIndex].Selected = true;
                
                //контекстное меню показывается в зависимости от роли
                if (Properties.Settings.Default.roleId==1)
                contextMenuStrip1.Show(dgvDishes, e.Location);
                else
               contextMenuStrip2.Show(dgvDishes, e.Location);



            }
        }


        //проверяем, есть товары в корзине или нет
        public void checkBasket()
        {
            if (goods.Count == 0)
                pnlBasket.Visible = false;
            else
                pnlBasket.Visible = true;


        }


        private void вКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantity frmQuantity = new frmQuantity();
            int quant;
            int id;



            if (frmQuantity.ShowDialog(this) == DialogResult.OK)
            {
                id = Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value);
                quant = Convert.ToInt32(frmQuantity.tbQuant.Text);
                bool inBasket=false;

                if (goods.Count > 0) 
                
                { 
                    //проверяем, вдруг уже в корзине лежит
                    foreach (Good item in goods) 
                    {
                        if (item.Id ==  id)
                        { inBasket = true;
                            item.Quantity += Convert.ToInt32(frmQuantity.tbQuant.Text);
                            lblSum.Text = sumBasket().ToString();
                            break; }
                    }

                    if (inBasket)
                    {
                        return;


                    }
                
                }
                
                    
                


                goods.Add(new Good(Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value), dgvDishes.CurrentRow.Cells[1].Value.ToString(), quant, Convert.ToInt32(dgvDishes.CurrentRow.Cells[2].Value)));

                checkBasket();
               

            }

            lblQuant.Text = goods.Count.ToString();
            
          
            lblSum.Text = sumBasket().ToString();



           
        }

        public int sumBasket()
        {
            int sum = 0;
            if (goods.Count > 0)
                foreach (Good item in goods)
                {
                    sum += item.Price * item.Quantity;
                }
            return sum;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value);
            frmCard card = new frmCard(dgvDishes.CurrentRow.Cells[1].Value.ToString(), id);
          
            card.ShowDialog();



        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.closedByButton = true;
            this.Close();
            Form fm = Application.OpenForms["formAuthorization"];
            fm.Show();
        
          
        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
            frmPromotions frmPromotions = new frmPromotions();
            this.Hide();
            frmPromotions.ShowDialog();
            this.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            formHistory frm = new formHistory();
            this.Hide();
            frm.ShowDialog();
            this.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddDish formAddDish = new formAddDish();
            this.Hide();
            formAddDish.ShowDialog();
            this.Show();
        }

        private void dgvDishes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
            }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.roleId == 2)
            {

                formAddDish frm = new formAddDish(Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value));
                this.Hide();
                frm.ShowDialog();
                this.Show();
                

                    }
        }


        private void formClient_Activated(object sender, EventArgs e)
        {
           

           

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value); ;
           
            if (MessageBox.Show($"Вы действительно хотите удалить  {dgvDishes.CurrentRow.Cells[1].Value.ToString()}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {

              

               SqlCommand cmd = new SqlCommand($"Удалить_блюдо", sqlCnct);
               cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvDishes.CurrentRow.Cells[0].Value));
                sqlCnct.Open();
                cmd.ExecuteNonQuery();
                sqlCnct.Close();

                int catNo = lbCategories.SelectedIndex;
                loadDishes();
                lbCategories.SelectedIndex = catNo;
                


            }
        }

        private void btnBackToAdm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.closedByButton = true;
            formAdmin frm = new formAdmin();
            frm.Show();
            this.Close();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmAddItem frmAddItem = new frmAddItem();
            frmAddItem.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frmOrder fm = new frmOrder(goods);
            if (fm.ShowDialog() == DialogResult.OK) 
            {
                this.formClient_Load(sender, e);
                this.goods.Clear();
                checkBasket();
            }
           
        }
    }
    
}
