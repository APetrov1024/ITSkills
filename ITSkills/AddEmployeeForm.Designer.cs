namespace ITSkills
{
    partial class AddEmployeeForm
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
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.patronomycLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.professionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.professionComboBox = new System.Windows.Forms.ComboBox();
            this.dataTableLayoutPanel.SuspendLayout();
            this.controlsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 2;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.dataTableLayoutPanel.Controls.Add(this.lastNameLabel, 0, 1);
            this.dataTableLayoutPanel.Controls.Add(this.patronomycLabel, 0, 2);
            this.dataTableLayoutPanel.Controls.Add(this.birthDateLabel, 0, 3);
            this.dataTableLayoutPanel.Controls.Add(this.professionLabel, 0, 4);
            this.dataTableLayoutPanel.Controls.Add(this.nameTextBox, 1, 0);
            this.dataTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 1);
            this.dataTableLayoutPanel.Controls.Add(this.patronymicTextBox, 1, 2);
            this.dataTableLayoutPanel.Controls.Add(this.birthDateTimePicker, 1, 3);
            this.dataTableLayoutPanel.Controls.Add(this.professionComboBox, 1, 4);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 5;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(541, 100);
            this.dataTableLayoutPanel.TabIndex = 0;
            // 
            // controlsTableLayoutPanel
            // 
            this.controlsTableLayoutPanel.ColumnCount = 2;
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.controlsTableLayoutPanel.Controls.Add(this.cancelButton, 1, 0);
            this.controlsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsTableLayoutPanel.Location = new System.Drawing.Point(0, 111);
            this.controlsTableLayoutPanel.Name = "controlsTableLayoutPanel";
            this.controlsTableLayoutPanel.RowCount = 1;
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlsTableLayoutPanel.Size = new System.Drawing.Size(541, 27);
            this.controlsTableLayoutPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(264, 21);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(273, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(265, 21);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(264, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 20);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(264, 20);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patronomycLabel
            // 
            this.patronomycLabel.AutoSize = true;
            this.patronomycLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronomycLabel.Location = new System.Drawing.Point(3, 40);
            this.patronomycLabel.Name = "patronomycLabel";
            this.patronomycLabel.Size = new System.Drawing.Size(264, 20);
            this.patronomycLabel.TabIndex = 2;
            this.patronomycLabel.Text = "Отчество";
            this.patronomycLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateLabel.Location = new System.Drawing.Point(3, 60);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(264, 20);
            this.birthDateLabel.TabIndex = 3;
            this.birthDateLabel.Text = "Дата рождения";
            this.birthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionLabel.Location = new System.Drawing.Point(3, 80);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(264, 20);
            this.professionLabel.TabIndex = 4;
            this.professionLabel.Text = "Профессия";
            this.professionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(273, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Location = new System.Drawing.Point(273, 23);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronymicTextBox.Location = new System.Drawing.Point(273, 43);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(265, 20);
            this.patronymicTextBox.TabIndex = 7;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateTimePicker.Location = new System.Drawing.Point(273, 63);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this.birthDateTimePicker.TabIndex = 8;
            // 
            // professionComboBox
            // 
            this.professionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionComboBox.FormattingEnabled = true;
            this.professionComboBox.Location = new System.Drawing.Point(273, 83);
            this.professionComboBox.Name = "professionComboBox";
            this.professionComboBox.Size = new System.Drawing.Size(265, 21);
            this.professionComboBox.TabIndex = 9;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 138);
            this.Controls.Add(this.controlsTableLayoutPanel);
            this.Controls.Add(this.dataTableLayoutPanel);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.dataTableLayoutPanel.ResumeLayout(false);
            this.dataTableLayoutPanel.PerformLayout();
            this.controlsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel controlsTableLayoutPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label patronomycLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.ComboBox professionComboBox;
    }
}