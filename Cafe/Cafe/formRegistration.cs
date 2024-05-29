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

namespace Cafe
{
    public partial class formRegistration : Form
    {
        int regime = 0;
        public formRegistration()
        {
            InitializeComponent();
        }

        public formRegistration(int reg)
        {
            InitializeComponent();
            this.regime = reg; //1 - клиент, 2 - сотрудник

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string info = "";
            if (tbPassword.Text != tbRPassword.Text) 
            {
                MessageBox.Show("Введенные пароли не совпадают", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
            try

            {


                SqlCommand cmd = new SqlCommand($"SELECT * FROM Логины WHERE Телефон='{mTbPhone.Text}'", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    MessageBox.Show("Телефон уже зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                conn.Close();




                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                
                //В зависимости от того, откуда была вызвана форма регистрации, будет выполняться одна или другая процедура. Набор полей почти одинаковый, отличается только одно
                if (regime == 1)
                {
                    info = "Клиент";
                    cmd.CommandText = "Вставка_клиент";
                }
                else
                {
                    info = "Сотрудник";
                    cmd.CommandText = "Вставка_сотрудник";
                    cmd.Parameters.AddWithValue("@id_пункт", cbPoint.SelectedValue);

                }

               
                cmd.Parameters.AddWithValue("@телефон", mTbPhone.Text);
                cmd.Parameters.AddWithValue("@фамилия", tbSurname.Text);
                cmd.Parameters.AddWithValue("@имя", tbName.Text);
                cmd.Parameters.AddWithValue("@отчество", tbPatronymic.Text);

              
             

                cmd.Parameters.AddWithValue("@пароль", tbPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{info} успешно зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }

            catch (Exception ex) 
            
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            { conn.Close(); }

            this.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet7.Пункт_обслуживания". При необходимости она может быть перемещена или удалена.
            this.пункт_обслуживанияTableAdapter.Fill(this.cafeDataSet7.Пункт_обслуживания);

            if (this.regime == 2)
            {
                label7.Visible = true;
                cbPoint.Visible = true;


                //хардкод значений - плохая практика!
                tbPassword.Location = new Point(230, 260);
                label5.Location = new Point(60, 260);

                tbRPassword.Location = new Point(230, 300);
                label6.Location = new Point(60, 300);



            }


            else
            {


                tbPassword.Location = new Point(230, 225);
                label5.Location = new Point(60, 225);

                tbRPassword.Location = new Point(230, 270);
                label6.Location = new Point(60, 270);




                label7.Visible = false;
                cbPoint.Visible = false;


            }


        }
    }
}
