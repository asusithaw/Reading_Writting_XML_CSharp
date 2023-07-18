namespace XML__Reading_Writting
{
    partial class Form1
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
            btnSearch = new Button();
            lstItems = new ListBox();
            label1 = new Label();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(542, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 20;
            lstItems.Location = new Point(108, 120);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(388, 164);
            lstItems.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 21);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Search By ID";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(108, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(395, 27);
            txtSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(lstItems);
            Controls.Add(btnSearch);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private ListBox lstItems;
        private Label label1;
        private TextBox txtSearch;
    }
}