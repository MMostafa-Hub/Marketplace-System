namespace Client_App
{
    partial class ConnectionForm
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(265, 83);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(50, 20);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "label1";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(265, 120);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(50, 20);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "label1";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(302, 230);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 29);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(266, 167);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(50, 20);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "label1";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.IPLabel);
            this.Name = "ConnectionForm";
            this.Text = "Connection Page";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IPLabel;
        private Label portLabel;
        private Button connectButton;
        private Label instructionLabel;
    }
}