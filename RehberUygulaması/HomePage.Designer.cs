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
        private void InitializeComponent()
        {
            PersonListDgw = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).BeginInit();
            SuspendLayout();
            // 
            // PersonListDgw
            // 
            PersonListDgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonListDgw.Location = new Point(12, 12);
            PersonListDgw.Name = "PersonListDgw";
            PersonListDgw.RowHeadersWidth = 51;
            PersonListDgw.Size = new Size(1126, 873);
            PersonListDgw.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(PersonListDgw);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)PersonListDgw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PersonListDgw;
    }
}
