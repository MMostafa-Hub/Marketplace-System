namespace Client_App
{
    partial class OrdersReportForm
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
            this.dataGridViewO7 = new System.Windows.Forms.DataGridView();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOrdersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewO7
            // 
            this.dataGridViewO7.AllowUserToAddRows = false;
            this.dataGridViewO7.AllowUserToDeleteRows = false;
            this.dataGridViewO7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewO7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewO7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol,
            this.NOrdersCol,
            this.ProfitCol});
            this.dataGridViewO7.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewO7.Name = "dataGridViewO7";
            this.dataGridViewO7.ReadOnly = true;
            this.dataGridViewO7.RowTemplate.Height = 25;
            this.dataGridViewO7.Size = new System.Drawing.Size(606, 307);
            this.dataGridViewO7.TabIndex = 3;
            // 
            // DateCol
            // 
            this.DateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCol.HeaderText = "Day";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            // 
            // NOrdersCol
            // 
            this.NOrdersCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOrdersCol.HeaderText = "Orders Count";
            this.NOrdersCol.Name = "NOrdersCol";
            this.NOrdersCol.ReadOnly = true;
            // 
            // ProfitCol
            // 
            this.ProfitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProfitCol.HeaderText = "Profit";
            this.ProfitCol.Name = "ProfitCol";
            this.ProfitCol.ReadOnly = true;
            // 
            // OrdersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.dataGridViewO7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersReportForm";
            this.Text = "UsersActivityForm";
            this.Load += new System.EventHandler(this.OrdersReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewO7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridViewO7;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn NOrdersCol;
        private DataGridViewTextBoxColumn ProfitCol;
    }
}