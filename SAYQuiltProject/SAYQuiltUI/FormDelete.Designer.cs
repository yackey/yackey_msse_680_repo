namespace SAYQuiltUI
{
    partial class FormDelete
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
            this.cbQuiltToDelete = new System.Windows.Forms.ComboBox();
            this.lblQuiltToDelete = new System.Windows.Forms.Label();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbQuiltToDelete
            // 
            this.cbQuiltToDelete.FormattingEnabled = true;
            this.cbQuiltToDelete.Location = new System.Drawing.Point(50, 64);
            this.cbQuiltToDelete.Name = "cbQuiltToDelete";
            this.cbQuiltToDelete.Size = new System.Drawing.Size(176, 24);
            this.cbQuiltToDelete.TabIndex = 0;
            // 
            // lblQuiltToDelete
            // 
            this.lblQuiltToDelete.AutoSize = true;
            this.lblQuiltToDelete.Location = new System.Drawing.Point(75, 44);
            this.lblQuiltToDelete.Name = "lblQuiltToDelete";
            this.lblQuiltToDelete.Size = new System.Drawing.Size(113, 17);
            this.lblQuiltToDelete.TabIndex = 1;
            this.lblQuiltToDelete.Text = "Project to Delete";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(100, 133);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProject.TabIndex = 2;
            this.btnDeleteProject.Text = "Submit";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 229);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.lblQuiltToDelete);
            this.Controls.Add(this.cbQuiltToDelete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDelete";
            this.Text = "Delete Quilt Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuiltToDelete;
        private System.Windows.Forms.Label lblQuiltToDelete;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}