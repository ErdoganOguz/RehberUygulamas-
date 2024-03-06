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
            DepartmentTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BackBtn = new Button();
            AddBtn = new Button();
            PhoneNumberTxt = new MaskedTextBox();
            JobTitleCombo = new ComboBox();
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
            // DepartmentTxt
            // 
            DepartmentTxt.Location = new Point(179, 135);
            DepartmentTxt.Name = "DepartmentTxt";
            DepartmentTxt.Size = new Size(169, 27);
            DepartmentTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 63);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 6;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "Soy Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 138);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "Bölümü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 180);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Ünvanı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 226);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 269);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 11;
            label6.Text = "E-Mail";
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
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Location = new Point(179, 223);
            PhoneNumberTxt.Mask = "(500) 000-0000";
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.Size = new Size(169, 27);
            PhoneNumberTxt.TabIndex = 5;
            // 
            // JobTitleCombo
            // 
            JobTitleCombo.FormattingEnabled = true;
            JobTitleCombo.Location = new Point(179, 177);
            JobTitleCombo.Name = "JobTitleCombo";
            JobTitleCombo.Size = new Size(169, 28);
            JobTitleCombo.TabIndex = 16;
            // 
            // PersonAddFRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 641);
            Controls.Add(JobTitleCombo);
            Controls.Add(PhoneNumberTxt);
            Controls.Add(AddBtn);
            Controls.Add(BackBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepartmentTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(EMailTxt);
            Name = "PersonAddFRM";
            Text = "PersonAddFRM";
            Load += PersonAddFRM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox EMailTxt;
        public TextBox FirstNameTxt;
        public TextBox LastNameTxt;
        public TextBox DepartmentTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BackBtn;
        private Button AddBtn;
        private MaskedTextBox PhoneNumberTxt;
        private ComboBox JobTitleCombo;
    }
}