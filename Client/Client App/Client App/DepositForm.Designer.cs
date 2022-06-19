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
			this.deposit.AutoSize = true;
			this.deposit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.deposit.Location = new System.Drawing.Point(143, 137);
			this.deposit.Name = "deposit";
			this.deposit.Size = new System.Drawing.Size(156, 23);
			this.deposit.TabIndex = 0;
			this.deposit.Text = "Enter deposit value";
			this.deposit.Click += new System.EventHandler(this.label1_Click);
			// 
			// depositButton
			// 
			this.depositButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.depositButton.Location = new System.Drawing.Point(279, 193);
			this.depositButton.Name = "depositButton";
			this.depositButton.Size = new System.Drawing.Size(94, 29);
			this.depositButton.TabIndex = 1;
			this.depositButton.Text = "Deposit";
			this.depositButton.UseVisualStyleBackColor = true;
			this.depositButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// depositTextbox
			// 
			this.depositTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.depositTextbox.Location = new System.Drawing.Point(361, 130);
			this.depositTextbox.Name = "depositTextbox";
			this.depositTextbox.Size = new System.Drawing.Size(125, 30);
			this.depositTextbox.TabIndex = 2;
			this.depositTextbox.TextChanged += new System.EventHandler(this.depositTextbox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(189, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(143, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Current balance";
			// 
			// currentBalance
			// 
			this.currentBalance.AutoSize = true;
			this.currentBalance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.currentBalance.Location = new System.Drawing.Point(361, 73);
			this.currentBalance.Name = "currentBalance";
			this.currentBalance.Size = new System.Drawing.Size(177, 23);
			this.currentBalance.TabIndex = 5;
			this.currentBalance.Text = "Current balance value";
			this.currentBalance.Click += new System.EventHandler(this.label3_Click);
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(12, 12);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(64, 30);
			this.backButton.TabIndex = 6;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// DepositForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 254);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.currentBalance);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.depositTextbox);
			this.Controls.Add(this.depositButton);
			this.Controls.Add(this.deposit);
			this.Name = "DepositForm";
			this.Text = "DepositForm";
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