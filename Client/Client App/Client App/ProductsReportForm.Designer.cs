namespace Client_App
{
    partial class ProductsReportForm
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
            this.labelBestSellers = new System.Windows.Forms.Label();
            this.dataGridViewBS = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOutofStock = new System.Windows.Forms.Label();
            this.dataGridViewOxS = new System.Windows.Forms.DataGridView();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOxS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBestSellers
            // 
            this.labelBestSellers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBestSellers.AutoSize = true;
            this.labelBestSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBestSellers.Location = new System.Drawing.Point(11, 16);
            this.labelBestSellers.Name = "labelBestSellers";
            this.labelBestSellers.Size = new System.Drawing.Size(155, 29);
            this.labelBestSellers.TabIndex = 1;
            this.labelBestSellers.Text = "Best Sellers";
            // 
            // dataGridViewBS
            // 
            this.dataGridViewBS.AllowUserToAddRows = false;
            this.dataGridViewBS.AllowUserToDeleteRows = false;
            this.dataGridViewBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.pName,
            this.Price,
            this.SoldQuantity});
            this.dataGridViewBS.Location = new System.Drawing.Point(11, 57);
            this.dataGridViewBS.Name = "dataGridViewBS";
            this.dataGridViewBS.ReadOnly = true;
            this.dataGridViewBS.RowTemplate.Height = 25;
            this.dataGridViewBS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBS.Size = new System.Drawing.Size(604, 115);
            this.dataGridViewBS.TabIndex = 3;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index.HeaderText = "Rank";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // pName
            // 
            this.pName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pName.HeaderText = "Product Name";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // SoldQuantity
            // 
            this.SoldQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoldQuantity.HeaderText = "Sold Quantity";
            this.SoldQuantity.Name = "SoldQuantity";
            this.SoldQuantity.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBestSellers);
            this.panel1.Controls.Add(this.dataGridViewBS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 184);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelOutofStock);
            this.panel2.Controls.Add(this.dataGridViewOxS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 193);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(624, 184);
            this.panel2.TabIndex = 5;
            // 
            // labelOutofStock
            // 
            this.labelOutofStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutofStock.AutoSize = true;
            this.labelOutofStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutofStock.Location = new System.Drawing.Point(11, 15);
            this.labelOutofStock.Name = "labelOutofStock";
            this.labelOutofStock.Size = new System.Drawing.Size(265, 29);
            this.labelOutofStock.TabIndex = 1;
            this.labelOutofStock.Text = "Products Out of Stock";
            // 
            // dataGridViewOxS
            // 
            this.dataGridViewOxS.AllowUserToAddRows = false;
            this.dataGridViewOxS.AllowUserToDeleteRows = false;
            this.dataGridViewOxS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOxS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOxS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexCol,
            this.pNameCol,
            this.PriceCol});
            this.dataGridViewOxS.Location = new System.Drawing.Point(11, 60);
            this.dataGridViewOxS.Name = "dataGridViewOxS";
            this.dataGridViewOxS.ReadOnly = true;
            this.dataGridViewOxS.RowTemplate.Height = 25;
            this.dataGridViewOxS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOxS.Size = new System.Drawing.Size(604, 115);
            this.dataGridViewOxS.TabIndex = 3;
            // 
            // IndexCol
            // 
            this.IndexCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IndexCol.HeaderText = "Index";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            // 
            // pNameCol
            // 
            this.pNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pNameCol.HeaderText = "Product Name";
            this.pNameCol.Name = "pNameCol";
            this.pNameCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceCol.HeaderText = "Price";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 380);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ProductsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsReportForm";
            this.Text = "ProductsReportForm";
            this.Load += new System.EventHandler(this.ProductsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOxS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelBestSellers;
        private DataGridView dataGridViewBS;
        private Panel panel1;
        private Panel panel2;
        private Label labelOutofStock;
        private DataGridView dataGridViewOxS;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn IndexCol;
        private DataGridViewTextBoxColumn pNameCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn SoldQuantity;
    }
}