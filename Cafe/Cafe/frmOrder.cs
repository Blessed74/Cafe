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
    public partial class frmOrder : Form
    {
        List<Good> goods;
        int points;
        int pointsSpent;
        
        public frmOrder(List<Good> gd)
        {
            goods = gd;
            InitializeComponent();
        }


        private void sumOnLabel()
        {
            int sum = 0;
            foreach (DataGridViewRow rw in dgvOrder.Rows)
            {
                sum += Convert.ToInt32(rw.Cells[2].Value) * Convert.ToInt32(rw.Cells[3].Value);


            }




            //тратим баллы, но оплатить баллами можно максимум половину покупки
            if (checkBox1.Checked)
            {
                if (points < (sum/2) )
                {
                    label3.Visible = false;
                    sum = sum - points;
                    pointsSpent = points;
                }
                else
                {
                    label3.Visible = true;
                    pointsSpent = points - (points - sum/2);
                    sum = sum/2;

                }
            }
            else
                pointsSpent = 0;

            lblSum.Text = sum.ToString();  


        }


        private void frmOrder_Load(object sender, EventArgs e)
        {
            
            foreach (Good g in goods) 
             {
                int rowNumber = dgvOrder.Rows.Add();
                dgvOrder.Rows[rowNumber].Cells[0].Value = g.Id;
                dgvOrder.Rows[rowNumber].Cells[1].Value = g.Name;
                dgvOrder.Rows[rowNumber].Cells[2].Value = g.Price;
                dgvOrder.Rows[rowNumber].Cells[3].Value = g.Quantity;

            
            }


           
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"SELECT Количество_баллов FROM Клиенты WHERE id_клиент = {Properties.Settings.Default.userId}",sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            points = Convert.ToInt32(reader["Количество_баллов"]);
            checkBox1.Text += $"({points})";
            sqlConnection.Close();


            dgvOrder_CellClick(sender,null);

            sumOnLabel();


        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            numericUpDown1.Value = Convert.ToInt32(dgvOrder.CurrentRow.Cells[3].Value);
           
           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            
                dgvOrder.CurrentRow.Cells[3].Value = numericUpDown1.Value;

            //если промотали до нуля, то будет предложено удалить.
                if (Convert.ToInt32(dgvOrder.CurrentRow.Cells[3].Value) == 0)

                    delPosition();

           



                sumOnLabel();
            



        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.CafeConnectionString);
            SqlCommand cmd = new SqlCommand("Создать_Заказ", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_id", Properties.Settings.Default.userId);
           
            cmd.Parameters.AddWithValue("@sum", Convert.ToInt32(lblSum.Text));


            



            sqlConnection.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();


            int orderId = Convert.ToInt32(sqlDataReader["номер"]);

            sqlConnection.Close();
            sqlConnection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE Клиенты SET Количество_баллов = Количество_баллов - {pointsSpent}";
            cmd.ExecuteNonQuery();


     
            string values = "";
            for (int i = 0; i < dgvOrder.Rows.Count; i++)

            {
                values += $"({orderId},{Convert.ToInt32(dgvOrder.Rows[i].Cells[0].Value)}, {Convert.ToInt32(dgvOrder.Rows[i].Cells[3].Value)}),";


            }
            sqlConnection.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =  $"INSERT INTO Заказ_Блюдо (id_заказ, id_блюдо, Количество) VALUES {values.Remove(values.Length-1)}";
            sqlConnection.Open();
            cmd.ExecuteNonQuery();

            string points;
            int sumPoints = Convert.ToInt32(lblSum.Text) / 10;

            if ((sumPoints % 10 == 1) && (sumPoints % 100) != 11)
                points = "балл";
            else if (((sumPoints % 10 == 2) || (sumPoints % 10 == 3) || (sumPoints % 10 == 4)) && ((sumPoints % 10 != 12) || (sumPoints % 10 != 13) || (sumPoints % 10 != 14)))
                points = "балла";
            else points = "баллов";

            MessageBox.Show($"Заказ успешно совершен. После подтверждения заказа сотрудником кафе, на ваш счёт будет добавлено {sumPoints} {points}","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult=DialogResult.OK;
           



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sumOnLabel();
            if (checkBox1.Checked==false)
                label3.Visible= false;
        }

        private void dgvOrder_MouseDown(object sender, MouseEventArgs e)
        {
            int rowIndex = dgvOrder.HitTest(e.X, e.Y).RowIndex;
            if (rowIndex == -1) return;

            if (dgvOrder.CurrentRow == null) return;


            if (e.Button == MouseButtons.Right)
            {
                dgvOrder.ClearSelection();
                dgvOrder.Rows[rowIndex].Selected = true;

                contextMenuStrip1.Show(dgvOrder, e.Location);



            }
        }


        private void delPosition()
        {
            if (MessageBox.Show("Вы хотите удалить этот товар из корзины?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dgvOrder.Rows.RemoveAt(dgvOrder.CurrentRow.Index);

                dgvOrder_CellClick(null, null);



            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delPosition();
          
        }
    }
}
