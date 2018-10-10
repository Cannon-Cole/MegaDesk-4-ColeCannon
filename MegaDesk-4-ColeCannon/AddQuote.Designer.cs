namespace MegaDesk_4_ColeCannon
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
            this.DrawerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.QuoteAdded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerUpDown)).BeginInit();
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
            this.HeightTitle.Location = new System.Drawing.Point(197, 16);
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
            this.WidthTitle.Location = new System.Drawing.Point(433, 16);
            this.WidthTitle.Name = "WidthTitle";
            this.WidthTitle.Size = new System.Drawing.Size(50, 20);
            this.WidthTitle.TabIndex = 6;
            this.WidthTitle.Text = "Width";
            // 
            // HeightInputErrorLabel
            // 
            this.HeightInputErrorLabel.AutoSize = true;
            this.HeightInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.HeightInputErrorLabel.Location = new System.Drawing.Point(198, 92);
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
            this.WidthInputErrorLabel.Location = new System.Drawing.Point(434, 92);
            this.WidthInputErrorLabel.Name = "WidthInputErrorLabel";
            this.WidthInputErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.WidthInputErrorLabel.TabIndex = 8;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(201, 39);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(150, 38);
            this.HeightInput.TabIndex = 9;
            this.HeightInput.TextChanged += new System.EventHandler(this.HeightInput_TextChanged);
            this.HeightInput.Validating += new System.ComponentModel.CancelEventHandler(this.HeightInputValidation);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(437, 39);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(150, 38);
            this.WidthInput.TabIndex = 10;
            this.WidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthValidation);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(201, 136);
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
            this.label1.Location = new System.Drawing.Point(198, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 113);
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
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushCombo.Location = new System.Drawing.Point(437, 136);
            this.RushCombo.Name = "RushCombo";
            this.RushCombo.Size = new System.Drawing.Size(150, 39);
            this.RushCombo.TabIndex = 13;
            this.RushCombo.Text = "Select";
            // 
            // DrawerUpDown
            // 
            this.DrawerUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerUpDown.Location = new System.Drawing.Point(201, 240);
            this.DrawerUpDown.Name = "DrawerUpDown";
            this.DrawerUpDown.Size = new System.Drawing.Size(150, 38);
            this.DrawerUpDown.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 217);
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
            this.QuoteAdded.Location = new System.Drawing.Point(472, 286);
            this.QuoteAdded.Name = "QuoteAdded";
            this.QuoteAdded.Size = new System.Drawing.Size(129, 25);
            this.QuoteAdded.TabIndex = 17;
            this.QuoteAdded.Text = "Quote Added";
            this.QuoteAdded.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuoteAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DrawerUpDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.DrawerUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown DrawerUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuoteAdded;
    }
}