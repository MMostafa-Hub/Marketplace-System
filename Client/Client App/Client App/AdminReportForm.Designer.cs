namespace Client_App
{
    partial class AdminReportForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrdRepo = new System.Windows.Forms.Button();
            this.btnProdRep = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelUpdateDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnOrdRepo);
            this.panel1.Controls.Add(this.btnProdRep);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 421);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 368);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 51);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrdRepo
            // 
            this.btnOrdRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdRepo.Location = new System.Drawing.Point(0, 243);
            this.btnOrdRepo.Name = "btnOrdRepo";
            this.btnOrdRepo.Size = new System.Drawing.Size(125, 51);
            this.btnOrdRepo.TabIndex = 3;
            this.btnOrdRepo.Text = "Orders Report";
            this.btnOrdRepo.UseVisualStyleBackColor = true;
            this.btnOrdRepo.Click += new System.EventHandler(this.btnUserAct_Click);
            // 
            // btnProdRep
            // 
            this.btnProdRep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdRep.Location = new System.Drawing.Point(0, 192);
            this.btnProdRep.Name = "btnProdRep";
            this.btnProdRep.Size = new System.Drawing.Size(125, 51);
            this.btnProdRep.TabIndex = 2;
            this.btnProdRep.Text = "Products Report";
            this.btnProdRep.UseVisualStyleBackColor = true;
            this.btnProdRep.Click += new System.EventHandler(this.btnProdRep_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(0, 141);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(125, 51);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelAdmin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 141);
            this.panel2.TabIndex = 1;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdmin.Location = new System.Drawing.Point(39, 100);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(50, 16);
            this.labelAdmin.TabIndex = 1;
            this.labelAdmin.Text = "Admin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client_App.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(33, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormLoader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormLoader.Location = new System.Drawing.Point(127, 81);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(450, 340);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(16, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(71, 31);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Controls.Add(this.labelUpdateDate);
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(127, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 83);
            this.panel3.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTime.Location = new System.Drawing.Point(113, 61);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 17);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            // 
            // labelUpdateDate
            // 
            this.labelUpdateDate.AutoSize = true;
            this.labelUpdateDate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUpdateDate.Location = new System.Drawing.Point(16, 61);
            this.labelUpdateDate.Name = "labelUpdateDate";
            this.labelUpdateDate.Size = new System.Drawing.Size(100, 17);
            this.labelUpdateDate.TabIndex = 3;
            this.labelUpdateDate.Text = "Last updated @";
            // 
            // AdminReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(593, 459);
            this.Name = "AdminReportForm";
            this.Text = "Store Statistics";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelAdmin;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnOrdRepo;
        private Button btnProdRep;
        private Button btnDashboard;
        private Panel pnlFormLoader;
        private Label labelTitle;
        private Panel panel3;
        private Label labelUpdateDate;
        private Label labelTime;
    }
}