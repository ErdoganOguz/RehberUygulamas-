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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentAddFRM));
            DepaermentListDgw = new DataGridView();
            DepartmentAddTxt = new TextBox();
            label1 = new Label();
            DepartmentAddBtn = new Button();
            BackBtn = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DepaermentListDgw).BeginInit();
            SuspendLayout();
            // 
            // DepaermentListDgw
            // 
            resources.ApplyResources(DepaermentListDgw, "DepaermentListDgw");
            DepaermentListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DepaermentListDgw.BackgroundColor = Color.White;
            DepaermentListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepaermentListDgw.Name = "DepaermentListDgw";
            DepaermentListDgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // DepartmentAddTxt
            // 
            resources.ApplyResources(DepartmentAddTxt, "DepartmentAddTxt");
            DepartmentAddTxt.Name = "DepartmentAddTxt";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // DepartmentAddBtn
            // 
            resources.ApplyResources(DepartmentAddBtn, "DepartmentAddBtn");
            DepartmentAddBtn.Name = "DepartmentAddBtn";
            DepartmentAddBtn.UseVisualStyleBackColor = true;
            DepartmentAddBtn.Click += DepartmentAddBtn_Click;
            // 
            // BackBtn
            // 
            resources.ApplyResources(BackBtn, "BackBtn");
            BackBtn.Name = "BackBtn";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // BtnDelete
            // 
            resources.ApplyResources(BtnDelete, "BtnDelete");
            BtnDelete.Name = "BtnDelete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // DepartmentAddFRM
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(BtnDelete);
            Controls.Add(BackBtn);
            Controls.Add(DepartmentAddBtn);
            Controls.Add(label1);
            Controls.Add(DepartmentAddTxt);
            Controls.Add(DepaermentListDgw);
            Name = "DepartmentAddFRM";
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
        private Button BtnDelete;
    }
}