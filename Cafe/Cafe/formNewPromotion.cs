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
using System.Collections;

namespace Cafe
{
   public partial class formNewPromotion : Form
    {

        SqlConnection sqlConnect = new SqlConnection(Properties.Settings.Default.CafeConnectionString);


        //виртуальная таблица, она будет источником данных для списка товаров в акции
        DataTable dt = new DataTable();
        int id=-1; //для открытия формы в режиме "ИЗМЕНЕНИЕ" , ей передаётся ID выбранной акции

        //конструктор для режима "добавление"
        public formNewPromotion()
        {
            InitializeComponent(); 

        }
        //конструктор для режима "изменение"
        public formNewPromotion(int id)
        {
            this.id = id; 
            InitializeComponent();

            
            
        }

        private void formNewPromotion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.cafeDataSet.Категории);

            
            //определяем, как будет выгляедть источник данных для списка блюд в акции
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Название", typeof(String));
            lbInPromotion.DataSource = dt;
            lbInPromotion.ValueMember = "id";
            lbInPromotion.DisplayMember = "Название";



            //если форма открывается для изменения записи
            if (id!=-1)
            {
                btnPromotions.Visible = false;
                btnSave.Visible = true;
                

                //подгружаем выбранную запись, и выставляем значения полей в соответствующие компоненты на форме
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Акции WHERE id_акция = {id}");
                cmd.Connection = sqlConnect;
                sqlConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                tbName.Text = reader["Название"].ToString();
                dtBegin.Value = Convert.ToDateTime(reader["Дата_начала"]);
                dtEnd.Value = Convert.ToDateTime(reader["Дата_окончания"]);
                numPerc.Value = Convert.ToInt32(reader["Процент_скидки"]);
                sqlConnect.Close();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Блюда_акция";
                cmd.Parameters.AddWithValue("@ид_акции", id);
                sqlConnect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    DataRow newRow = dt.NewRow();
                    newRow["id"] = Convert.ToInt32(rdr["id_блюдо"]);
                    newRow["Название"] = rdr["Название"].ToString();
                    dt.Rows.Add(newRow);


                }



                sqlConnect.Close();


                


            }
            else
            {
                btnPromotions.Visible = true;
                btnSave.Visible = false;

            }



        }

        private void lbInPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand($"SELECT id_блюдо,Название FROM Блюда_не_в_акциях WHERE id_категория={lbCategories.SelectedValue}", sqlConnect);
            sqlConnect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            lbDishes.DataSource = dt;
            lbDishes.ValueMember = "id_блюдо";
            lbDishes.DisplayMember = "Название";
          
            sqlConnect.Close();
        }

        private void lbDishes_DoubleClick(object sender, EventArgs e)
        {
           
            //проверка на существование записи в списке
            for (int i=0; i<dt.Rows.Count; i++)
              {

                           
               
                if (Convert.ToInt32(lbDishes.SelectedValue) == Convert.ToInt32(dt.Rows[i]["id"]))
                    return;
                    
            }


            DataRow newRow = dt.NewRow();
            newRow["id"] = lbDishes.SelectedValue;
            newRow["Название"] = lbDishes.Text;
            dt.Rows.Add(newRow);
                    
            
           lbInPromotion.Refresh();

            



        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {

            if (tbName.Text == "")
            {
                MessageBox.Show("Введите название");
                return;

            }

            if (dtBegin.Value > dtEnd.Value) 
            {
                MessageBox.Show("Дата начала не может быть позже даты конца");
                return;
            }
            if (dtBegin.Value < DateTime.Now)
            {

                MessageBox.Show("Дата начала проведения акции не может быть раньше, чем сегодняшний день");
                return;

            }


            int id2;
            SqlCommand sqlCommand = new SqlCommand("Создать_акцию", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@название", tbName.Text);
            sqlCommand.Parameters.AddWithValue("@процент", numPerc.Value);
            sqlCommand.Parameters.AddWithValue("@дата_начала", dtBegin.Value);
            sqlCommand.Parameters.AddWithValue("@дата_окончания", dtEnd.Value);
            sqlConnect.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            id2 = Convert.ToInt32(sqlDataReader["номер"]);
            sqlConnect.Close();

            sqlCommand.CommandText = "Добавить_блюдо_в_акцию";


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                sqlConnect.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@ид_акция", id2);
                sqlCommand.Parameters.AddWithValue("@ид_блюдо", Convert.ToInt32(dt.Rows[i]["id"]));
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();


            }


            MessageBox.Show("Акция успешно создана","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();








        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPromotions frmPromotions = new frmPromotions();
            frmPromotions.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dtBegin.Value > dtEnd.Value)
            {
                MessageBox.Show("Дата начала не может быть позже даты конца");
                return;

            }

            if (dtBegin.Value < DateTime.Now)
            {

                MessageBox.Show("Дата начала проведения акции не может быть раньше, чем сегодняшний день");
                return;

            }

          





            SqlCommand sqlCommand = new SqlCommand("Изменить_акцию", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@название", tbName.Text);
            sqlCommand.Parameters.AddWithValue("@процент_скидки", numPerc.Value);
            sqlCommand.Parameters.AddWithValue("@дата_начала", dtBegin.Value);
            sqlCommand.Parameters.AddWithValue("@дата_окончания", dtEnd.Value);
            sqlCommand.Parameters.AddWithValue("@id_акции", id);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
          
            sqlConnect.Close();

            sqlConnect.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"DELETE FROM Акция_Блюдо WHERE id_акция= {id}";
            sqlCommand.ExecuteNonQuery();


            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "Добавить_блюдо_в_акцию";

            sqlConnect.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                sqlConnect.Open();
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@ид_акция", id);
                sqlCommand.Parameters.AddWithValue("@ид_блюдо", Convert.ToInt32(dt.Rows[i]["id"]));
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();


            }



            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Изменения успешно сохранены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }

        private void lbInPromotion_MouseDown(object sender, MouseEventArgs e)
        {


            

            var rowIndex = lbInPromotion.IndexFromPoint(e.X, e.Y);
                       



            if (rowIndex == -1) return;

            if (lbInPromotion.SelectedIndex == null) return;


            if (e.Button == MouseButtons.Right)
            {

                lbInPromotion.SelectedIndex = rowIndex;

                contextMenuStrip1.Show(lbInPromotion, e.Location);
               

            





            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)lbInPromotion.SelectedItem;
            dt.Rows.Remove(dataRow.Row);


        }

    }
}
