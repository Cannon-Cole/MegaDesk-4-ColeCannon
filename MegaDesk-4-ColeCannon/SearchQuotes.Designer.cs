﻿namespace MegaDesk_4_ColeCannon
{
    partial class SearchQuotes
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTitle = new System.Windows.Forms.Label();
            this.SearchMaterialCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ViewQuotesBackBtn
            // 
            this.ViewQuotesBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBackBtn.Location = new System.Drawing.Point(12, 280);
            this.ViewQuotesBackBtn.Name = "ViewQuotesBackBtn";
            this.ViewQuotesBackBtn.Size = new System.Drawing.Size(195, 50);
            this.ViewQuotesBackBtn.TabIndex = 3;
            this.ViewQuotesBackBtn.Text = "&Back";
            this.ViewQuotesBackBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBackBtn.Click += new System.EventHandler(this.ViewQuotesBackBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(13, 209);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(195, 65);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "&Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTitle
            // 
            this.SearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTitle.Location = new System.Drawing.Point(342, 7);
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.Size = new System.Drawing.Size(106, 42);
            this.SearchTitle.TabIndex = 0;
            this.SearchTitle.Text = "Search";
            this.SearchTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // SearchMaterialCombo
            // 
            this.SearchMaterialCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMaterialCombo.FormattingEnabled = true;
            this.SearchMaterialCombo.Location = new System.Drawing.Point(13, 95);
            this.SearchMaterialCombo.Name = "SearchMaterialCombo";
            this.SearchMaterialCombo.Size = new System.Drawing.Size(195, 39);
            this.SearchMaterialCombo.TabIndex = 12;
            this.SearchMaterialCombo.Text = "Select";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Material";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // SearchDisplay
            // 
            this.SearchDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDisplay.Location = new System.Drawing.Point(213, 95);
            this.SearchDisplay.Name = "SearchDisplay";
            this.SearchDisplay.Size = new System.Drawing.Size(575, 235);
            this.SearchDisplay.TabIndex = 11;
            this.SearchDisplay.Text = "";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchMaterialCombo);
            this.Controls.Add(this.SearchTitle);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ViewQuotesBackBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewQuotesBackBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label SearchTitle;
        private System.Windows.Forms.ComboBox SearchMaterialCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SearchDisplay;
    }
}