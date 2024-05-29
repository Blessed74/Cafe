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



    public partial class formAuthorization : Form
    {
        public formAuthorization()
        {
            InitializeComponent();
        }

        private void formAuthorization_Load(object sender, EventArgs e)
        {
            //при загрузке приложения происходит чтение файла со строкой подключения
            StreamReader sr = new StreamReader("connection_string.txt");
            Properties.Settings.Default.CafeConnectionString = sr.ReadLine();


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Логины WHERE Телефон = '{tbLogin.Text}' AND пароль= '{tbPassword.Text}'");

            try
            {
                cmd.Connection = conn;
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();

                    int role = Convert.ToInt32(sqlDataReader["id_роль"]);
                    if (role == 1)
                    {




                        Properties.Settings.Default.roleId = 1;
                        cmd.CommandText = $"SELECT * FROM Клиенты WHERE id_логин = {Convert.ToInt32(sqlDataReader["id_логин"])}";
                        conn.Close();
                        conn.Open();
                        SqlDataReader sqlRdr = cmd.ExecuteReader();
                        if (sqlRdr.HasRows)
                        {
                            sqlRdr.Read();
                            Properties.Settings.Default.userId = Convert.ToInt32(sqlRdr["id_логин"]);

                        }

                        this.Hide();

                        //проверяем, есть ли открытая форма formClient. Если она уже была открыта ранее, открываем её, иначе создаём новую
                        formClient fClient =(formClient)Application.OpenForms["formClient"];
                        if (fClient==null)
                            fClient = new formClient();



                        fClient.label1.Text ="Добро пожаловать, "+ " "+ sqlRdr["Фамилия"] + " " + sqlRdr["Имя"] + " " + sqlRdr["Отчество"];

                        fClient.label2.Text = sqlRdr["Номер_карты_клиента"].ToString();
                        fClient.label3.Text = sqlRdr["Количество_баллов"].ToString();



                        fClient.Show();
                        


                    }

                    if (role == 2)
                    {
                        this.Hide();
                        Properties.Settings.Default.roleId = 2;
                        formAdmin frmAdm = new formAdmin();
                        frmAdm.Show();
                       
                     


                    }

                    if (role==3)
                    {


                        Properties.Settings.Default.roleId = 3;
                        cmd.CommandText = $"SELECT * FROM Сотрудники WHERE id_логин = {Convert.ToInt32(sqlDataReader["id_логин"])}";
                        conn.Close();
                        conn.Open();
                        SqlDataReader sqlRdr = cmd.ExecuteReader();
                        if (sqlRdr.HasRows)
                        {
                            sqlRdr.Read();
                            Properties.Settings.Default.userId = Convert.ToInt32(sqlRdr["id_логин"]);

                        }

                        this.Hide();

                        formEmployee formEmployee = new formEmployee();
                        formEmployee.ShowDialog();

                        this.Show();




                    }



                }
                else
                {

                    MessageBox.Show("Неправильные логин или пароль");

                }


                conn.Close();

            }
            catch (Exception ex)            
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRegistration formRegistration = new formRegistration(1);
            this.Hide();
            formRegistration.ShowDialog();
            this.Show();
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tbLogin.Text = "+7(231) 232-13-13";
                tbPassword.Text = "321";


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tbPassword.Text = "123";
                tbLogin.Text = "+7(123) 123-12-99";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tbPassword.Text = "321";
                tbLogin.Text = "+7(999) 111-22-23";

            }

        }
    }
}
