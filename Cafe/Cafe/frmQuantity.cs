using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe
{
    public partial class frmQuantity : Form
    {
        public frmQuantity()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbQuant.Text!="")
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;

           //this.Close();
        }

        private void tbQuant_KeyPress(object sender, KeyPressEventArgs e)
        {

          

            // Проверяем, что введенный символ не является управляющим символом, цифрой или Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Отменяем ввод символа
            }

            // Проверяем, что первый символ не является 0
            if (tbQuant.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true; // Отменяем ввод символа
            }

        }

        private void frmQuantity_Load(object sender, EventArgs e)
        {

        }
    }
}
