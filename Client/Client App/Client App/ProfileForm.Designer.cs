namespace Client_App
{
    partial class ProfileForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.labelGenderAge = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMsg = new System.Windows.Forms.Label();
            this.dataGridViewOH = new System.Windows.Forms.DataGridView();
            this.labelOrdHisto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 151);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.UserPictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(922, 149);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPictureBox.Image = global::Client_App.Properties.Resources.user;
            this.UserPictureBox.Location = new System.Drawing.Point(3, 4);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(224, 141);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 1;
            this.UserPictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelUserBalance);
            this.panel4.Controls.Add(this.buttonDeposit);
            this.panel4.Controls.Add(this.labelGenderAge);
            this.panel4.Controls.Add(this.labelUserName);
            this.panel4.Controls.Add(this.labelBalance);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(233, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 141);
            this.panel4.TabIndex = 2;
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserBalance.Location = new System.Drawing.Point(151, 91);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(83, 29);
            this.labelUserBalance.TabIndex = 4;
            this.labelUserBalance.Text = "$$$$$";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDeposit.Location = new System.Drawing.Point(578, 84);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(102, 52);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // labelGenderAge
            // 
            this.labelGenderAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGenderAge.AutoSize = true;
            this.labelGenderAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGenderAge.Location = new System.Drawing.Point(23, 45);
            this.labelGenderAge.Name = "labelGenderAge";
            this.labelGenderAge.Size = new System.Drawing.Size(154, 29);
            this.labelGenderAge.TabIndex = 6;
            this.labelGenderAge.Text = "Gender/Age";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.Location = new System.Drawing.Point(23, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(144, 29);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "User Name";
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(23, 91);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(114, 29);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "Balance:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 639);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Controls.Add(this.dataGridViewOH);
            this.panel2.Controls.Add(this.labelOrdHisto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 441);
            this.panel2.TabIndex = 2;
            // 
            // labelMsg
            // 
            this.labelMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMsg.Location = new System.Drawing.Point(438, 41);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(141, 28);
            this.labelMsg.TabIndex = 3;
            this.labelMsg.Text = "No Orders yet!";
            // 
            // dataGridViewOH
            // 
            this.dataGridViewOH.AllowUserToAddRows = false;
            this.dataGridViewOH.AllowUserToDeleteRows = false;
            this.dataGridViewOH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.DateCreated,
            this.ProdName,
            this.ProdQuantity});
            this.dataGridViewOH.Location = new System.Drawing.Point(10, 89);
            this.dataGridViewOH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewOH.Name = "dataGridViewOH";
            this.dataGridViewOH.ReadOnly = true;
            this.dataGridViewOH.RowHeadersWidth = 51;
            this.dataGridViewOH.RowTemplate.Height = 25;
            this.dataGridViewOH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOH.Size = new System.Drawing.Size(904, 340);
            this.dataGridViewOH.TabIndex = 2;
            // 
            // labelOrdHisto
            // 
            this.labelOrdHisto.AutoSize = true;
            this.labelOrdHisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrdHisto.Location = new System.Drawing.Point(10, 31);
            this.labelOrdHisto.Name = "labelOrdHisto";
            this.labelOrdHisto.Size = new System.Drawing.Size(220, 36);
            this.labelOrdHisto.TabIndex = 1;
            this.labelOrdHisto.Text = "Orders History";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonLogout);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 23);
            this.panel3.TabIndex = 3;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogout.Location = new System.Drawing.Point(821, 0);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(103, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index.HeaderText = "Order Number";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreated.HeaderText = "Date";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdQuantity.HeaderText = "Quantity";
            this.ProdQuantity.MinimumWidth = 6;
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.ReadOnly = true;
            this.ProdQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(946, 675);
            this.Name = "ProfileForm";
            this.Text = "Profile Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.ProfileForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox UserPictureBox;
        private Panel panel2;
        private Button buttonDeposit;
        private Label labelUserBalance;
        private Label labelUserName;
        private Label labelBalance;
        private DataGridView dataGridViewOH;
        private Label labelOrdHisto;
        private Panel panel3;
        private Button buttonLogout;
        private Button buttonBack;
        private Label labelMsg;
        private Label labelGenderAge;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn DateCreated;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProdQuantity;
    }
}