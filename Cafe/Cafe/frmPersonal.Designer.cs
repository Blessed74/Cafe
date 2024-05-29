namespace Cafe
{
    partial class frmPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCurrent = new System.Windows.Forms.DataGridView();
            this.idсотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаприёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.действующиесотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet4 = new Cafe.CafeDataSet4();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFired = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаприёмаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаувольненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уволенныесотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet5 = new Cafe.CafeDataSet5();
            this.действующие_сотрудникиTableAdapter = new Cafe.CafeDataSet4TableAdapters.Действующие_сотрудникиTableAdapter();
            this.уволенные_сотрудникиTableAdapter = new Cafe.CafeDataSet5TableAdapters.Уволенные_сотрудникиTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFired = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPoints = new System.Windows.Forms.ComboBox();
            this.пунктобслуживанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSet7 = new Cafe.CafeDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.пункт_обслуживанияTableAdapter = new Cafe.CafeDataSet7TableAdapters.Пункт_обслуживанияTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующиесотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уволенныесотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пунктобслуживанияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet7)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(4, -2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(224, 40);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Новый сотрудник";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 388);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgvCurrent);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Действующие";
            // 
            // dgvCurrent
            // 
            this.dgvCurrent.AllowUserToAddRows = false;
            this.dgvCurrent.AllowUserToDeleteRows = false;
            this.dgvCurrent.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idсотрудникDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.датаприёмаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dgvCurrent.DataSource = this.действующиесотрудникиBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrent.Location = new System.Drawing.Point(3, 36);
            this.dgvCurrent.Name = "dgvCurrent";
            this.dgvCurrent.ReadOnly = true;
            this.dgvCurrent.RowHeadersWidth = 51;
            this.dgvCurrent.RowTemplate.Height = 24;
            this.dgvCurrent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCurrent.Size = new System.Drawing.Size(791, 353);
            this.dgvCurrent.TabIndex = 1;
            this.dgvCurrent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrent_CellClick);
            // 
            // idсотрудникDataGridViewTextBoxColumn
            // 
            this.idсотрудникDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудник";
            this.idсотрудникDataGridViewTextBoxColumn.HeaderText = "id_сотрудник";
            this.idсотрудникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idсотрудникDataGridViewTextBoxColumn.Name = "idсотрудникDataGridViewTextBoxColumn";
            this.idсотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            this.idсотрудникDataGridViewTextBoxColumn.Visible = false;
            this.idсотрудникDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 300;
            // 
            // датаприёмаDataGridViewTextBoxColumn
            // 
            this.датаприёмаDataGridViewTextBoxColumn.DataPropertyName = "Дата_приёма";
            this.датаприёмаDataGridViewTextBoxColumn.HeaderText = "Дата приёма на работу";
            this.датаприёмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаприёмаDataGridViewTextBoxColumn.Name = "датаприёмаDataGridViewTextBoxColumn";
            this.датаприёмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаприёмаDataGridViewTextBoxColumn.Width = 200;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn.Visible = false;
            this.адресDataGridViewTextBoxColumn.Width = 125;
            // 
            // действующиесотрудникиBindingSource
            // 
            this.действующиесотрудникиBindingSource.DataMember = "Действующие_сотрудники";
            this.действующиесотрудникиBindingSource.DataSource = this.cafeDataSet4;
            // 
            // cafeDataSet4
            // 
            this.cafeDataSet4.DataSetName = "CafeDataSet4";
            this.cafeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dgvFired);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Уволенные";
            // 
            // dgvFired
            // 
            this.dgvFired.AllowUserToAddRows = false;
            this.dgvFired.AllowUserToDeleteRows = false;
            this.dgvFired.AutoGenerateColumns = false;
            this.dgvFired.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFired.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFired.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.датаприёмаDataGridViewTextBoxColumn1,
            this.датаувольненияDataGridViewTextBoxColumn});
            this.dgvFired.DataSource = this.уволенныесотрудникиBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFired.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFired.Location = new System.Drawing.Point(3, 3);
            this.dgvFired.Name = "dgvFired";
            this.dgvFired.ReadOnly = true;
            this.dgvFired.RowHeadersWidth = 51;
            this.dgvFired.RowTemplate.Height = 24;
            this.dgvFired.Size = new System.Drawing.Size(791, 353);
            this.dgvFired.TabIndex = 2;
            this.dgvFired.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFired_CellClick);
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn1.Width = 300;
            // 
            // датаприёмаDataGridViewTextBoxColumn1
            // 
            this.датаприёмаDataGridViewTextBoxColumn1.DataPropertyName = "Дата_приёма";
            this.датаприёмаDataGridViewTextBoxColumn1.HeaderText = "Дата_приёма";
            this.датаприёмаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.датаприёмаDataGridViewTextBoxColumn1.Name = "датаприёмаDataGridViewTextBoxColumn1";
            this.датаприёмаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.датаприёмаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датаувольненияDataGridViewTextBoxColumn
            // 
            this.датаувольненияDataGridViewTextBoxColumn.DataPropertyName = "Дата_увольнения";
            this.датаувольненияDataGridViewTextBoxColumn.HeaderText = "Дата_увольнения";
            this.датаувольненияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаувольненияDataGridViewTextBoxColumn.Name = "датаувольненияDataGridViewTextBoxColumn";
            this.датаувольненияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаувольненияDataGridViewTextBoxColumn.Width = 125;
            // 
            // уволенныесотрудникиBindingSource
            // 
            this.уволенныесотрудникиBindingSource.DataMember = "Уволенные_сотрудники";
            this.уволенныесотрудникиBindingSource.DataSource = this.cafeDataSet5;
            // 
            // cafeDataSet5
            // 
            this.cafeDataSet5.DataSetName = "CafeDataSet5";
            this.cafeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // действующие_сотрудникиTableAdapter
            // 
            this.действующие_сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // уволенные_сотрудникиTableAdapter
            // 
            this.уволенные_сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbPatronymic);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbSurname);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnFired);
            this.panel2.Controls.Add(this.tbPhone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbPoints);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 167);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(390, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фамилия";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronymic.Location = new System.Drawing.Point(395, 120);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(161, 30);
            this.tbPatronymic.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(207, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 30);
            this.tbName.TabIndex = 14;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(15, 120);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(161, 30);
            this.tbSurname.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(610, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFired
            // 
            this.btnFired.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFired.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFired.Location = new System.Drawing.Point(610, 110);
            this.btnFired.Name = "btnFired";
            this.btnFired.Size = new System.Drawing.Size(157, 40);
            this.btnFired.TabIndex = 11;
            this.btnFired.Text = "Уволить";
            this.btnFired.UseVisualStyleBackColor = false;
            this.btnFired.Click += new System.EventHandler(this.btnFired_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(295, 48);
            this.tbPhone.Mask = "+7(000) 000-00-00";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(261, 32);
            this.tbPhone.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Телефон";
            // 
            // cbPoints
            // 
            this.cbPoints.DataSource = this.пунктобслуживанияBindingSource;
            this.cbPoints.DisplayMember = "Адрес";
            this.cbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPoints.FormattingEnabled = true;
            this.cbPoints.Location = new System.Drawing.Point(15, 46);
            this.cbPoints.Name = "cbPoints";
            this.cbPoints.Size = new System.Drawing.Size(261, 37);
            this.cbPoints.TabIndex = 8;
            this.cbPoints.ValueMember = "id_пункт";
            // 
            // пунктобслуживанияBindingSource
            // 
            this.пунктобслуживанияBindingSource.DataMember = "Пункт_обслуживания";
            this.пунктобслуживанияBindingSource.DataSource = this.cafeDataSet7;
            // 
            // cafeDataSet7
            // 
            this.cafeDataSet7.DataSetName = "CafeDataSet7";
            this.cafeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пункт ";
            // 
            // пункт_обслуживанияTableAdapter
            // 
            this.пункт_обслуживанияTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 36);
            this.panel3.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(3, 0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(350, 33);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление персоналом";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.действующиесотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уволенныесотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пунктобслуживанияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCurrent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFired;
        private CafeDataSet4 cafeDataSet4;
        private System.Windows.Forms.BindingSource действующиесотрудникиBindingSource;
        private CafeDataSet4TableAdapters.Действующие_сотрудникиTableAdapter действующие_сотрудникиTableAdapter;
        private CafeDataSet5 cafeDataSet5;
        private System.Windows.Forms.BindingSource уволенныесотрудникиBindingSource;
        private CafeDataSet5TableAdapters.Уволенные_сотрудникиTableAdapter уволенные_сотрудникиTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFired;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPoints;
        private System.Windows.Forms.Label label2;
        private CafeDataSet7 cafeDataSet7;
        private System.Windows.Forms.BindingSource пунктобслуживанияBindingSource;
        private CafeDataSet7TableAdapters.Пункт_обслуживанияTableAdapter пункт_обслуживанияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаприёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаприёмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаувольненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}