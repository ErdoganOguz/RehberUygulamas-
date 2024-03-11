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
            EMailTxt.Location = new Point(179, 262);
            EMailTxt.Name = "EMailTxt";
            EMailTxt.Size = new Size(169, 27);
            EMailTxt.TabIndex = 6;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(179, 56);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(169, 27);
            FirstNameTxt.TabIndex = 1;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(179, 96);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(169, 27);
            LastNameTxt.TabIndex = 2;
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Location = new Point(34, 63);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(32, 20);
            FirstNameLbl.TabIndex = 6;
            FirstNameLbl.Text = "Adı";
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Location = new Point(34, 99);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(60, 20);
            LastNameLbl.TabIndex = 7;
            LastNameLbl.Text = "Soy Adı";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.Location = new Point(34, 138);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(60, 20);
            DepartmentLbl.TabIndex = 8;
            DepartmentLbl.Text = "Bölümü";
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(34, 180);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(54, 20);
            TitleLbl.TabIndex = 9;
            TitleLbl.Text = "Ünvanı";
            // 
            // NumberLbl
            // 
            NumberLbl.AutoSize = true;
            NumberLbl.Location = new Point(34, 226);
            NumberLbl.Name = "NumberLbl";
            NumberLbl.Size = new Size(72, 20);
            NumberLbl.TabIndex = 10;
            NumberLbl.Text = "Numarası";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(34, 269);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(52, 20);
            EmailLbl.TabIndex = 11;
            EmailLbl.Text = "E-Mail";
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(491, 93);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Geri";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(491, 218);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 28);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Ekle";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // JobTitleCombo
            // 
            JobTitleCombo.FormattingEnabled = true;
            JobTitleCombo.Location = new Point(179, 177);
            JobTitleCombo.Name = "JobTitleCombo";
            JobTitleCombo.Size = new Size(169, 28);
            JobTitleCombo.TabIndex = 16;
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Location = new Point(179, 135);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(169, 28);
            DepartmentCombo.TabIndex = 17;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Location = new Point(179, 223);
            PhoneNumberTxt.Mask = "(500) 000-0000";
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.Size = new Size(169, 27);
            PhoneNumberTxt.TabIndex = 18;
            // 
            // PersonAddFRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 721);
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