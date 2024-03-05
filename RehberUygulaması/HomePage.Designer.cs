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
            PersonListDgw = new DataGridView();
            PersonAddBtn = new Button();
            DepartmentAddBtn = new Button();
            JobTiitleAddBtn = new Button();
            TestBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).BeginInit();
            SuspendLayout();
            // 
            // PersonListDgw
            // 
            PersonListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonListDgw.Location = new Point(12, 12);
            PersonListDgw.Name = "PersonListDgw";
            PersonListDgw.RowHeadersWidth = 51;
            PersonListDgw.Size = new Size(1178, 885);
            PersonListDgw.TabIndex = 0;
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
            // TestBtn
            // 
            TestBtn.Location = new Point(1331, 335);
            TestBtn.Name = "TestBtn";
            TestBtn.Size = new Size(95, 46);
            TestBtn.TabIndex = 4;
            TestBtn.Text = "Test";
            TestBtn.UseVisualStyleBackColor = true;
            TestBtn.Click += TestBtn_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(TestBtn);
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
        }

        #endregion

        public DataGridView PersonListDgw;
        private Button PersonAddBtn;
        private Button DepartmentAddBtn;
        private Button JobTiitleAddBtn;
        private Button TestBtn;
    }
}
