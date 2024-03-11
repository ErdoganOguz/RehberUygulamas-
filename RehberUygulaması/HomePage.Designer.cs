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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            FirstnameLbl = new Label();
            LastNamelbl = new Label();
            DepartmentLbl = new Label();
            TitleLbl = new Label();
            NumberLbl = new Label();
            EmailLbl = new Label();
            NumberUpdatetxt = new MaskedTextBox();
            PersonUpdateBtn = new Button();
            SearchTxt = new TextBox();
            SearchLbl = new Label();
            menuStrip1 = new MenuStrip();
            languagesToolStripMenuItem = new ToolStripMenuItem();
            tRToolStripMenuItem = new ToolStripMenuItem();
            eNToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PersonListDgw
            // 
            PersonListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonListDgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            PersonListDgw.BackgroundColor = Color.White;
            PersonListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonListDgw.Location = new Point(12, 58);
            PersonListDgw.Name = "PersonListDgw";
            PersonListDgw.ReadOnly = true;
            PersonListDgw.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            PersonListDgw.RowsDefaultCellStyle = dataGridViewCellStyle1;
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
            DepartmentAddBtn.Text = "Departmanlar";
            DepartmentAddBtn.UseVisualStyleBackColor = true;
            DepartmentAddBtn.Click += DepartmentAddBtn_Click;
            // 
            // JobTiitleAddBtn
            // 
            JobTiitleAddBtn.Location = new Point(1296, 770);
            JobTiitleAddBtn.Name = "JobTiitleAddBtn";
            JobTiitleAddBtn.Size = new Size(147, 29);
            JobTiitleAddBtn.TabIndex = 3;
            JobTiitleAddBtn.Text = "Ünvanlar";
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
            // FirstnameLbl
            // 
            FirstnameLbl.AutoSize = true;
            FirstnameLbl.Location = new Point(1296, 218);
            FirstnameLbl.Name = "FirstnameLbl";
            FirstnameLbl.Size = new Size(32, 20);
            FirstnameLbl.TabIndex = 11;
            FirstnameLbl.Text = "Adı";
            // 
            // LastNamelbl
            // 
            LastNamelbl.AutoSize = true;
            LastNamelbl.Location = new Point(1296, 272);
            LastNamelbl.Name = "LastNamelbl";
            LastNamelbl.Size = new Size(60, 20);
            LastNamelbl.TabIndex = 12;
            LastNamelbl.Text = "Soy Adı";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.Location = new Point(1296, 326);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(60, 20);
            DepartmentLbl.TabIndex = 13;
            DepartmentLbl.Text = "Bölümü";
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(1296, 380);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(54, 20);
            TitleLbl.TabIndex = 14;
            TitleLbl.Text = "Ünvanı";
            // 
            // NumberLbl
            // 
            NumberLbl.AutoSize = true;
            NumberLbl.Location = new Point(1296, 434);
            NumberLbl.Name = "NumberLbl";
            NumberLbl.Size = new Size(72, 20);
            NumberLbl.TabIndex = 15;
            NumberLbl.Text = "Numarası";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(1296, 488);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(52, 20);
            EmailLbl.TabIndex = 16;
            EmailLbl.Text = "E-Mail";
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
            // SearchTxt
            // 
            SearchTxt.Location = new Point(1418, 58);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(125, 27);
            SearchTxt.TabIndex = 20;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // SearchLbl
            // 
            SearchLbl.AutoSize = true;
            SearchLbl.Location = new Point(1364, 65);
            SearchLbl.Name = "SearchLbl";
            SearchLbl.Size = new Size(32, 20);
            SearchLbl.TabIndex = 21;
            SearchLbl.Text = "Ara";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { languagesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // languagesToolStripMenuItem
            // 
            languagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tRToolStripMenuItem, eNToolStripMenuItem });
            languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            languagesToolStripMenuItem.Size = new Size(94, 24);
            languagesToolStripMenuItem.Text = "Languages";
            // 
            // tRToolStripMenuItem
            // 
            tRToolStripMenuItem.Name = "tRToolStripMenuItem";
            tRToolStripMenuItem.Size = new Size(224, 26);
            tRToolStripMenuItem.Text = "TR";
            tRToolStripMenuItem.Click += tRToolStripMenuItem_Click_1;
            // 
            // eNToolStripMenuItem
            // 
            eNToolStripMenuItem.Name = "eNToolStripMenuItem";
            eNToolStripMenuItem.Size = new Size(224, 26);
            eNToolStripMenuItem.Text = "EN";
            eNToolStripMenuItem.Click += eNToolStripMenuItem_Click_1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(SearchLbl);
            Controls.Add(SearchTxt);
            Controls.Add(PersonUpdateBtn);
            Controls.Add(NumberUpdatetxt);
            Controls.Add(EmailLbl);
            Controls.Add(NumberLbl);
            Controls.Add(TitleLbl);
            Controls.Add(DepartmentLbl);
            Controls.Add(LastNamelbl);
            Controls.Add(FirstnameLbl);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label FirstnameLbl;
        private Label LastNamelbl;
        private Label DepartmentLbl;
        private Label TitleLbl;
        private Label NumberLbl;
        private Label EmailLbl;
        private MaskedTextBox NumberUpdatetxt;
        private Button PersonUpdateBtn;
        private TextBox SearchTxt;
        private Label SearchLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem languagesToolStripMenuItem;
        private ToolStripMenuItem tRToolStripMenuItem;
        private ToolStripMenuItem eNToolStripMenuItem;
    }
}
