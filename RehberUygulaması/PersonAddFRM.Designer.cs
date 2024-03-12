namespace RehberUygulaması
{
    partial class PersonAddFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonAddFRM));
            EMailTxt = new TextBox();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            FirstNameLbl = new Label();
            LastNameLbl = new Label();
            DepartmentLbl = new Label();
            TitleLbl = new Label();
            NumberLbl = new Label();
            EmailLbl = new Label();
            BackBtn = new Button();
            AddBtn = new Button();
            JobTitleCombo = new ComboBox();
            DepartmentCombo = new ComboBox();
            PhoneNumberTxt = new MaskedTextBox();
            SuspendLayout();
            // 
            // EMailTxt
            // 
            resources.ApplyResources(EMailTxt, "EMailTxt");
            EMailTxt.Name = "EMailTxt";
            // 
            // FirstNameTxt
            // 
            resources.ApplyResources(FirstNameTxt, "FirstNameTxt");
            FirstNameTxt.Name = "FirstNameTxt";
            // 
            // LastNameTxt
            // 
            resources.ApplyResources(LastNameTxt, "LastNameTxt");
            LastNameTxt.Name = "LastNameTxt";
            // 
            // FirstNameLbl
            // 
            resources.ApplyResources(FirstNameLbl, "FirstNameLbl");
            FirstNameLbl.Name = "FirstNameLbl";
            // 
            // LastNameLbl
            // 
            resources.ApplyResources(LastNameLbl, "LastNameLbl");
            LastNameLbl.Name = "LastNameLbl";
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
            // BackBtn
            // 
            resources.ApplyResources(BackBtn, "BackBtn");
            BackBtn.Name = "BackBtn";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddBtn
            // 
            resources.ApplyResources(AddBtn, "AddBtn");
            AddBtn.Name = "AddBtn";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // JobTitleCombo
            // 
            resources.ApplyResources(JobTitleCombo, "JobTitleCombo");
            JobTitleCombo.FormattingEnabled = true;
            JobTitleCombo.Name = "JobTitleCombo";
            // 
            // DepartmentCombo
            // 
            resources.ApplyResources(DepartmentCombo, "DepartmentCombo");
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Name = "DepartmentCombo";
            // 
            // PhoneNumberTxt
            // 
            resources.ApplyResources(PhoneNumberTxt, "PhoneNumberTxt");
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            // 
            // PersonAddFRM
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(PhoneNumberTxt);
            Controls.Add(DepartmentCombo);
            Controls.Add(JobTitleCombo);
            Controls.Add(AddBtn);
            Controls.Add(BackBtn);
            Controls.Add(EmailLbl);
            Controls.Add(NumberLbl);
            Controls.Add(TitleLbl);
            Controls.Add(DepartmentLbl);
            Controls.Add(LastNameLbl);
            Controls.Add(FirstNameLbl);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(EMailTxt);
            Name = "PersonAddFRM";
            Load += PersonAddFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox EMailTxt;
        public TextBox FirstNameTxt;
        public TextBox LastNameTxt;
        private Button BackBtn;
        private Button AddBtn;
        private ComboBox JobTitleCombo;
        private ComboBox DepartmentCombo;
        private MaskedTextBox PhoneNumberTxt;
        public Label FirstNameLbl;
        public Label LastNameLbl;
        public Label DepartmentLbl;
        public Label TitleLbl;
        public Label NumberLbl;
        public Label EmailLbl;
    }
}