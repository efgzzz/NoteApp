namespace NoteApp.View
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLable = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.CreationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ModifedLabel = new System.Windows.Forms.Label();
            this.ModifedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(12, 19);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(33, 13);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Title: ";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 49);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category: ";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(12, 81);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(80, 19);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(358, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(80, 49);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryBox.TabIndex = 4;
            // 
            // CreationDatePicker
            // 
            this.CreationDatePicker.Enabled = false;
            this.CreationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDatePicker.Location = new System.Drawing.Point(80, 81);
            this.CreationDatePicker.Name = "CreationDatePicker";
            this.CreationDatePicker.Size = new System.Drawing.Size(91, 20);
            this.CreationDatePicker.TabIndex = 5;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(15, 122);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(423, 242);
            this.NoteTextBox.TabIndex = 6;
            this.NoteTextBox.Text = "";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(282, 369);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 24);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(363, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 24);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ModifedLabel
            // 
            this.ModifedLabel.AutoSize = true;
            this.ModifedLabel.Location = new System.Drawing.Point(189, 81);
            this.ModifedLabel.Name = "ModifedLabel";
            this.ModifedLabel.Size = new System.Drawing.Size(51, 13);
            this.ModifedLabel.TabIndex = 9;
            this.ModifedLabel.Text = "Modifed: ";
            // 
            // ModifedDatePicker
            // 
            this.ModifedDatePicker.Enabled = false;
            this.ModifedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifedDatePicker.Location = new System.Drawing.Point(247, 80);
            this.ModifedDatePicker.Name = "ModifedDatePicker";
            this.ModifedDatePicker.Size = new System.Drawing.Size(91, 20);
            this.ModifedDatePicker.TabIndex = 10;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 401);
            this.Controls.Add(this.ModifedDatePicker);
            this.Controls.Add(this.ModifedLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.CreationDatePicker);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 440);
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.DateTimePicker CreationDatePicker;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ModifedLabel;
        private System.Windows.Forms.DateTimePicker ModifedDatePicker;
    }
}