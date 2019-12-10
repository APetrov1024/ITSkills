namespace ITSkills
{
    partial class SkillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddSkillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteSkillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.skillsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.professionsListBox = new System.Windows.Forms.ListBox();
            this.skillsListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillsSplitContainer)).BeginInit();
            this.skillsSplitContainer.Panel1.SuspendLayout();
            this.skillsSplitContainer.Panel2.SuspendLayout();
            this.skillsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSkillToolStripButton,
            this.DeleteSkillToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddSkillToolStripButton
            // 
            this.AddSkillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddSkillToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddSkillToolStripButton.Image")));
            this.AddSkillToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSkillToolStripButton.Name = "AddSkillToolStripButton";
            this.AddSkillToolStripButton.Size = new System.Drawing.Size(100, 22);
            this.AddSkillToolStripButton.Text = "Добавить навык";
            this.AddSkillToolStripButton.ToolTipText = "Добавить навык в выбранную профессию";
            this.AddSkillToolStripButton.Click += new System.EventHandler(this.AddSkillToolStripButton_Click);
            // 
            // DeleteSkillToolStripButton
            // 
            this.DeleteSkillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteSkillToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSkillToolStripButton.Image")));
            this.DeleteSkillToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSkillToolStripButton.Name = "DeleteSkillToolStripButton";
            this.DeleteSkillToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.DeleteSkillToolStripButton.Text = "Удалить навык";
            this.DeleteSkillToolStripButton.Click += new System.EventHandler(this.DeleteSkillToolStripButton_Click);
            // 
            // skillsSplitContainer
            // 
            this.skillsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.skillsSplitContainer.Name = "skillsSplitContainer";
            // 
            // skillsSplitContainer.Panel1
            // 
            this.skillsSplitContainer.Panel1.Controls.Add(this.professionsListBox);
            // 
            // skillsSplitContainer.Panel2
            // 
            this.skillsSplitContainer.Panel2.Controls.Add(this.skillsListBox);
            this.skillsSplitContainer.Size = new System.Drawing.Size(583, 373);
            this.skillsSplitContainer.SplitterDistance = 171;
            this.skillsSplitContainer.TabIndex = 1;
            // 
            // professionsListBox
            // 
            this.professionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionsListBox.FormattingEnabled = true;
            this.professionsListBox.Location = new System.Drawing.Point(0, 0);
            this.professionsListBox.Name = "professionsListBox";
            this.professionsListBox.Size = new System.Drawing.Size(171, 373);
            this.professionsListBox.TabIndex = 0;
            this.professionsListBox.SelectedIndexChanged += new System.EventHandler(this.professionsListBox_SelectedIndexChanged);
            // 
            // skillsListBox
            // 
            this.skillsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillsListBox.FormattingEnabled = true;
            this.skillsListBox.Location = new System.Drawing.Point(0, 0);
            this.skillsListBox.Name = "skillsListBox";
            this.skillsListBox.Size = new System.Drawing.Size(408, 373);
            this.skillsListBox.TabIndex = 0;
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 398);
            this.Controls.Add(this.skillsSplitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SkillsForm";
            this.Text = "Справочник навыков";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.skillsSplitContainer.Panel1.ResumeLayout(false);
            this.skillsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillsSplitContainer)).EndInit();
            this.skillsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddSkillToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteSkillToolStripButton;
        private System.Windows.Forms.SplitContainer skillsSplitContainer;
        private System.Windows.Forms.ListBox professionsListBox;
        private System.Windows.Forms.ListBox skillsListBox;
    }
}