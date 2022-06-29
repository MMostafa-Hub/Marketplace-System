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
            this.labelGenderAge = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMsg = new System.Windows.Forms.Label();
            this.dataGridViewOH = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOrdHisto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelGenderAge);
            this.panel1.Controls.Add(this.buttonDeposit);
            this.panel1.Controls.Add(this.labelUserBalance);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.UserPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 152);
            this.panel1.TabIndex = 1;
            // 
            // labelGenderAge
            // 
            this.labelGenderAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGenderAge.AutoSize = true;
            this.labelGenderAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGenderAge.Location = new System.Drawing.Point(438, 58);
            this.labelGenderAge.Name = "labelGenderAge";
            this.labelGenderAge.Size = new System.Drawing.Size(154, 29);
            this.labelGenderAge.TabIndex = 6;
            this.labelGenderAge.Text = "Gender/Age";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeposit.Location = new System.Drawing.Point(659, 106);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(77, 32);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserBalance.Location = new System.Drawing.Point(548, 105);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(83, 29);
            this.labelUserBalance.TabIndex = 4;
            this.labelUserBalance.Text = "$$$$$";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.Location = new System.Drawing.Point(438, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(144, 29);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "User Name";
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(438, 105);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(114, 29);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "Balance:";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserPictureBox.Image = global::Client_App.Properties.Resources.user;
            this.UserPictureBox.Location = new System.Drawing.Point(0, 0);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(221, 150);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 1;
            this.UserPictureBox.TabStop = false;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 643);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Controls.Add(this.dataGridViewOH);
            this.panel2.Controls.Add(this.labelOrdHisto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 411);
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
            this.dataGridViewOH.Size = new System.Drawing.Size(892, 309);
            this.dataGridViewOH.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index.HeaderText = "Order Number";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreated.HeaderText = "Date";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdQuantity.HeaderText = "Quantity";
            this.ProdQuantity.MinimumWidth = 6;
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.ReadOnly = true;
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
            this.panel3.Size = new System.Drawing.Size(924, 56);
            this.panel3.TabIndex = 3;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogout.Location = new System.Drawing.Point(821, 0);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(103, 56);
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
            this.buttonBack.Size = new System.Drawing.Size(103, 56);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(946, 678);
            this.Name = "ProfileForm";
            this.Text = "Profile Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.ProfileForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
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
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn DateCreated;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProdQuantity;
        private Label labelOrdHisto;
        private Panel panel3;
        private Button buttonLogout;
        private Button buttonBack;
        private Label labelMsg;
        private Label labelGenderAge;
    }
}