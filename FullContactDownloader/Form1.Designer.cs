namespace FullContactDownloader
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
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ConsoleRichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(12, 250);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(429, 23);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "DownloadButton";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ConsoleRichBox
            // 
            this.ConsoleRichBox.Location = new System.Drawing.Point(12, 12);
            this.ConsoleRichBox.Name = "ConsoleRichBox";
            this.ConsoleRichBox.Size = new System.Drawing.Size(429, 232);
            this.ConsoleRichBox.TabIndex = 1;
            this.ConsoleRichBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 285);
            this.Controls.Add(this.ConsoleRichBox);
            this.Controls.Add(this.DownloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.RichTextBox ConsoleRichBox;
    }
}

