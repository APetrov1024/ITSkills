namespace ITSkills
{
    partial class ProfessionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessionsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addProfessionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.professionsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfessionToolStripButton,
            this.deleteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addProfessionToolStripButton
            // 
            this.addProfessionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addProfessionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addProfessionToolStripButton.Image")));
            this.addProfessionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProfessionToolStripButton.Name = "addProfessionToolStripButton";
            this.addProfessionToolStripButton.Size = new System.Drawing.Size(131, 22);
            this.addProfessionToolStripButton.Text = "Добавить профессию";
            this.addProfessionToolStripButton.Click += new System.EventHandler(this.addProfessionToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripButton.Text = "Удалить профессию";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // professionsListBox
            // 
            this.professionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professionsListBox.FormattingEnabled = true;
            this.professionsListBox.Location = new System.Drawing.Point(0, 0);
            this.professionsListBox.Name = "professionsListBox";
            this.professionsListBox.Size = new System.Drawing.Size(284, 336);
            this.professionsListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.professionsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 336);
            this.panel1.TabIndex = 2;
            // 
            // ProfessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "ProfessionsForm";
            this.Text = "Справочник профессий";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addProfessionToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ListBox professionsListBox;
        private System.Windows.Forms.Panel panel1;
    }
}