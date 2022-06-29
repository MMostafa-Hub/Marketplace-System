namespace Client_App
{
    partial class DepositForm
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
            this.deposit = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentBalance = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deposit
            // 
            this.deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deposit.AutoSize = true;
            this.deposit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deposit.Location = new System.Drawing.Point(125, 103);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(126, 19);
            this.deposit.TabIndex = 0;
            this.deposit.Text = "Enter deposit value";
            this.deposit.Click += new System.EventHandler(this.label1_Click);
            // 
            // depositButton
            // 
            this.depositButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositButton.Location = new System.Drawing.Point(244, 145);
            this.depositButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(82, 22);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositTextbox
            // 
            this.depositTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositTextbox.Location = new System.Drawing.Point(316, 98);
            this.depositTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositTextbox.Name = "depositTextbox";
            this.depositTextbox.Size = new System.Drawing.Size(110, 26);
            this.depositTextbox.TabIndex = 2;
            this.depositTextbox.TextChanged += new System.EventHandler(this.depositTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(125, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current balance";
            // 
            // currentBalance
            // 
            this.currentBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentBalance.AutoSize = true;
            this.currentBalance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentBalance.Location = new System.Drawing.Point(316, 55);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(142, 19);
            this.currentBalance.TabIndex = 5;
            this.currentBalance.Text = "Current balance value";
            this.currentBalance.Click += new System.EventHandler(this.label3_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 9);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 22);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 192);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositTextbox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.deposit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(630, 230);
            this.Name = "DepositForm";
            this.Text = "Deposit Page";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private Label deposit;
		private Button depositButton;
		private TextBox depositTextbox;
		private Label label1;
		private Label label2;
		private Label currentBalance;
		private Button backButton;
	}
}