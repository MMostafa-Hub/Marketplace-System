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
			this.SuspendLayout();
			// 
			// deposit
			// 
			this.deposit.AutoSize = true;
			this.deposit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.deposit.Location = new System.Drawing.Point(166, 98);
			this.deposit.Name = "deposit";
			this.deposit.Size = new System.Drawing.Size(55, 23);
			this.deposit.TabIndex = 0;
			this.deposit.Text = "label1";
			this.deposit.Click += new System.EventHandler(this.label1_Click);
			// 
			// depositButton
			// 
			this.depositButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.depositButton.Location = new System.Drawing.Point(245, 181);
			this.depositButton.Name = "depositButton";
			this.depositButton.Size = new System.Drawing.Size(94, 29);
			this.depositButton.TabIndex = 1;
			this.depositButton.Text = "button1";
			this.depositButton.UseVisualStyleBackColor = true;
			this.depositButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// depositTextbox
			// 
			this.depositTextbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.depositTextbox.Location = new System.Drawing.Point(330, 98);
			this.depositTextbox.Name = "depositTextbox";
			this.depositTextbox.Size = new System.Drawing.Size(125, 30);
			this.depositTextbox.TabIndex = 2;
			// 
			// DepositForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 291);
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
	}
}