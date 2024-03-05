namespace RehberUygulaması
{
    partial class DepartmentAddFRM
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
            DepaermentListDgw = new DataGridView();
            DepartmentAddTxt = new TextBox();
            label1 = new Label();
            DepartmentAddBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DepaermentListDgw).BeginInit();
            SuspendLayout();
            // 
            // DepaermentListDgw
            // 
            DepaermentListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepaermentListDgw.Location = new Point(12, 12);
            DepaermentListDgw.Name = "DepaermentListDgw";
            DepaermentListDgw.RowHeadersWidth = 51;
            DepaermentListDgw.Size = new Size(636, 310);
            DepaermentListDgw.TabIndex = 0;
            // 
            // DepartmentAddTxt
            // 
            DepartmentAddTxt.Location = new Point(771, 12);
            DepartmentAddTxt.Name = "DepartmentAddTxt";
            DepartmentAddTxt.Size = new Size(179, 27);
            DepartmentAddTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Departman Adı";
            // 
            // DepartmentAddBtn
            // 
            DepartmentAddBtn.Location = new Point(856, 293);
            DepartmentAddBtn.Name = "DepartmentAddBtn";
            DepartmentAddBtn.Size = new Size(94, 29);
            DepartmentAddBtn.TabIndex = 3;
            DepartmentAddBtn.Text = "Ekle";
            DepartmentAddBtn.UseVisualStyleBackColor = true;
            DepartmentAddBtn.Click += DepartmentAddBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(856, 248);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Geri";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // DepartmentAddFRM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 660);
            Controls.Add(BackBtn);
            Controls.Add(DepartmentAddBtn);
            Controls.Add(label1);
            Controls.Add(DepartmentAddTxt);
            Controls.Add(DepaermentListDgw);
            Name = "DepartmentAddFRM";
            Text = "DepartmentAddFRM";
            Load += DepartmentAddFRM_Load;
            ((System.ComponentModel.ISupportInitialize)DepaermentListDgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DepaermentListDgw;
        private TextBox DepartmentAddTxt;
        private Label label1;
        private Button DepartmentAddBtn;
        private Button BackBtn;
    }
}