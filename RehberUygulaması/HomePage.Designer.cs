namespace RehberUygulaması
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PersonListDgw = new DataGridView();
            PersonAddBtn = new Button();
            DepartmentAddBtn = new Button();
            JobTiitleAddBtn = new Button();
            DeleteBtn = new Button();
            FirstNameUpdateTxt = new TextBox();
            LastNameUpdateTxt = new TextBox();
            DepartmentUpdateCombo = new ComboBox();
            TitleUpdateCombo = new ComboBox();
            MailUpdadetxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NumberUpdatetxt = new MaskedTextBox();
            PersonUpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).BeginInit();
            SuspendLayout();
            // 
            // PersonListDgw
            // 
            PersonListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonListDgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            PersonListDgw.BackgroundColor = Color.White;
            PersonListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonListDgw.Location = new Point(12, 12);
            PersonListDgw.Name = "PersonListDgw";
            PersonListDgw.ReadOnly = true;
            PersonListDgw.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            PersonListDgw.RowsDefaultCellStyle = dataGridViewCellStyle2;
            PersonListDgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonListDgw.Size = new Size(1178, 885);
            PersonListDgw.TabIndex = 0;
            PersonListDgw.DoubleClick += PersonListDgw_DoubleClick;
            // 
            // PersonAddBtn
            // 
            PersonAddBtn.Location = new Point(1296, 868);
            PersonAddBtn.Name = "PersonAddBtn";
            PersonAddBtn.Size = new Size(147, 29);
            PersonAddBtn.TabIndex = 1;
            PersonAddBtn.Text = "Kişi Ekle";
            PersonAddBtn.UseVisualStyleBackColor = true;
            PersonAddBtn.Click += PersonAddBtn_Click;
            // 
            // DepartmentAddBtn
            // 
            DepartmentAddBtn.Location = new Point(1296, 816);
            DepartmentAddBtn.Name = "DepartmentAddBtn";
            DepartmentAddBtn.Size = new Size(147, 29);
            DepartmentAddBtn.TabIndex = 2;
            DepartmentAddBtn.Text = "Departman Ekle";
            DepartmentAddBtn.UseVisualStyleBackColor = true;
            DepartmentAddBtn.Click += DepartmentAddBtn_Click;
            // 
            // JobTiitleAddBtn
            // 
            JobTiitleAddBtn.Location = new Point(1296, 770);
            JobTiitleAddBtn.Name = "JobTiitleAddBtn";
            JobTiitleAddBtn.Size = new Size(147, 29);
            JobTiitleAddBtn.TabIndex = 3;
            JobTiitleAddBtn.Text = "Ünvan Ekle";
            JobTiitleAddBtn.UseVisualStyleBackColor = true;
            JobTiitleAddBtn.Click += JobTiitleAddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(1296, 685);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(147, 31);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // FirstNameUpdateTxt
            // 
            FirstNameUpdateTxt.Location = new Point(1462, 215);
            FirstNameUpdateTxt.Name = "FirstNameUpdateTxt";
            FirstNameUpdateTxt.Size = new Size(147, 27);
            FirstNameUpdateTxt.TabIndex = 5;
            // 
            // LastNameUpdateTxt
            // 
            LastNameUpdateTxt.Location = new Point(1462, 269);
            LastNameUpdateTxt.Name = "LastNameUpdateTxt";
            LastNameUpdateTxt.Size = new Size(147, 27);
            LastNameUpdateTxt.TabIndex = 6;
            // 
            // DepartmentUpdateCombo
            // 
            DepartmentUpdateCombo.FormattingEnabled = true;
            DepartmentUpdateCombo.Location = new Point(1462, 318);
            DepartmentUpdateCombo.Name = "DepartmentUpdateCombo";
            DepartmentUpdateCombo.Size = new Size(147, 28);
            DepartmentUpdateCombo.TabIndex = 7;
            // 
            // TitleUpdateCombo
            // 
            TitleUpdateCombo.FormattingEnabled = true;
            TitleUpdateCombo.Location = new Point(1462, 372);
            TitleUpdateCombo.Name = "TitleUpdateCombo";
            TitleUpdateCombo.Size = new Size(147, 28);
            TitleUpdateCombo.TabIndex = 8;
            // 
            // MailUpdadetxt
            // 
            MailUpdadetxt.Location = new Point(1462, 481);
            MailUpdadetxt.Name = "MailUpdadetxt";
            MailUpdadetxt.Size = new Size(147, 27);
            MailUpdadetxt.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1296, 218);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 11;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1296, 272);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 12;
            label2.Text = "Soy Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1296, 326);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 13;
            label3.Text = "Bölümü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1296, 380);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 14;
            label4.Text = "Ünvanı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1296, 434);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1296, 488);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 16;
            label6.Text = "E-Mail";
            // 
            // NumberUpdatetxt
            // 
            NumberUpdatetxt.Location = new Point(1462, 431);
            NumberUpdatetxt.Mask = "(500) 000-0000";
            NumberUpdatetxt.Name = "NumberUpdatetxt";
            NumberUpdatetxt.Size = new Size(147, 27);
            NumberUpdatetxt.TabIndex = 18;
            // 
            // PersonUpdateBtn
            // 
            PersonUpdateBtn.Location = new Point(1515, 548);
            PersonUpdateBtn.Name = "PersonUpdateBtn";
            PersonUpdateBtn.Size = new Size(94, 29);
            PersonUpdateBtn.TabIndex = 19;
            PersonUpdateBtn.Text = "Güncelle";
            PersonUpdateBtn.UseVisualStyleBackColor = true;
            PersonUpdateBtn.Click += PersonUpdateBtn_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(PersonUpdateBtn);
            Controls.Add(NumberUpdatetxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MailUpdadetxt);
            Controls.Add(TitleUpdateCombo);
            Controls.Add(DepartmentUpdateCombo);
            Controls.Add(LastNameUpdateTxt);
            Controls.Add(FirstNameUpdateTxt);
            Controls.Add(DeleteBtn);
            Controls.Add(JobTiitleAddBtn);
            Controls.Add(DepartmentAddBtn);
            Controls.Add(PersonAddBtn);
            Controls.Add(PersonListDgw);
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView PersonListDgw;
        private Button PersonAddBtn;
        private Button DepartmentAddBtn;
        private Button JobTiitleAddBtn;
        private Button DeleteBtn;
        private TextBox FirstNameUpdateTxt;
        private TextBox LastNameUpdateTxt;
        private ComboBox DepartmentUpdateCombo;
        private ComboBox TitleUpdateCombo;
        private TextBox MailUpdadetxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox NumberUpdatetxt;
        private Button PersonUpdateBtn;
    }
}
