namespace Client_App
{
    partial class SearchForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchedLabel = new System.Windows.Forms.Label();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.sortcombobox = new System.Windows.Forms.ComboBox();
            this.sortlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(74, 204);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 22);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(25, 73);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(49, 19);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(25, 116);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxtBox.Location = new System.Drawing.Point(100, 73);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(133, 26);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(10, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(59, 22);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.price,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(265, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(523, 385);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // searchedLabel
            // 
            this.searchedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchedLabel.AutoSize = true;
            this.searchedLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchedLabel.Location = new System.Drawing.Point(496, 43);
            this.searchedLabel.Name = "searchedLabel";
            this.searchedLabel.Size = new System.Drawing.Size(43, 19);
            this.searchedLabel.TabIndex = 7;
            this.searchedLabel.Text = "Items";
            // 
            // categorycombobox
            // 
            this.categorycombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categorycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Location = new System.Drawing.Point(100, 115);
            this.categorycombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(133, 27);
            this.categorycombobox.TabIndex = 8;
            this.categorycombobox.SelectedIndexChanged += new System.EventHandler(this.categorycombobox_SelectedIndexChanged);
            // 
            // sortcombobox
            // 
            this.sortcombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortcombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortcombobox.FormattingEnabled = true;
            this.sortcombobox.Items.AddRange(new object[] {
            "Price",
            "Name"});
            this.sortcombobox.Location = new System.Drawing.Point(100, 157);
            this.sortcombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortcombobox.Name = "sortcombobox";
            this.sortcombobox.Size = new System.Drawing.Size(133, 27);
            this.sortcombobox.TabIndex = 9;
            this.sortcombobox.SelectedIndexChanged += new System.EventHandler(this.sortcombobox_SelectedIndexChanged);
            // 
            // sortlabel
            // 
            this.sortlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortlabel.AutoSize = true;
            this.sortlabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortlabel.Location = new System.Drawing.Point(25, 160);
            this.sortlabel.Name = "sortlabel";
            this.sortlabel.Size = new System.Drawing.Size(53, 19);
            this.sortlabel.TabIndex = 10;
            this.sortlabel.Text = "Sort by";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.sortlabel);
            this.Controls.Add(this.sortcombobox);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.searchedLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.btn_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(830, 520);
            this.Name = "SearchForm";
            this.Text = "Search Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private Button btn_search;
		private Label searchLabel;
		private Label categoryLabel;
		private TextBox searchTxtBox;
		private Button btn_back;
		private DataGridView dataGridView1;
		private Label searchedLabel;
		private ComboBox categorycombobox;
		private ComboBox sortcombobox;
		private Label sortlabel;
		private DataGridViewTextBoxColumn productName;
		private DataGridViewTextBoxColumn price;
		private DataGridViewTextBoxColumn status;
	}
}