namespace ITSkills
{
    partial class EditForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProfessionLabel = new System.Windows.Forms.Label();
            this.ProfessionComboBox = new System.Windows.Forms.ComboBox();
            this.SkillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProfessionSkillsListBox = new System.Windows.Forms.ListBox();
            this.EmployeeSkillsListBox = new System.Windows.Forms.ListBox();
            this.skillsControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddSkillButton = new System.Windows.Forms.Button();
            this.removeSkillButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsTableLayoutPanel.SuspendLayout();
            this.skillsControlTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(52, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(301, 32);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(239, 36);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(550, 32);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(179, 20);
            this.PatronymicTextBox.TabIndex = 5;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(490, 36);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.PatronymicLabel.TabIndex = 4;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(17, 74);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthDateLabel.TabIndex = 6;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.Location = new System.Drawing.Point(109, 74);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDateTimePicker.TabIndex = 7;
            // 
            // ProfessionLabel
            // 
            this.ProfessionLabel.AutoSize = true;
            this.ProfessionLabel.Location = new System.Drawing.Point(332, 74);
            this.ProfessionLabel.Name = "ProfessionLabel";
            this.ProfessionLabel.Size = new System.Drawing.Size(65, 13);
            this.ProfessionLabel.TabIndex = 8;
            this.ProfessionLabel.Text = "Профессия";
            // 
            // ProfessionComboBox
            // 
            this.ProfessionComboBox.FormattingEnabled = true;
            this.ProfessionComboBox.Location = new System.Drawing.Point(404, 65);
            this.ProfessionComboBox.Name = "ProfessionComboBox";
            this.ProfessionComboBox.Size = new System.Drawing.Size(185, 21);
            this.ProfessionComboBox.TabIndex = 9;
            // 
            // SkillsTableLayoutPanel
            // 
            this.SkillsTableLayoutPanel.ColumnCount = 3;
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SkillsTableLayoutPanel.Controls.Add(this.ProfessionSkillsListBox, 0, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.EmployeeSkillsListBox, 2, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.skillsControlTableLayoutPanel, 1, 0);
            this.SkillsTableLayoutPanel.Location = new System.Drawing.Point(16, 103);
            this.SkillsTableLayoutPanel.Name = "SkillsTableLayoutPanel";
            this.SkillsTableLayoutPanel.RowCount = 1;
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SkillsTableLayoutPanel.Size = new System.Drawing.Size(772, 335);
            this.SkillsTableLayoutPanel.TabIndex = 10;
            // 
            // ProfessionSkillsListBox
            // 
            this.ProfessionSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfessionSkillsListBox.FormattingEnabled = true;
            this.ProfessionSkillsListBox.Location = new System.Drawing.Point(3, 3);
            this.ProfessionSkillsListBox.Name = "ProfessionSkillsListBox";
            this.ProfessionSkillsListBox.Size = new System.Drawing.Size(120, 329);
            this.ProfessionSkillsListBox.TabIndex = 0;
            // 
            // EmployeeSkillsListBox
            // 
            this.EmployeeSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeSkillsListBox.FormattingEnabled = true;
            this.EmployeeSkillsListBox.Location = new System.Drawing.Point(159, 3);
            this.EmployeeSkillsListBox.Name = "EmployeeSkillsListBox";
            this.EmployeeSkillsListBox.Size = new System.Drawing.Size(610, 329);
            this.EmployeeSkillsListBox.TabIndex = 1;
            // 
            // skillsControlTableLayoutPanel
            // 
            this.skillsControlTableLayoutPanel.ColumnCount = 1;
            this.skillsControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.Controls.Add(this.AddSkillButton, 0, 0);
            this.skillsControlTableLayoutPanel.Controls.Add(this.removeSkillButton, 0, 1);
            this.skillsControlTableLayoutPanel.Location = new System.Drawing.Point(129, 3);
            this.skillsControlTableLayoutPanel.Name = "skillsControlTableLayoutPanel";
            this.skillsControlTableLayoutPanel.RowCount = 2;
            this.skillsControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.Size = new System.Drawing.Size(24, 61);
            this.skillsControlTableLayoutPanel.TabIndex = 2;
            // 
            // AddSkillButton
            // 
            this.AddSkillButton.Location = new System.Drawing.Point(3, 3);
            this.AddSkillButton.Name = "AddSkillButton";
            this.AddSkillButton.Size = new System.Drawing.Size(18, 23);
            this.AddSkillButton.TabIndex = 0;
            this.AddSkillButton.Text = ">";
            this.AddSkillButton.UseVisualStyleBackColor = true;
            this.AddSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
            // 
            // removeSkillButton
            // 
            this.removeSkillButton.Location = new System.Drawing.Point(3, 33);
            this.removeSkillButton.Name = "removeSkillButton";
            this.removeSkillButton.Size = new System.Drawing.Size(18, 23);
            this.removeSkillButton.TabIndex = 1;
            this.removeSkillButton.Text = "<";
            this.removeSkillButton.UseVisualStyleBackColor = true;
            this.removeSkillButton.Click += new System.EventHandler(this.removeSkillButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить изменения";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.SkillsTableLayoutPanel);
            this.Controls.Add(this.ProfessionComboBox);
            this.Controls.Add(this.ProfessionLabel);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.SkillsTableLayoutPanel.ResumeLayout(false);
            this.skillsControlTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.Label ProfessionLabel;
        private System.Windows.Forms.ComboBox ProfessionComboBox;
        private System.Windows.Forms.TableLayoutPanel SkillsTableLayoutPanel;
        private System.Windows.Forms.ListBox ProfessionSkillsListBox;
        private System.Windows.Forms.ListBox EmployeeSkillsListBox;
        private System.Windows.Forms.TableLayoutPanel skillsControlTableLayoutPanel;
        private System.Windows.Forms.Button AddSkillButton;
        private System.Windows.Forms.Button removeSkillButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}