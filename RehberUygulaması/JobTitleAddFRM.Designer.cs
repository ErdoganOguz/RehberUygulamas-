namespace RehberUygulaması
{
    partial class JobTitleAddFRM
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
            BackBtn = new Button();
            JobTitleAddBtn = new Button();
            label1 = new Label();
            JobTitleAddTxt = new TextBox();
            JobTitleListDgw = new DataGridView();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)JobTitleListDgw).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(856, 248);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 9;
            BackBtn.Text = "Geri";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // JobTitleAddBtn
            // 
            JobTitleAddBtn.Location = new Point(856, 293);
            JobTitleAddBtn.Name = "JobTitleAddBtn";
            JobTitleAddBtn.Size = new Size(94, 29);
            JobTitleAddBtn.TabIndex = 8;
            JobTitleAddBtn.Text = "Ekle";
            JobTitleAddBtn.UseVisualStyleBackColor = true;
            JobTitleAddBtn.Click += JobTitleAddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Ünvan Adı";
            // 
            // JobTitleAddTxt
            // 
            JobTitleAddTxt.Location = new Point(771, 12);
            JobTitleAddTxt.Name = "JobTitleAddTxt";
            JobTitleAddTxt.Size = new Size(179, 27);
            JobTitleAddTxt.TabIndex = 6;
            // 
            // JobTitleListDgw
            // 
            JobTitleListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            JobTitleListDgw.BackgroundColor = Color.White;
            JobTitleListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobTitleListDgw.Location = new Point(12, 12);
            JobTitleListDgw.Name = "JobTitleListDgw";
            JobTitleListDgw.RowHeadersWidth = 51;
            JobTitleListDgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            JobTitleListDgw.Size = new Size(636, 310);
            JobTitleListDgw.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(856, 328);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Sil";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // JobTitleAddFRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 750);
            ControlBox = false;
            Controls.Add(DeleteBtn);
            Controls.Add(BackBtn);
            Controls.Add(JobTitleAddBtn);
            Controls.Add(label1);
            Controls.Add(JobTitleAddTxt);
            Controls.Add(JobTitleListDgw);
            Name = "JobTitleAddFRM";
            Load += JobTitleAddFRM_Load;
            ((System.ComponentModel.ISupportInitialize)JobTitleListDgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button JobTitleAddBtn;
        private Label label1;
        private TextBox JobTitleAddTxt;
        private DataGridView JobTitleListDgw;
        private Button DeleteBtn;
    }
}