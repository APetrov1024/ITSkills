namespace ITSkills
{
    partial class EmployeesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesListForm));
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addEmployeeStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteEmployeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesGrid.Location = new System.Drawing.Point(0, 0);
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.Size = new System.Drawing.Size(624, 392);
            this.EmployeesGrid.TabIndex = 0;
            this.EmployeesGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EmployeesGrid_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.CatalogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RefreshToolStripMenuItem.Text = "Обновить";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CatalogsToolStripMenuItem
            // 
            this.CatalogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkillsToolStripMenuItem,
            this.ProfessionsToolStripMenuItem});
            this.CatalogsToolStripMenuItem.Name = "CatalogsToolStripMenuItem";
            this.CatalogsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.CatalogsToolStripMenuItem.Text = "Справочники";
            // 
            // SkillsToolStripMenuItem
            // 
            this.SkillsToolStripMenuItem.Name = "SkillsToolStripMenuItem";
            this.SkillsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.SkillsToolStripMenuItem.Text = "Навыки";
            this.SkillsToolStripMenuItem.Click += new System.EventHandler(this.SkillsToolStripMenuItem_Click);
            // 
            // ProfessionsToolStripMenuItem
            // 
            this.ProfessionsToolStripMenuItem.Name = "ProfessionsToolStripMenuItem";
            this.ProfessionsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ProfessionsToolStripMenuItem.Text = "Профессии";
            this.ProfessionsToolStripMenuItem.Click += new System.EventHandler(this.ProfessionsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeStripButton,
            this.deleteEmployeeToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addEmployeeStripButton
            // 
            this.addEmployeeStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEmployeeStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addEmployeeStripButton.Image")));
            this.addEmployeeStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmployeeStripButton.Name = "addEmployeeStripButton";
            this.addEmployeeStripButton.Size = new System.Drawing.Size(129, 22);
            this.addEmployeeStripButton.Text = "Добавить сотрудника";
            this.addEmployeeStripButton.Click += new System.EventHandler(this.addEmployeeStripButton_Click);
            // 
            // deleteEmployeeToolStripButton
            // 
            this.deleteEmployeeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteEmployeeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployeeToolStripButton.Image")));
            this.deleteEmployeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteEmployeeToolStripButton.Name = "deleteEmployeeToolStripButton";
            this.deleteEmployeeToolStripButton.Size = new System.Drawing.Size(121, 22);
            this.deleteEmployeeToolStripButton.Text = "Удалить сотрудника";
            this.deleteEmployeeToolStripButton.Click += new System.EventHandler(this.deleteEmployeeToolStripButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.EmployeesGrid);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 49);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(624, 392);
            this.dataPanel.TabIndex = 3;
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "EmployeesListForm";
            this.Text = "ITSkills";
            this.Shown += new System.EventHandler(this.EmployeesListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addEmployeeStripButton;
        private System.Windows.Forms.ToolStripButton deleteEmployeeToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CatalogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessionsToolStripMenuItem;
        private System.Windows.Forms.Panel dataPanel;
    }
}

