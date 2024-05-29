namespace Cafe
{
    partial class formAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDishes = new System.Windows.Forms.Button();
            this.btnProm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDishes);
            this.groupBox1.Controls.Add(this.btnProm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(196, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPersonal.Location = new System.Drawing.Point(26, 255);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(344, 40);
            this.btnPersonal.TabIndex = 7;
            this.btnPersonal.Text = "Управление персоналом";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDishes
            // 
            this.btnDishes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDishes.Location = new System.Drawing.Point(26, 112);
            this.btnDishes.Name = "btnDishes";
            this.btnDishes.Size = new System.Drawing.Size(344, 40);
            this.btnDishes.TabIndex = 5;
            this.btnDishes.Text = "Управление товарами";
            this.btnDishes.UseVisualStyleBackColor = false;
            this.btnDishes.Click += new System.EventHandler(this.btnDishes_Click);
            // 
            // btnProm
            // 
            this.btnProm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProm.Location = new System.Drawing.Point(26, 178);
            this.btnProm.Name = "btnProm";
            this.btnProm.Size = new System.Drawing.Size(344, 40);
            this.btnProm.TabIndex = 1;
            this.btnProm.Text = "Управление акциями";
            this.btnProm.UseVisualStyleBackColor = false;
            this.btnProm.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(656, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Выйти";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDishes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPersonal;
    }
}