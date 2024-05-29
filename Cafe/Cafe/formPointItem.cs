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
    public partial class formPointItem : Form
    {
        int pointId;
        public formPointItem(int id)
        {
            this.pointId = id;
            InitializeComponent();
        }

        SqlConnection cnct = new SqlConnection(Properties.Settings.Default.CafeConnectionString);

        private void formPointItem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDataSet2.Ингредиент". При необходимости она может быть перемещена или удалена.
            this.ингредиентTableAdapter.Fill(this.cafeDataSet2.Ингредиент);

            SqlCommand cmd = new SqlCommand("Продукты_на_точке", cnct);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ид_точки", pointId);
            cnct.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int rowId = dgvItems.Rows.Add();
                DataGridViewRow row = dgvItems.Rows[rowId];
                row.Cells[0].Value = Convert.ToInt32(reader["Id_ингредиент"]);
                row.Cells[1].Value = reader["Название"].ToString();
                row.Cells[2].Value = Convert.ToInt32(reader["Количество"]);


            }
            cnct.Close();



        }

        private void lbItems_DoubleClick(object sender, EventArgs e)
        {
            frmQuantity frmQuantity = new frmQuantity();
            if (frmQuantity.ShowDialog() == DialogResult.OK)
            {
                //флажок, служащий блокировкой создания дублей - добавлен ли  уже элемент в список; исходим из предположения, что ещё нет
                bool inCompound = false;
                for (int i = 0; i < dgvItems.Rows.Count; i++)
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

                if (inCompound == false)
                {
                    int rowNumber = dgvItems.Rows.Add();


                    dgvItems.Rows[rowNumber].Cells[0].Value = lbItems.SelectedValue;
                    dgvItems.Rows[rowNumber].Cells[1].Value = lbItems.Text;
                    dgvItems.Rows[rowNumber].Cells[2].Value = frmQuantity.tbQuant.Text;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("", cnct);

            //обновление состава блюда происходит крайне бесхитростно - удаляется старый состав и записывается новый
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM Ингредиент_точка_наличие WHERE id_пункт= {pointId}";
            cnct.Open();
            cmd.ExecuteNonQuery();
            cnct.Close();


            string values = "";
            for (int i = 0; i < dgvItems.Rows.Count; i++)

            {
                values += $"({pointId},{Convert.ToInt32(dgvItems.Rows[i].Cells[0].Value)}, {Convert.ToInt32(dgvItems.Rows[i].Cells[2].Value)}),";


            }



            cmd.CommandText = $"INSERT INTO Ингредиент_точка_наличие (id_пункт, id_ингредиент, Количество) VALUES {values.Remove(values.Length - 1)}";
            cnct.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Изменения успешно произведены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            //this.Close();

        }
    }
}
