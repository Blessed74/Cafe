namespace Cafe
{
    partial class frmPromotions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.списокакцийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet1 = new Cafe.CafeDataSet1();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.список_акцийTableAdapter = new Cafe.CafeDataSet1TableAdapters.Список_акцийTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДосрочноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокакцийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNew.Location = new System.Drawing.Point(533, 28);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(164, 39);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Создать";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(703, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 39);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbList
            // 
            this.lbList.DataSource = this.списокакцийBindingSource;
            this.lbList.DisplayMember = "Название";
            this.lbList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 29;
            this.lbList.Location = new System.Drawing.Point(0, 0);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(400, 371);
            this.lbList.TabIndex = 1;
            this.lbList.ValueMember = "id_акция";
            this.lbList.Click += new System.EventHandler(this.lbList_Click);
            this.lbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbList_MouseDown);
            // 
            // списокакцийBindingSource
            // 
            this.списокакцийBindingSource.DataMember = "Список_акций";
            this.списокакцийBindingSource.DataSource = this.cafeDataSet1;
            // 
            // cafeDataSet1
            // 
            this.cafeDataSet1.DataSetName = "CafeDataSet1";
            this.cafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDishes
            // 
            this.dgvDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDishes.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishes.Location = new System.Drawing.Point(400, 0);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.ReadOnly = true;
            this.dgvDishes.RowHeadersWidth = 51;
            this.dgvDishes.RowTemplate.Height = 24;
            this.dgvDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishes.Size = new System.Drawing.Size(491, 371);
            this.dgvDishes.TabIndex = 2;
            // 
            // список_акцийTableAdapter
            // 
            this.список_акцийTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.завершитьДосрочноToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 80);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // завершитьДосрочноToolStripMenuItem
            // 
            this.завершитьДосрочноToolStripMenuItem.Name = "завершитьДосрочноToolStripMenuItem";
            this.завершитьДосрочноToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.завершитьДосрочноToolStripMenuItem.Text = "Завершить досрочно";
            this.завершитьДосрочноToolStripMenuItem.Click += new System.EventHandler(this.завершитьДосрочноToolStripMenuItem_Click);
            // 
            // frmPromotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.dgvDishes);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список действующих акций";
            this.Load += new System.EventHandler(this.frmPromotions_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.списокакцийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.DataGridView dgvDishes;
        private CafeDataSet1 cafeDataSet1;
        private System.Windows.Forms.BindingSource списокакцийBindingSource;
        private CafeDataSet1TableAdapters.Список_акцийTableAdapter список_акцийTableAdapter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьДосрочноToolStripMenuItem;
    }
}