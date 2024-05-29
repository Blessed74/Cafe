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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        SqlConnection sqlCnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet7.Пункт_обслуживания". При необходимости она может быть перемещена или удалена.
            this.пункт_обслуживанияTableAdapter.Fill(this.cafeDataSet7.Пункт_обслуживания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet5.Уволенные_сотрудники". При необходимости она может быть перемещена или удалена.
            this.уволенные_сотрудникиTableAdapter.Fill(this.cafeDataSet5.Уволенные_сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet4.Действующие_сотрудники". При необходимости она может быть перемещена или удалена.
            this.действующие_сотрудникиTableAdapter.Fill(this.cafeDataSet4.Действующие_сотрудники);

            if (this.cafeDataSet4.Действующие_сотрудники.Rows.Count > 0)
            {
                dgvCurrent.Rows[0].Selected = true;
                dgvCurrent_CellClick(null, null);
            }




            SqlCommand command = new SqlCommand("SELECT Адрес FROM  Пункт_обслуживания", sqlCnct);
            sqlCnct.Open();
            SqlDataReader reader = command.ExecuteReader();
            cbFilter.Items.Add("Все");
            while (reader.Read())
                {
                cbFilter.Items.Add(reader["Адрес"].ToString());


            }
            sqlCnct.Close();

            cbFilter.SelectedIndex = 0;

        }


        private void dgvCurrent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Информация_о_сотруднике",sqlCnct);
            cmd.CommandType =  CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_сотрудник", dgvCurrent.CurrentRow.Cells[0].Value);
            sqlCnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cbPoints.SelectedValue = Convert.ToInt32(reader["id_пункта"]);
            tbPhone.Text = reader["Телефон"].ToString();
            tbName.Text = reader["Имя"].ToString();
            tbSurname.Text = reader["Фамилия"].ToString() ;
            tbPatronymic.Text = reader["Отчество"].ToString();
            sqlCnct.Close();




        }

        private void btnFired_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите уволить выбранного сотрудника?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"Уволить_сотрудника", sqlCnct) ;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_сотрудник", Convert.ToInt32(dgvCurrent.CurrentRow.Cells[0].Value));

                sqlCnct.Open();
                cmd.ExecuteNonQuery();
                sqlCnct.Close();

                frmPersonal_Load(sender, e);



            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPage2)
            {


                //dgvFired.Rows[0].Selected = true;


                panel2.Visible = false;


            }
            else
            {
                // dgvCurrent.Rows[0].Selected = true;
                panel2.Visible = true;



            }
        }

        private void dgvFired_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {





            if (MessageBox.Show("Принять изменения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Логины WHERE Телефон={tbPhone.Text} AND NOT  id_логин=(SELECT id_логин FROM Сотрудники WHERE id_сотрудник = {Convert.ToInt32(dgvCurrent.CurrentRow.Cells[0].Value)}", sqlCnct);
                sqlCnct.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    MessageBox.Show("Телефон уже зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                sqlCnct.Close();





                cmd.CommandText = "Изменить_данные_сотрудника";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_сотрудник", Convert.ToInt32(dgvCurrent.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("@id_пункта", cbPoints.SelectedValue);
                cmd.Parameters.AddWithValue("@телефон", tbPhone.Text);
                cmd.Parameters.AddWithValue("@фамилия", tbSurname.Text);
                cmd.Parameters.AddWithValue("@имя", tbName.Text);
                cmd.Parameters.AddWithValue("@отчество", tbPatronymic.Text);

                sqlCnct.Open();
                cmd.ExecuteNonQuery();
                sqlCnct.Close();

                frmPersonal_Load(sender, e);



            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            formRegistration formRegistration = new formRegistration(2);
            this.Hide();
            formRegistration.ShowDialog();
            this.Show();
            
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
                действующиесотрудникиBindingSource.Filter = "";
            // (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = "";
            else
                действующиесотрудникиBindingSource.Filter = $"Адрес='{cbFilter.Text}'";
        }
    }
}
