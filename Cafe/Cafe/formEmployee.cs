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
    public partial class formEmployee : Form
    {
        SqlConnection sqlCnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
        int pointID;
        
        public formEmployee()
        {
            InitializeComponent();
        }

        private void formEmployee_Load(object sender, EventArgs e)
        {

            //подгрузим данные сотрудниа
            SqlCommand  cmd = new SqlCommand($"SELECT по.id_пункт, Адрес, Фамилия+' '+Имя+' '+Отчество AS ФИО  FROM Сотрудники с JOIN Логины л ON с.id_логин = л.id_логин JOIN Пункт_обслуживания по ON с.Id_пункта = по.id_пункт WHERE с.id_логин={Properties.Settings.Default.userId}");
            cmd.Connection = sqlCnct;
            if (sqlCnct.State == ConnectionState.Closed)
            sqlCnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            pointID = Convert.ToInt32(reader["id_пункт"]);
            lblAdress.Text = reader["Адрес"].ToString();
            lblName.Text = reader["ФИО"].ToString();


            //подгружаем заказы
            sqlCnct.Close();
            cmd.CommandText = "SELECT id_заказ, Фамилия+' '+Имя+' '+Отчество as ФИО, Дата, Сумма FROM Заказы JOIN Клиенты ON Заказы.Id_клиент=Клиенты.Id_клиент WHERE Статус=0";
            sqlCnct.Open();
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvWaiting.DataSource = dt;
           



            dgvWaiting.Columns[0].Visible= false;
          
            cmd.CommandText = "Проверка_ингредиенты";
            cmd.CommandType = CommandType.StoredProcedure;

      
            //проверка - хватает ли для исполнения заказа ингредиентов. Если не хватает, строка подсветится красным цвеом
            for (int i = 0;  i < dgvWaiting.Rows.Count; i++)
            {
                sqlCnct.Close();
                cmd.Parameters.AddWithValue("@id_заказ", Convert.ToInt32(dgvWaiting.Rows[i].Cells[0].Value));
                sqlCnct.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    dgvWaiting.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F08080");

                }
                cmd.Parameters.Clear();
                


            }
        


            sqlCnct.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id_заказ, Фамилия+' '+Имя+' '+Отчество as ФИО, Дата, Сумма FROM Заказы JOIN Клиенты ON Заказы.Id_клиент=Клиенты.Id_клиент WHERE Статус=1";
            sqlCnct.Open();
            reader = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reader);
            dgvCompleted.DataSource = dt2;
            sqlCnct.Close();

            dgvCompleted.Columns[0].Visible = false;


            






        }

        private void dgvWaiting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //подгружаем блюда, входщяие в выбранный состав
            if (sqlCnct.State == ConnectionState.Open)
                sqlCnct.Close();
            SqlCommand cmd = new SqlCommand("Состав_заказ", sqlCnct);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ид_заказ", dgvWaiting.CurrentRow.Cells[0].Value);
            sqlCnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(reader);
            dgvContent.DataSource = dt3;
           
            cmd.Parameters.Clear(); //очищаем параметр, чтобы можно было новую процедуру на этот же объект SqlCommand повесить

            //проверяем, хватает ли ингредиентов. Если не хватает - показываем, чего именно и сколько не хватает
            cmd.CommandText = "Проверка_ингредиенты";
            cmd.CommandType = CommandType.StoredProcedure;
            sqlCnct.Close();
            cmd.Parameters.AddWithValue("@id_заказ", Convert.ToInt32(dgvWaiting.CurrentRow.Cells[0].Value));
            sqlCnct.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                pnlError.Visible = true;
                btnApproveOrder.Enabled = false;
                DataTable dt4 = new DataTable();
                dt4.Load(reader);
                dgvError.DataSource = dt4;

            }
            else
            {
                pnlError.Visible = false;
                btnApproveOrder.Enabled = true;
            }

                    

            






        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPointItem frm =new formPointItem(pointID);
            this.Hide();
            if (frm.ShowDialog() == DialogResult.OK)
                formEmployee_Load(sender,e);

            this.Show();

        }


        private void btnApproveOrder_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Принять_заказ", sqlCnct);
            if (sqlCnct.State == ConnectionState.Open) 
                sqlCnct.Close();
            sqlCnct.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ид_заказ", Convert.ToInt32(dgvWaiting.CurrentRow.Cells[0].Value));
            cmd.Parameters.AddWithValue("@ид_точка", pointID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Заказ успешно завершен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlCnct.Close();

            formEmployee_Load(sender, e);


        }

        private void dgvCompleted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //подгружаем блюда, входщяие в выбранный состав
            if (sqlCnct.State == ConnectionState.Open)
                sqlCnct.Close();
            SqlCommand cmd = new SqlCommand("Состав_заказ", sqlCnct);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ид_заказ", dgvCompleted.CurrentRow.Cells[0].Value);
            sqlCnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(reader);
            dgvContent.DataSource = dt3;
        }

       

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //если это выполненные заказы, то нет смысла, можно ли этот заказ выполнить 
            if (tabControl1.SelectedTab == tabPage2)
                pnlError.Visible = false;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
