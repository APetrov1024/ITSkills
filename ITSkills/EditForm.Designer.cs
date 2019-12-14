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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editForm));
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
            this.skillsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.professionSkillsListBox = new System.Windows.Forms.ListBox();
            this.employeeSkillsListBox = new System.Windows.Forms.ListBox();
            this.skillsControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addSkillButton = new System.Windows.Forms.Button();
            this.removeSkillButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.informationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.basementTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.skillsTableLayoutPanel.SuspendLayout();
            this.skillsControlTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.informationTableLayoutPanel.SuspendLayout();
            this.basementTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(180, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(189, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Location = new System.Drawing.Point(189, 28);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 25);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(180, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronymicTextBox.Location = new System.Drawing.Point(189, 53);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(180, 20);
            this.patronymicTextBox.TabIndex = 5;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatronymicLabel.Location = new System.Drawing.Point(3, 50);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(180, 25);
            this.PatronymicLabel.TabIndex = 4;
            this.PatronymicLabel.Text = "Отчество";
            this.PatronymicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirthDateLabel.Location = new System.Drawing.Point(3, 75);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(180, 25);
            this.BirthDateLabel.TabIndex = 6;
            this.BirthDateLabel.Text = "Дата рождения";
            this.BirthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateTimePicker.Location = new System.Drawing.Point(189, 78);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.birthDateTimePicker.TabIndex = 7;
            // 
            // ProfessionLabel
            // 
            this.ProfessionLabel.AutoSize = true;
            this.ProfessionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfessionLabel.Location = new System.Drawing.Point(3, 100);
            this.ProfessionLabel.Name = "ProfessionLabel";
            this.ProfessionLabel.Size = new System.Drawing.Size(180, 29);
            this.ProfessionLabel.TabIndex = 8;
            this.ProfessionLabel.Text = "Профессия";
            this.ProfessionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // professionComboBox
            // 
            this.professionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionComboBox.FormattingEnabled = true;
            this.professionComboBox.Location = new System.Drawing.Point(189, 103);
            this.professionComboBox.Name = "professionComboBox";
            this.professionComboBox.Size = new System.Drawing.Size(180, 21);
            this.professionComboBox.TabIndex = 9;
            // 
            // skillsTableLayoutPanel
            // 
            this.skillsTableLayoutPanel.ColumnCount = 3;
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.skillsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.skillsTableLayoutPanel.Controls.Add(this.professionSkillsListBox, 0, 0);
            this.skillsTableLayoutPanel.Controls.Add(this.employeeSkillsListBox, 2, 0);
            this.skillsTableLayoutPanel.Controls.Add(this.skillsControlTableLayoutPanel, 1, 0);
            this.skillsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsTableLayoutPanel.Location = new System.Drawing.Point(3, 138);
            this.skillsTableLayoutPanel.Name = "skillsTableLayoutPanel";
            this.skillsTableLayoutPanel.RowCount = 1;
            this.skillsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.skillsTableLayoutPanel.Size = new System.Drawing.Size(392, 348);
            this.skillsTableLayoutPanel.TabIndex = 10;
            // 
            // professionSkillsListBox
            // 
            this.professionSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionSkillsListBox.FormattingEnabled = true;
            this.professionSkillsListBox.Location = new System.Drawing.Point(3, 3);
            this.professionSkillsListBox.Name = "professionSkillsListBox";
            this.professionSkillsListBox.Size = new System.Drawing.Size(120, 342);
            this.professionSkillsListBox.TabIndex = 0;
            // 
            // employeeSkillsListBox
            // 
            this.employeeSkillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSkillsListBox.FormattingEnabled = true;
            this.employeeSkillsListBox.Location = new System.Drawing.Point(159, 3);
            this.employeeSkillsListBox.Name = "employeeSkillsListBox";
            this.employeeSkillsListBox.Size = new System.Drawing.Size(348, 342);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripButton.Text = "Сохранить изменения";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // informationTableLayoutPanel
            // 
            this.informationTableLayoutPanel.ColumnCount = 3;
            this.informationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.informationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.informationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.informationTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.informationTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.informationTableLayoutPanel.Controls.Add(this.lastNameLabel, 0, 1);
            this.informationTableLayoutPanel.Controls.Add(this.professionComboBox, 1, 4);
            this.informationTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 1);
            this.informationTableLayoutPanel.Controls.Add(this.ProfessionLabel, 0, 4);
            this.informationTableLayoutPanel.Controls.Add(this.PatronymicLabel, 0, 2);
            this.informationTableLayoutPanel.Controls.Add(this.birthDateTimePicker, 1, 3);
            this.informationTableLayoutPanel.Controls.Add(this.patronymicTextBox, 1, 2);
            this.informationTableLayoutPanel.Controls.Add(this.BirthDateLabel, 0, 3);
            this.informationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.informationTableLayoutPanel.Name = "informationTableLayoutPanel";
            this.informationTableLayoutPanel.RowCount = 5;
            this.informationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.informationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.informationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.informationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.informationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.informationTableLayoutPanel.Size = new System.Drawing.Size(392, 129);
            this.informationTableLayoutPanel.TabIndex = 12;
            // 
            // basementTableLayoutPanel
            // 
            this.basementTableLayoutPanel.ColumnCount = 1;
            this.basementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.basementTableLayoutPanel.Controls.Add(this.informationTableLayoutPanel, 0, 0);
            this.basementTableLayoutPanel.Controls.Add(this.skillsTableLayoutPanel, 0, 1);
            this.basementTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basementTableLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.basementTableLayoutPanel.Name = "basementTableLayoutPanel";
            this.basementTableLayoutPanel.RowCount = 2;
            this.basementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.basementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basementTableLayoutPanel.Size = new System.Drawing.Size(398, 487);
            this.basementTableLayoutPanel.TabIndex = 13;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 512);
            this.Controls.Add(this.basementTableLayoutPanel);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(414, 551);
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование информации о сотруднике";
            this.skillsTableLayoutPanel.ResumeLayout(false);
            this.skillsControlTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.informationTableLayoutPanel.ResumeLayout(false);
            this.informationTableLayoutPanel.PerformLayout();
            this.basementTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel skillsTableLayoutPanel;
        private System.Windows.Forms.ListBox professionSkillsListBox;
        private System.Windows.Forms.ListBox employeeSkillsListBox;
        private System.Windows.Forms.TableLayoutPanel skillsControlTableLayoutPanel;
        private System.Windows.Forms.Button addSkillButton;
        private System.Windows.Forms.Button removeSkillButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TableLayoutPanel informationTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel basementTableLayoutPanel;
    }
}