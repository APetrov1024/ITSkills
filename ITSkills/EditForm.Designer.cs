namespace ITSkills
{
    partial class editForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProfessionLabel = new System.Windows.Forms.Label();
            this.professionComboBox = new System.Windows.Forms.ComboBox();
            this.SkillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.professionSkillsListBox = new System.Windows.Forms.ListBox();
            this.employeeSkillsListBox = new System.Windows.Forms.ListBox();
            this.skillsControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addSkillButton = new System.Windows.Forms.Button();
            this.removeSkillButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SkillsTableLayoutPanel.SuspendLayout();
            this.skillsControlTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(52, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(301, 32);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.lastNameTextBox.TabIndex = 3;
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
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(550, 32);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(179, 20);
            this.patronymicTextBox.TabIndex = 5;
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
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(109, 71);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateTimePicker.TabIndex = 7;
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
            // professionComboBox
            // 
            this.professionComboBox.FormattingEnabled = true;
            this.professionComboBox.Location = new System.Drawing.Point(403, 71);
            this.professionComboBox.Name = "professionComboBox";
            this.professionComboBox.Size = new System.Drawing.Size(185, 21);
            this.professionComboBox.TabIndex = 9;
            // 
            // SkillsTableLayoutPanel
            // 
            this.SkillsTableLayoutPanel.ColumnCount = 3;
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SkillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SkillsTableLayoutPanel.Controls.Add(this.professionSkillsListBox, 0, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.employeeSkillsListBox, 2, 0);
            this.SkillsTableLayoutPanel.Controls.Add(this.skillsControlTableLayoutPanel, 1, 0);
            this.SkillsTableLayoutPanel.Location = new System.Drawing.Point(16, 103);
            this.SkillsTableLayoutPanel.Name = "SkillsTableLayoutPanel";
            this.SkillsTableLayoutPanel.RowCount = 1;
            this.SkillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SkillsTableLayoutPanel.Size = new System.Drawing.Size(772, 335);
            this.SkillsTableLayoutPanel.TabIndex = 10;
            // 
            // professionSkillsListBox
            // 
            this.professionSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionSkillsListBox.FormattingEnabled = true;
            this.professionSkillsListBox.Location = new System.Drawing.Point(3, 3);
            this.professionSkillsListBox.Name = "professionSkillsListBox";
            this.professionSkillsListBox.Size = new System.Drawing.Size(120, 329);
            this.professionSkillsListBox.TabIndex = 0;
            // 
            // employeeSkillsListBox
            // 
            this.employeeSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSkillsListBox.FormattingEnabled = true;
            this.employeeSkillsListBox.Location = new System.Drawing.Point(159, 3);
            this.employeeSkillsListBox.Name = "employeeSkillsListBox";
            this.employeeSkillsListBox.Size = new System.Drawing.Size(610, 329);
            this.employeeSkillsListBox.TabIndex = 1;
            // 
            // skillsControlTableLayoutPanel
            // 
            this.skillsControlTableLayoutPanel.ColumnCount = 1;
            this.skillsControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.Controls.Add(this.addSkillButton, 0, 0);
            this.skillsControlTableLayoutPanel.Controls.Add(this.removeSkillButton, 0, 1);
            this.skillsControlTableLayoutPanel.Location = new System.Drawing.Point(129, 3);
            this.skillsControlTableLayoutPanel.Name = "skillsControlTableLayoutPanel";
            this.skillsControlTableLayoutPanel.RowCount = 2;
            this.skillsControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillsControlTableLayoutPanel.Size = new System.Drawing.Size(24, 61);
            this.skillsControlTableLayoutPanel.TabIndex = 2;
            // 
            // addSkillButton
            // 
            this.addSkillButton.Location = new System.Drawing.Point(3, 3);
            this.addSkillButton.Name = "addSkillButton";
            this.addSkillButton.Size = new System.Drawing.Size(18, 23);
            this.addSkillButton.TabIndex = 0;
            this.addSkillButton.Text = ">";
            this.addSkillButton.UseVisualStyleBackColor = true;
            this.addSkillButton.Click += new System.EventHandler(this.AddSkillButton_Click);
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
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operationsToolStripMenuItem.Text = "Операции";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Сохранить изменения";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.SkillsTableLayoutPanel);
            this.Controls.Add(this.professionComboBox);
            this.Controls.Add(this.ProfessionLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editForm";
            this.Text = "EditForm";
            this.SkillsTableLayoutPanel.ResumeLayout(false);
            this.skillsControlTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label ProfessionLabel;
        private System.Windows.Forms.ComboBox professionComboBox;
        private System.Windows.Forms.TableLayoutPanel SkillsTableLayoutPanel;
        private System.Windows.Forms.ListBox professionSkillsListBox;
        private System.Windows.Forms.ListBox employeeSkillsListBox;
        private System.Windows.Forms.TableLayoutPanel skillsControlTableLayoutPanel;
        private System.Windows.Forms.Button addSkillButton;
        private System.Windows.Forms.Button removeSkillButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}