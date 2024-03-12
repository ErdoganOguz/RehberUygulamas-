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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobTitleAddFRM));
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
            resources.ApplyResources(BackBtn, "BackBtn");
            BackBtn.Name = "BackBtn";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // JobTitleAddBtn
            // 
            resources.ApplyResources(JobTitleAddBtn, "JobTitleAddBtn");
            JobTitleAddBtn.Name = "JobTitleAddBtn";
            JobTitleAddBtn.UseVisualStyleBackColor = true;
            JobTitleAddBtn.Click += JobTitleAddBtn_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // JobTitleAddTxt
            // 
            resources.ApplyResources(JobTitleAddTxt, "JobTitleAddTxt");
            JobTitleAddTxt.Name = "JobTitleAddTxt";
            // 
            // JobTitleListDgw
            // 
            resources.ApplyResources(JobTitleListDgw, "JobTitleListDgw");
            JobTitleListDgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            JobTitleListDgw.BackgroundColor = Color.White;
            JobTitleListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobTitleListDgw.Name = "JobTitleListDgw";
            JobTitleListDgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(DeleteBtn, "DeleteBtn");
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // JobTitleAddFRM
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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