﻿namespace MegaDesk_4_ColeCannon
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.AddNewQuoteAcceptBtn = new System.Windows.Forms.Button();
            this.CancelQuoteBtn = new System.Windows.Forms.Button();
            this.HeightTitle = new System.Windows.Forms.Label();
            this.WidthTitle = new System.Windows.Forms.Label();
            this.HeightInputErrorLabel = new System.Windows.Forms.Label();
            this.WidthInputErrorLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RushCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuoteAdded = new System.Windows.Forms.Label();
            this.NotificationTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTitle = new System.Windows.Forms.Label();
            this.DrawerSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddNewQuoteAcceptBtn
            // 
            this.AddNewQuoteAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteAcceptBtn.Location = new System.Drawing.Point(437, 326);
            this.AddNewQuoteAcceptBtn.Name = "AddNewQuoteAcceptBtn";
            this.AddNewQuoteAcceptBtn.Size = new System.Drawing.Size(195, 65);
            this.AddNewQuoteAcceptBtn.TabIndex = 1;
            this.AddNewQuoteAcceptBtn.Text = "&Add New Quote";
            this.AddNewQuoteAcceptBtn.UseVisualStyleBackColor = true;
            this.AddNewQuoteAcceptBtn.Click += new System.EventHandler(this.AddNewQuoteAccept_Click);
            // 
            // CancelQuoteBtn
            // 
            this.CancelQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelQuoteBtn.Location = new System.Drawing.Point(192, 333);
            this.CancelQuoteBtn.Name = "CancelQuoteBtn";
            this.CancelQuoteBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CancelQuoteBtn.Size = new System.Drawing.Size(195, 50);
            this.CancelQuoteBtn.TabIndex = 2;
            this.CancelQuoteBtn.Text = "&Cancel";
            this.CancelQuoteBtn.UseVisualStyleBackColor = true;
            this.CancelQuoteBtn.Click += new System.EventHandler(this.CancelQuote_Click);
            // 
            // HeightTitle
            // 
            this.HeightTitle.AutoSize = true;
            this.HeightTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTitle.Location = new System.Drawing.Point(214, 111);
            this.HeightTitle.Name = "HeightTitle";
            this.HeightTitle.Size = new System.Drawing.Size(56, 20);
            this.HeightTitle.TabIndex = 5;
            this.HeightTitle.Text = "Height";
            this.HeightTitle.Click += new System.EventHandler(this.HeightTitle_Click);
            // 
            // WidthTitle
            // 
            this.WidthTitle.AutoSize = true;
            this.WidthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTitle.Location = new System.Drawing.Point(454, 111);
            this.WidthTitle.Name = "WidthTitle";
            this.WidthTitle.Size = new System.Drawing.Size(50, 20);
            this.WidthTitle.TabIndex = 6;
            this.WidthTitle.Text = "Width";
            // 
            // HeightInputErrorLabel
            // 
            this.HeightInputErrorLabel.AutoSize = true;
            this.HeightInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.HeightInputErrorLabel.Location = new System.Drawing.Point(215, 187);
            this.HeightInputErrorLabel.Name = "HeightInputErrorLabel";
            this.HeightInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.HeightInputErrorLabel.TabIndex = 7;
            this.HeightInputErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthInputErrorLabel
            // 
            this.WidthInputErrorLabel.AutoSize = true;
            this.WidthInputErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WidthInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.WidthInputErrorLabel.Location = new System.Drawing.Point(455, 187);
            this.WidthInputErrorLabel.Name = "WidthInputErrorLabel";
            this.WidthInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthInputErrorLabel.TabIndex = 8;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(218, 134);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(150, 38);
            this.HeightInput.TabIndex = 9;
            this.HeightInput.TextChanged += new System.EventHandler(this.HeightInput_TextChanged);
            this.HeightInput.Validating += new System.ComponentModel.CancelEventHandler(this.HeightInputValidation);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(461, 133);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(150, 38);
            this.WidthInput.TabIndex = 10;
            this.WidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthValidation);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(218, 231);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(150, 39);
            this.MaterialCombo.TabIndex = 11;
            this.MaterialCombo.Text = "Select";
            this.MaterialCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rush";
            // 
            // RushCombo
            // 
            this.RushCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushCombo.FormattingEnabled = true;
            this.RushCombo.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushCombo.Location = new System.Drawing.Point(458, 231);
            this.RushCombo.Name = "RushCombo";
            this.RushCombo.Size = new System.Drawing.Size(150, 39);
            this.RushCombo.TabIndex = 13;
            this.RushCombo.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of Drawers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuoteAdded
            // 
            this.QuoteAdded.AutoSize = true;
            this.QuoteAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteAdded.ForeColor = System.Drawing.Color.Green;
            this.QuoteAdded.Location = new System.Drawing.Point(659, 346);
            this.QuoteAdded.Name = "QuoteAdded";
            this.QuoteAdded.Size = new System.Drawing.Size(129, 25);
            this.QuoteAdded.TabIndex = 17;
            this.QuoteAdded.Text = "Quote Added";
            this.QuoteAdded.Visible = false;
            // 
            // NotificationTimer
            // 
            this.NotificationTimer.Interval = 2000;
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameBox.Location = new System.Drawing.Point(219, 47);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(150, 38);
            this.CustomerNameBox.TabIndex = 18;
            // 
            // CustomerNameTitle
            // 
            this.CustomerNameTitle.AutoSize = true;
            this.CustomerNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTitle.Location = new System.Drawing.Point(215, 24);
            this.CustomerNameTitle.Name = "CustomerNameTitle";
            this.CustomerNameTitle.Size = new System.Drawing.Size(124, 20);
            this.CustomerNameTitle.TabIndex = 19;
            this.CustomerNameTitle.Text = "Customer Name";
            // 
            // DrawerSelect
            // 
            this.DrawerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerSelect.FormattingEnabled = true;
            this.DrawerSelect.Items.AddRange(new object[] {
            "Select",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerSelect.Location = new System.Drawing.Point(461, 47);
            this.DrawerSelect.Name = "DrawerSelect";
            this.DrawerSelect.Size = new System.Drawing.Size(150, 39);
            this.DrawerSelect.TabIndex = 20;
            this.DrawerSelect.Text = "Select";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawerSelect);
            this.Controls.Add(this.CustomerNameTitle);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.QuoteAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RushCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInputErrorLabel);
            this.Controls.Add(this.HeightInputErrorLabel);
            this.Controls.Add(this.WidthTitle);
            this.Controls.Add(this.HeightTitle);
            this.Controls.Add(this.CancelQuoteBtn);
            this.Controls.Add(this.AddNewQuoteAcceptBtn);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteAcceptBtn;
        private System.Windows.Forms.Button CancelQuoteBtn;
        private System.Windows.Forms.Label HeightTitle;
        private System.Windows.Forms.Label WidthTitle;
        private System.Windows.Forms.Label HeightInputErrorLabel;
        private System.Windows.Forms.Label WidthInputErrorLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RushCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuoteAdded;
        private System.Windows.Forms.Timer NotificationTimer;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Label CustomerNameTitle;
        private System.Windows.Forms.ComboBox DrawerSelect;
    }
}