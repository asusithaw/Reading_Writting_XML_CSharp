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
            btnAdd = new Button();
            btnSave = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(126, 146);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = " SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 20;
            lstItems.Location = new Point(12, 241);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(208, 164);
            lstItems.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 155);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Search By ID";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 192);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(208, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(217, 24);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(544, 72);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 24);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save to XML";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(348, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 27);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(348, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 27);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(348, 109);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(348, 164);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(165, 27);
            txtAge.TabIndex = 10;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView.Location = new Point(278, 223);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(483, 182);
            dataGridView.TabIndex = 11;
            dataGridView.MouseClick += dataGridView_MouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "address";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "age";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 20);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 61);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 109);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 14;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 164);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 15;
            label5.Text = "Age";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 42);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(217, 24);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(544, 131);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(217, 24);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load from XML";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(217, 24);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 107);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(217, 24);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(lstItems);
            Controls.Add(btnSearch);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private ListBox lstItems;
        private Label label1;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnSave;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtAge;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEdit;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnExit;
    }
}