using Cafe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class formAddDish : Form
    {

        bool pictureExist; //флаг, загружена ли картинка
        bool pictureHasChanged = false; //флаг, изменялось ли изображение
        int id=-1;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        public formAddDish()

        {
           
            InitializeComponent();
        }

        //если форма будет окрываться в режиме изменения, то нужно понимать, какой товар будем изменить
        public formAddDish(int id)
        {
            this.id = id;
            InitializeComponent();

        }



        private void formAddDish_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet3.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.cafeDataSet3.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet2.Ингредиент". При необходимости она может быть перемещена или удалена.
            this.ингредиентTableAdapter.Fill(this.cafeDataSet2.Ингредиент);


            //если форма открывается в режиме добавления, всё должно быть пустым
            if (this.id == -1)
            {
                cbCategory.SelectedValue = -1;
                tbName.Text = "";
                numPrice.Value = 0;
                rbDescription.Text = "";
                pictureBox1.Image = Resources.empty_picture;
                this.Text = "Добавить новое блюдо в меню";
                btnAdd.Text = "Добавить";
            }
            //иначе значения должны загружаться из базы данных
            else
            {

                this.Text = "Изменить блюдо";
                btnAdd.Text = "Сохранить";
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Блюдо WHERE id_блюдо={id}", conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                tbName.Text = reader["Название"].ToString();
                numPrice.Value = Convert.ToInt32(reader["Цена"]);
                cbCategory.SelectedValue = Convert.ToInt32(reader["Id_категория"]);
                rbDescription.Text = reader["Описание"].ToString();
                if (!reader.IsDBNull(4))
                
                {  
                    pictureExist = true;

                    var oldImage = pictureBox1.Image;
                   
                    //Release resources from old image
                  


                    pictureBox1.Image = DBImage.LoadImage((byte[])reader["Изображение"]);


                    if (oldImage != null)
                        ((IDisposable)oldImage).Dispose();

                }




                conn.Close();


                cmd.CommandText = "Состав_блюда";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_блюдо", id);
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    {
                    int rowId = dgvItems.Rows.Add();
                    DataGridViewRow row = dgvItems.Rows[rowId];
                    row.Cells[0].Value = Convert.ToInt32(reader["Id_ингредиент"]);
                    row.Cells[1].Value = reader["Название"].ToString();
                    row.Cells[2].Value = Convert.ToInt32(reader["Количество"]);

                   



                }




                //DataTable dt = new DataTable();
                //dt.Load(reader);

                //dgvItems.DataSource = dt;
                conn.Close();





            }


        }

        private void lbItems_DoubleClick(object sender, EventArgs e)
        {
            frmQuantity frmQuantity = new frmQuantity();
            if (frmQuantity.ShowDialog() == DialogResult.OK) 
            {
                //флажок, служащий блокировкой создания дублей - добавлен ли  уже элемент в список; исходим из предположения, что ещё нет
                bool inCompound = false ;
                for (int i = 0; i<dgvItems.Rows.Count;i++) 
                {
                    if (Convert.ToInt32(dgvItems.Rows[i].Cells[0].Value) == Convert.ToInt32(lbItems.SelectedValue))
                    {
                        //если он уже есть в списке, добавляем введеное значение
                        inCompound = true;
                        int amount = Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value) + Convert.ToInt32(frmQuantity.tbQuant.Text);
                        dgvItems.Rows[i].Cells[2].Value = amount;
                        break;
                    }

                }

                if (inCompound==false) {
                    int rowNumber = dgvItems.Rows.Add();


                    dgvItems.Rows[rowNumber].Cells[0].Value = lbItems.SelectedValue;
                    dgvItems.Rows[rowNumber].Cells[1].Value = lbItems.Text;
                    dgvItems.Rows[rowNumber].Cells[2].Value = frmQuantity.tbQuant.Text;
                }
            }
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image fils (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureExist = true;
                pictureHasChanged = true;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //на форме существует некоторые обязательные к заполнению поля, проверяем
            string error = "";
            if (tbName.Text == "")
                    error += "\n - Название ";
            if (cbCategory.SelectedIndex == -1)
                error += "\n - Категория";
            if (numPrice.Value == 0) 
            error += "\n - Цена";

            if (error != "")
            {
                MessageBox.Show("Не все обязательные поля заполнены" + error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id==-1) //если форма открыта в режиме добавления
            try
            {
                SqlCommand cmd = new SqlCommand("Добавить_блюдо", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@название", tbName.Text);
                cmd.Parameters.AddWithValue("@категория_ид", cbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@цена", numPrice.Value);
                cmd.Parameters.AddWithValue("@описание", rbDescription.Text);
                //если изображение вставлено, "пустую" картинку загружать в БД смысла нет
                if (pictureExist)
                cmd.Parameters.Add(DBImage.uploadImage2(pictureBox1));



                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                sqlDataReader.Read();

                int dishId = Convert.ToInt32(sqlDataReader["номер"]);
                
                conn.Close();

                cmd.CommandType = CommandType.Text;



                string values = "";
                for (int i = 0; i < dgvItems.Rows.Count; i++)

                {
                    values += $"({dishId},{Convert.ToInt32(dgvItems.Rows[i].Cells[0].Value)}, {Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value)}),";


                }



                cmd.CommandText = $"INSERT INTO Ингредиент_Блюдо (id_блюдо, id_ингредиент, Количество) VALUES {values.Remove(values.Length - 1)}";
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Блюдо успешно добавлено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { conn.Close(); }


            else
            //    try
                {

                    SqlCommand cmd = new SqlCommand("Изменить_блюдо", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@название", tbName.Text);
                    cmd.Parameters.AddWithValue("@категория", cbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@цена", numPrice.Value);
                    cmd.Parameters.AddWithValue("@описание", rbDescription.Text);
                    cmd.Parameters.AddWithValue("@ид_блюдо", id);
                //если изображение вставлено, "пустую" картинку загружать в БД смысла нет; так же нет смысла лезть в БД, если изображение не менялось
                if (pictureExist && pictureHasChanged)
                {
                    cmd.Parameters.Add(DBImage.uploadImage2(pictureBox1));

                }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();

                    //обновление состава блюда происходит крайне бесхитростно - удаляется старый состав и записывается новый
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"DELETE FROM Ингредиент_блюдо WHERE id_блюдо= {id}";
                    cmd.ExecuteNonQuery() ;
                    conn.Close();


                    string values = "";
                    for (int i = 0; i < dgvItems.Rows.Count; i++)

                    {
                        values += $"({id},{Convert.ToInt32(dgvItems.Rows[i].Cells[0].Value)}, {Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value)}),";


                    }



                    cmd.CommandText = $"INSERT INTO Ингредиент_Блюдо (id_блюдо, id_ингредиент, Количество) VALUES {values.Remove(values.Length - 1)}";
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Изменения успешно произведены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();







                }
              //  catch (Exception ex)
              //  {
              //      MessageBox.Show(ex.Message);
                
               // }
               // finally 
               // { conn.Close(); }

            
         



        }




        //метод для загрузки изображения в базу данных
       

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Выйти без сохранения? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            




        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numPrice.Value > numPrice.Maximum)
                numPrice.Value = numPrice.Maximum;
        }
    }
}
