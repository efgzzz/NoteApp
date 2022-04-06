namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteName = new System.Windows.Forms.Label();
            this.CategoryStaticLabel = new System.Windows.Forms.Label();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CreatedStaticLabel = new System.Windows.Forms.Label();
            this.CreationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifedStaticLabel = new System.Windows.Forms.Label();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(644, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NoteName
            // 
            this.NoteName.AutoSize = true;
            this.NoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteName.Location = new System.Drawing.Point(272, 33);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(115, 24);
            this.NoteName.TabIndex = 0;
            this.NoteName.Text = "Note Name";
            // 
            // CategoryStaticLabel
            // 
            this.CategoryStaticLabel.AutoSize = true;
            this.CategoryStaticLabel.Location = new System.Drawing.Point(262, 66);
            this.CategoryStaticLabel.Name = "CategoryStaticLabel";
            this.CategoryStaticLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryStaticLabel.TabIndex = 1;
            this.CategoryStaticLabel.Text = "Category: ";
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(323, 66);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(80, 13);
            this.CategoryNameLabel.TabIndex = 2;
            this.CategoryNameLabel.Text = "Category Name";
            // 
            // CreatedStaticLabel
            // 
            this.CreatedStaticLabel.AutoSize = true;
            this.CreatedStaticLabel.Location = new System.Drawing.Point(262, 100);
            this.CreatedStaticLabel.Name = "CreatedStaticLabel";
            this.CreatedStaticLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedStaticLabel.TabIndex = 3;
            this.CreatedStaticLabel.Text = "Created:";
            // 
            // CreationDatePicker
            // 
            this.CreationDatePicker.Enabled = false;
            this.CreationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDatePicker.Location = new System.Drawing.Point(315, 94);
            this.CreationDatePicker.Name = "CreationDatePicker";
            this.CreationDatePicker.Size = new System.Drawing.Size(91, 20);
            this.CreationDatePicker.TabIndex = 4;
            // 
            // ModifedDatePicker
            // 
            this.ModifedDatePicker.Enabled = false;
            this.ModifedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifedDatePicker.Location = new System.Drawing.Point(466, 94);
            this.ModifedDatePicker.Name = "ModifedDatePicker";
            this.ModifedDatePicker.Size = new System.Drawing.Size(91, 20);
            this.ModifedDatePicker.TabIndex = 5;
            // 
            // ModifedStaticLabel
            // 
            this.ModifedStaticLabel.AutoSize = true;
            this.ModifedStaticLabel.Location = new System.Drawing.Point(412, 100);
            this.ModifedStaticLabel.Name = "ModifedStaticLabel";
            this.ModifedStaticLabel.Size = new System.Drawing.Size(48, 13);
            this.ModifedStaticLabel.TabIndex = 6;
            this.ModifedStaticLabel.Text = "Modifed:";
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 37);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(97, 34);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(151, 21);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Location = new System.Drawing.Point(12, 75);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(236, 290);
            this.NoteListBox.TabIndex = 3;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // NoteText
            // 
            this.NoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteText.Location = new System.Drawing.Point(265, 120);
            this.NoteText.Name = "NoteText";
            this.NoteText.ReadOnly = true;
            this.NoteText.Size = new System.Drawing.Size(367, 284);
            this.NoteText.TabIndex = 7;
            this.NoteText.Text = "";
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.garbage_remove_clean_recycle_bin_waste_trash_icon_219330;
            this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteNoteButton.Location = new System.Drawing.Point(71, 381);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(23, 23);
            this.DeleteNoteButton.TabIndex = 6;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.pen_app_process_draw_creative_web_edit_icon_219334;
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditNoteButton.Location = new System.Drawing.Point(41, 381);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(23, 23);
            this.EditNoteButton.TabIndex = 5;
            this.EditNoteButton.Text = " ";
            this.EditNoteButton.UseVisualStyleBackColor = true;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.archive_manage_data_folder_file_office_document_icon_219302;
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 381);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(23, 23);
            this.AddNoteButton.TabIndex = 4;
            this.AddNoteButton.Text = " ";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.ModifedStaticLabel);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.ModifedDatePicker);
            this.Controls.Add(this.NoteListBox);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CreationDatePicker);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.NoteName);
            this.Controls.Add(this.CreatedStaticLabel);
            this.Controls.Add(this.CategoryStaticLabel);
            this.Controls.Add(this.CategoryNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(660, 455);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label NoteName;
        private System.Windows.Forms.Label CategoryStaticLabel;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label CreatedStaticLabel;
        private System.Windows.Forms.DateTimePicker CreationDatePicker;
        private System.Windows.Forms.DateTimePicker ModifedDatePicker;
        private System.Windows.Forms.Label ModifedStaticLabel;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        internal System.Windows.Forms.Button AddNoteButton;
    }
}

