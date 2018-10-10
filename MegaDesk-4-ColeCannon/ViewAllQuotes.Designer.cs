namespace MegaDesk_4_ColeCannon
{
    partial class ViewAllQuotes
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
            this.ViewQuotesBackBtn = new System.Windows.Forms.Button();
            this.SearchDisplay = new System.Windows.Forms.RichTextBox();
            this.SearchTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewQuotesBackBtn
            // 
            this.ViewQuotesBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBackBtn.Location = new System.Drawing.Point(305, 350);
            this.ViewQuotesBackBtn.Name = "ViewQuotesBackBtn";
            this.ViewQuotesBackBtn.Size = new System.Drawing.Size(195, 50);
            this.ViewQuotesBackBtn.TabIndex = 2;
            this.ViewQuotesBackBtn.Text = "&Back";
            this.ViewQuotesBackBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBackBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchDisplay
            // 
            this.SearchDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDisplay.Location = new System.Drawing.Point(117, 81);
            this.SearchDisplay.Name = "SearchDisplay";
            this.SearchDisplay.Size = new System.Drawing.Size(575, 249);
            this.SearchDisplay.TabIndex = 12;
            this.SearchDisplay.Text = "";
            this.SearchDisplay.TextChanged += new System.EventHandler(this.SearchDisplay_TextChanged);
            // 
            // SearchTitle
            // 
            this.SearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTitle.Location = new System.Drawing.Point(330, 36);
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.Size = new System.Drawing.Size(152, 42);
            this.SearchTitle.TabIndex = 13;
            this.SearchTitle.Text = "All Quotes";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchTitle);
            this.Controls.Add(this.SearchDisplay);
            this.Controls.Add(this.ViewQuotesBackBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewQuotesBackBtn;
        private System.Windows.Forms.RichTextBox SearchDisplay;
        private System.Windows.Forms.Label SearchTitle;
    }
}