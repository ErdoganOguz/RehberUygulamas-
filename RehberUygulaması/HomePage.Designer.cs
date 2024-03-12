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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
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
            resources.ApplyResources(PersonListDgw, "PersonListDgw");
            PersonListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonListDgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            PersonListDgw.BackgroundColor = Color.White;
            PersonListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonListDgw.Name = "PersonListDgw";
            PersonListDgw.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            PersonListDgw.RowsDefaultCellStyle = dataGridViewCellStyle1;
            PersonListDgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonListDgw.DoubleClick += PersonListDgw_DoubleClick;
            // 
            // PersonAddBtn
            // 
            resources.ApplyResources(PersonAddBtn, "PersonAddBtn");
            PersonAddBtn.Name = "PersonAddBtn";
            PersonAddBtn.UseVisualStyleBackColor = true;
            PersonAddBtn.Click += PersonAddBtn_Click;
            // 
            // DepartmentAddBtn
            // 
            resources.ApplyResources(DepartmentAddBtn, "DepartmentAddBtn");
            DepartmentAddBtn.Name = "DepartmentAddBtn";
            DepartmentAddBtn.UseVisualStyleBackColor = true;
            DepartmentAddBtn.Click += DepartmentAddBtn_Click;
            // 
            // JobTiitleAddBtn
            // 
            resources.ApplyResources(JobTiitleAddBtn, "JobTiitleAddBtn");
            JobTiitleAddBtn.Name = "JobTiitleAddBtn";
            JobTiitleAddBtn.UseVisualStyleBackColor = true;
            JobTiitleAddBtn.Click += JobTiitleAddBtn_Click;
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(DeleteBtn, "DeleteBtn");
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // FirstNameUpdateTxt
            // 
            resources.ApplyResources(FirstNameUpdateTxt, "FirstNameUpdateTxt");
            FirstNameUpdateTxt.Name = "FirstNameUpdateTxt";
            // 
            // LastNameUpdateTxt
            // 
            resources.ApplyResources(LastNameUpdateTxt, "LastNameUpdateTxt");
            LastNameUpdateTxt.Name = "LastNameUpdateTxt";
            // 
            // DepartmentUpdateCombo
            // 
            resources.ApplyResources(DepartmentUpdateCombo, "DepartmentUpdateCombo");
            DepartmentUpdateCombo.FormattingEnabled = true;
            DepartmentUpdateCombo.Name = "DepartmentUpdateCombo";
            // 
            // TitleUpdateCombo
            // 
            resources.ApplyResources(TitleUpdateCombo, "TitleUpdateCombo");
            TitleUpdateCombo.FormattingEnabled = true;
            TitleUpdateCombo.Name = "TitleUpdateCombo";
            // 
            // MailUpdadetxt
            // 
            resources.ApplyResources(MailUpdadetxt, "MailUpdadetxt");
            MailUpdadetxt.Name = "MailUpdadetxt";
            // 
            // FirstnameLbl
            // 
            resources.ApplyResources(FirstnameLbl, "FirstnameLbl");
            FirstnameLbl.Name = "FirstnameLbl";
            // 
            // LastNamelbl
            // 
            resources.ApplyResources(LastNamelbl, "LastNamelbl");
            LastNamelbl.Name = "LastNamelbl";
            // 
            // DepartmentLbl
            // 
            resources.ApplyResources(DepartmentLbl, "DepartmentLbl");
            DepartmentLbl.Name = "DepartmentLbl";
            // 
            // TitleLbl
            // 
            resources.ApplyResources(TitleLbl, "TitleLbl");
            TitleLbl.Name = "TitleLbl";
            // 
            // NumberLbl
            // 
            resources.ApplyResources(NumberLbl, "NumberLbl");
            NumberLbl.Name = "NumberLbl";
            // 
            // EmailLbl
            // 
            resources.ApplyResources(EmailLbl, "EmailLbl");
            EmailLbl.Name = "EmailLbl";
            // 
            // NumberUpdatetxt
            // 
            resources.ApplyResources(NumberUpdatetxt, "NumberUpdatetxt");
            NumberUpdatetxt.Name = "NumberUpdatetxt";
            // 
            // PersonUpdateBtn
            // 
            resources.ApplyResources(PersonUpdateBtn, "PersonUpdateBtn");
            PersonUpdateBtn.Name = "PersonUpdateBtn";
            PersonUpdateBtn.UseVisualStyleBackColor = true;
            PersonUpdateBtn.Click += PersonUpdateBtn_Click;
            // 
            // SearchTxt
            // 
            resources.ApplyResources(SearchTxt, "SearchTxt");
            SearchTxt.Name = "SearchTxt";
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // SearchLbl
            // 
            resources.ApplyResources(SearchLbl, "SearchLbl");
            SearchLbl.Name = "SearchLbl";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { languagesToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // languagesToolStripMenuItem
            // 
            resources.ApplyResources(languagesToolStripMenuItem, "languagesToolStripMenuItem");
            languagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tRToolStripMenuItem, eNToolStripMenuItem });
            languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            // 
            // tRToolStripMenuItem
            // 
            resources.ApplyResources(tRToolStripMenuItem, "tRToolStripMenuItem");
            tRToolStripMenuItem.Name = "tRToolStripMenuItem";
            tRToolStripMenuItem.Click += tRToolStripMenuItem_Click_1;
            // 
            // eNToolStripMenuItem
            // 
            resources.ApplyResources(eNToolStripMenuItem, "eNToolStripMenuItem");
            eNToolStripMenuItem.Name = "eNToolStripMenuItem";
            eNToolStripMenuItem.Click += eNToolStripMenuItem_Click_1;
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
