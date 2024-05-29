namespace Cafe
{
    partial class formEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIngr = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvWaiting = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCompleted = new System.Windows.Forms.DataGridView();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnApproveOrder = new System.Windows.Forms.Button();
            this.pnlError = new System.Windows.Forms.Panel();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiting)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIngr);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnIngr
            // 
            this.btnIngr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIngr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngr.Location = new System.Drawing.Point(596, 23);
            this.btnIngr.Name = "btnIngr";
            this.btnIngr.Size = new System.Drawing.Size(335, 40);
            this.btnIngr.TabIndex = 3;
            this.btnIngr.Text = "Заказать ингредиенты";
            this.btnIngr.UseVisualStyleBackColor = false;
            this.btnIngr.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(21, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lblName";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdress.Location = new System.Drawing.Point(21, 35);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(93, 25);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "lblAdress";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 536);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvWaiting);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ожидающие подтверждения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvWaiting
            // 
            this.dgvWaiting.AllowUserToAddRows = false;
            this.dgvWaiting.AllowUserToDeleteRows = false;
            this.dgvWaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWaiting.Location = new System.Drawing.Point(3, 3);
            this.dgvWaiting.Name = "dgvWaiting";
            this.dgvWaiting.ReadOnly = true;
            this.dgvWaiting.RowHeadersWidth = 51;
            this.dgvWaiting.RowTemplate.Height = 24;
            this.dgvWaiting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaiting.Size = new System.Drawing.Size(495, 492);
            this.dgvWaiting.TabIndex = 0;
            this.dgvWaiting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaiting_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCompleted);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выполненные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCompleted
            // 
            this.dgvCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompleted.Location = new System.Drawing.Point(3, 3);
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.ReadOnly = true;
            this.dgvCompleted.RowHeadersWidth = 51;
            this.dgvCompleted.RowTemplate.Height = 24;
            this.dgvCompleted.Size = new System.Drawing.Size(447, 471);
            this.dgvCompleted.TabIndex = 0;
            this.dgvCompleted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompleted_CellClick);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContent.Location = new System.Drawing.Point(509, 100);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.ReadOnly = true;
            this.dgvContent.RowHeadersWidth = 51;
            this.dgvContent.RowTemplate.Height = 24;
            this.dgvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContent.Size = new System.Drawing.Size(463, 131);
            this.dgvContent.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnApproveOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(509, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 58);
            this.panel2.TabIndex = 3;
            // 
            // btnApproveOrder
            // 
            this.btnApproveOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApproveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApproveOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApproveOrder.Location = new System.Drawing.Point(162, 17);
            this.btnApproveOrder.Name = "btnApproveOrder";
            this.btnApproveOrder.Size = new System.Drawing.Size(186, 40);
            this.btnApproveOrder.TabIndex = 4;
            this.btnApproveOrder.Text = "Выполнить заказ";
            this.btnApproveOrder.UseVisualStyleBackColor = false;
            this.btnApproveOrder.Click += new System.EventHandler(this.btnApproveOrder_Click);
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.dgvError);
            this.pnlError.Controls.Add(this.label1);
            this.pnlError.Location = new System.Drawing.Point(503, 258);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(485, 277);
            this.pnlError.TabIndex = 5;
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvError.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvError.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvError.Location = new System.Drawing.Point(3, 105);
            this.dgvError.Name = "dgvError";
            this.dgvError.ReadOnly = true;
            this.dgvError.RowHeadersWidth = 51;
            this.dgvError.RowTemplate.Height = 24;
            this.dgvError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvError.Size = new System.Drawing.Size(496, 168);
            this.dgvError.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Внимание! Заказ невозможен к исполнению, не хватает следующих ингредиентов:";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Название";
            this.Column4.HeaderText = "Название";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "итого";
            this.Column5.HeaderText = "Количество";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_блюдо";
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Название";
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Количество";
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(392, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // formEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 599);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "formEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма для работы сотрудника";
            this.Load += new System.EventHandler(this.formEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiting)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvWaiting;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.Button btnIngr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApproveOrder;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnBack;
    }
}