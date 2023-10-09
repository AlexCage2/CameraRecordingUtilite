namespace AforgeCamereRecording
{
    partial class Form1
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.StartRecButton = new System.Windows.Forms.Button();
            this.StopRecButton = new System.Windows.Forms.Button();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.DevicesBox = new System.Windows.Forms.ComboBox();
            this.SelectDeviceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(286, 344);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status";
            // 
            // StartRecButton
            // 
            this.StartRecButton.Location = new System.Drawing.Point(21, 339);
            this.StartRecButton.Name = "StartRecButton";
            this.StartRecButton.Size = new System.Drawing.Size(75, 23);
            this.StartRecButton.TabIndex = 3;
            this.StartRecButton.Text = "Start Rec";
            this.StartRecButton.UseVisualStyleBackColor = true;
            this.StartRecButton.Click += new System.EventHandler(this.StartRecButton_Click);
            // 
            // StopRecButton
            // 
            this.StopRecButton.Location = new System.Drawing.Point(112, 339);
            this.StopRecButton.Name = "StopRecButton";
            this.StopRecButton.Size = new System.Drawing.Size(75, 23);
            this.StopRecButton.TabIndex = 4;
            this.StopRecButton.Text = "Stop Rec";
            this.StopRecButton.UseVisualStyleBackColor = true;
            this.StopRecButton.Click += new System.EventHandler(this.StopRecButton_Click);
            // 
            // MainPicture
            // 
            this.MainPicture.Location = new System.Drawing.Point(12, 12);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(776, 321);
            this.MainPicture.TabIndex = 5;
            this.MainPicture.TabStop = false;
            // 
            // DevicesBox
            // 
            this.DevicesBox.FormattingEnabled = true;
            this.DevicesBox.Location = new System.Drawing.Point(193, 385);
            this.DevicesBox.Name = "DevicesBox";
            this.DevicesBox.Size = new System.Drawing.Size(121, 21);
            this.DevicesBox.TabIndex = 6;
            // 
            // SelectDeviceButton
            // 
            this.SelectDeviceButton.Location = new System.Drawing.Point(193, 339);
            this.SelectDeviceButton.Name = "SelectDeviceButton";
            this.SelectDeviceButton.Size = new System.Drawing.Size(87, 23);
            this.SelectDeviceButton.TabIndex = 7;
            this.SelectDeviceButton.Text = "Select Device";
            this.SelectDeviceButton.UseVisualStyleBackColor = true;
            this.SelectDeviceButton.Click += new System.EventHandler(this.SelectDeviceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectDeviceButton);
            this.Controls.Add(this.DevicesBox);
            this.Controls.Add(this.MainPicture);
            this.Controls.Add(this.StopRecButton);
            this.Controls.Add(this.StartRecButton);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button StartRecButton;
        private System.Windows.Forms.Button StopRecButton;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.ComboBox DevicesBox;
        private System.Windows.Forms.Button SelectDeviceButton;
    }
}

