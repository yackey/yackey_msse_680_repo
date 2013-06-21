namespace SAYQuiltUI
{
    partial class FormCreate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbQuiltName = new System.Windows.Forms.TextBox();
            this.lblQuiltName = new System.Windows.Forms.Label();
            this.tbQuiltDescription = new System.Windows.Forms.TextBox();
            this.lblQuiltDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOrderDescription = new System.Windows.Forms.Label();
            this.tbOrderBeginDate = new System.Windows.Forms.TextBox();
            this.lblOrderBeginDate = new System.Windows.Forms.Label();
            this.tbOrderEndDate = new System.Windows.Forms.TextBox();
            this.lblOrderEndDate = new System.Windows.Forms.Label();
            this.tbRecipientFirstName = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.tbRecipientLastName = new System.Windows.Forms.TextBox();
            this.tbRecipientAddress1 = new System.Windows.Forms.TextBox();
            this.lblRecipientAddress1 = new System.Windows.Forms.Label();
            this.tbRecipientAddress2 = new System.Windows.Forms.TextBox();
            this.tbDesignBlockDesc = new System.Windows.Forms.TextBox();
            this.lblDesignBlockDesc = new System.Windows.Forms.Label();
            this.tbDesignBlockGenesis = new System.Windows.Forms.TextBox();
            this.lblDesignBlockGenesis = new System.Windows.Forms.Label();
            this.btnSubmitCreate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 0;
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
            // tbQuiltName
            // 
            this.tbQuiltName.Location = new System.Drawing.Point(10, 71);
            this.tbQuiltName.Name = "tbQuiltName";
            this.tbQuiltName.Size = new System.Drawing.Size(149, 22);
            this.tbQuiltName.TabIndex = 1;
            // 
            // lblQuiltName
            // 
            this.lblQuiltName.AutoSize = true;
            this.lblQuiltName.Location = new System.Drawing.Point(37, 48);
            this.lblQuiltName.Name = "lblQuiltName";
            this.lblQuiltName.Size = new System.Drawing.Size(78, 17);
            this.lblQuiltName.TabIndex = 2;
            this.lblQuiltName.Text = "Quilt Name";
            // 
            // tbQuiltDescription
            // 
            this.tbQuiltDescription.Location = new System.Drawing.Point(165, 71);
            this.tbQuiltDescription.Name = "tbQuiltDescription";
            this.tbQuiltDescription.Size = new System.Drawing.Size(146, 22);
            this.tbQuiltDescription.TabIndex = 3;
            // 
            // lblQuiltDescription
            // 
            this.lblQuiltDescription.AutoSize = true;
            this.lblQuiltDescription.Location = new System.Drawing.Point(182, 49);
            this.lblQuiltDescription.Name = "lblQuiltDescription";
            this.lblQuiltDescription.Size = new System.Drawing.Size(112, 17);
            this.lblQuiltDescription.TabIndex = 4;
            this.lblQuiltDescription.Text = "Quilt Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Location = new System.Drawing.Point(16, 103);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(120, 17);
            this.lblOrderDescription.TabIndex = 6;
            this.lblOrderDescription.Text = "Order Description";
            // 
            // tbOrderBeginDate
            // 
            this.tbOrderBeginDate.Location = new System.Drawing.Point(165, 121);
            this.tbOrderBeginDate.Name = "tbOrderBeginDate";
            this.tbOrderBeginDate.Size = new System.Drawing.Size(144, 22);
            this.tbOrderBeginDate.TabIndex = 7;
            // 
            // lblOrderBeginDate
            // 
            this.lblOrderBeginDate.AutoSize = true;
            this.lblOrderBeginDate.Location = new System.Drawing.Point(185, 103);
            this.lblOrderBeginDate.Name = "lblOrderBeginDate";
            this.lblOrderBeginDate.Size = new System.Drawing.Size(78, 17);
            this.lblOrderBeginDate.TabIndex = 8;
            this.lblOrderBeginDate.Text = "Begin Date";
            // 
            // tbOrderEndDate
            // 
            this.tbOrderEndDate.Location = new System.Drawing.Point(316, 120);
            this.tbOrderEndDate.Name = "tbOrderEndDate";
            this.tbOrderEndDate.Size = new System.Drawing.Size(139, 22);
            this.tbOrderEndDate.TabIndex = 9;
            // 
            // lblOrderEndDate
            // 
            this.lblOrderEndDate.AutoSize = true;
            this.lblOrderEndDate.Location = new System.Drawing.Point(332, 103);
            this.lblOrderEndDate.Name = "lblOrderEndDate";
            this.lblOrderEndDate.Size = new System.Drawing.Size(67, 17);
            this.lblOrderEndDate.TabIndex = 10;
            this.lblOrderEndDate.Text = "End Date";
            // 
            // tbRecipientFirstName
            // 
            this.tbRecipientFirstName.Location = new System.Drawing.Point(10, 182);
            this.tbRecipientFirstName.Name = "tbRecipientFirstName";
            this.tbRecipientFirstName.Size = new System.Drawing.Size(126, 22);
            this.tbRecipientFirstName.TabIndex = 11;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(14, 162);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(108, 17);
            this.lblRecipient.TabIndex = 12;
            this.lblRecipient.Text = "Recipient Name";
            // 
            // tbRecipientLastName
            // 
            this.tbRecipientLastName.Location = new System.Drawing.Point(147, 181);
            this.tbRecipientLastName.Name = "tbRecipientLastName";
            this.tbRecipientLastName.Size = new System.Drawing.Size(112, 22);
            this.tbRecipientLastName.TabIndex = 13;
            // 
            // tbRecipientAddress1
            // 
            this.tbRecipientAddress1.Location = new System.Drawing.Point(277, 182);
            this.tbRecipientAddress1.Name = "tbRecipientAddress1";
            this.tbRecipientAddress1.Size = new System.Drawing.Size(145, 22);
            this.tbRecipientAddress1.TabIndex = 14;
            // 
            // lblRecipientAddress1
            // 
            this.lblRecipientAddress1.AutoSize = true;
            this.lblRecipientAddress1.Location = new System.Drawing.Point(281, 162);
            this.lblRecipientAddress1.Name = "lblRecipientAddress1";
            this.lblRecipientAddress1.Size = new System.Drawing.Size(60, 17);
            this.lblRecipientAddress1.TabIndex = 15;
            this.lblRecipientAddress1.Text = "Address";
            // 
            // tbRecipientAddress2
            // 
            this.tbRecipientAddress2.Location = new System.Drawing.Point(428, 181);
            this.tbRecipientAddress2.Name = "tbRecipientAddress2";
            this.tbRecipientAddress2.Size = new System.Drawing.Size(141, 22);
            this.tbRecipientAddress2.TabIndex = 16;
            // 
            // tbDesignBlockDesc
            // 
            this.tbDesignBlockDesc.Location = new System.Drawing.Point(10, 254);
            this.tbDesignBlockDesc.Name = "tbDesignBlockDesc";
            this.tbDesignBlockDesc.Size = new System.Drawing.Size(249, 22);
            this.tbDesignBlockDesc.TabIndex = 17;
            // 
            // lblDesignBlockDesc
            // 
            this.lblDesignBlockDesc.AutoSize = true;
            this.lblDesignBlockDesc.Location = new System.Drawing.Point(15, 234);
            this.lblDesignBlockDesc.Name = "lblDesignBlockDesc";
            this.lblDesignBlockDesc.Size = new System.Drawing.Size(165, 17);
            this.lblDesignBlockDesc.TabIndex = 18;
            this.lblDesignBlockDesc.Text = "Design Block Description";
            // 
            // tbDesignBlockGenesis
            // 
            this.tbDesignBlockGenesis.Location = new System.Drawing.Point(284, 253);
            this.tbDesignBlockGenesis.Name = "tbDesignBlockGenesis";
            this.tbDesignBlockGenesis.Size = new System.Drawing.Size(285, 22);
            this.tbDesignBlockGenesis.TabIndex = 19;
            // 
            // lblDesignBlockGenesis
            // 
            this.lblDesignBlockGenesis.AutoSize = true;
            this.lblDesignBlockGenesis.Location = new System.Drawing.Point(297, 234);
            this.lblDesignBlockGenesis.Name = "lblDesignBlockGenesis";
            this.lblDesignBlockGenesis.Size = new System.Drawing.Size(146, 17);
            this.lblDesignBlockGenesis.TabIndex = 20;
            this.lblDesignBlockGenesis.Text = "Design Block Genesis";
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.Location = new System.Drawing.Point(234, 311);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCreate.TabIndex = 21;
            this.btnSubmitCreate.Text = "Submit";
            this.btnSubmitCreate.UseVisualStyleBackColor = true;
            this.btnSubmitCreate.Click += new System.EventHandler(this.btnSubmitCreate_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.btnSubmitCreate);
            this.Controls.Add(this.lblDesignBlockGenesis);
            this.Controls.Add(this.tbDesignBlockGenesis);
            this.Controls.Add(this.lblDesignBlockDesc);
            this.Controls.Add(this.tbDesignBlockDesc);
            this.Controls.Add(this.tbRecipientAddress2);
            this.Controls.Add(this.lblRecipientAddress1);
            this.Controls.Add(this.tbRecipientAddress1);
            this.Controls.Add(this.tbRecipientLastName);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.tbRecipientFirstName);
            this.Controls.Add(this.lblOrderEndDate);
            this.Controls.Add(this.tbOrderEndDate);
            this.Controls.Add(this.lblOrderBeginDate);
            this.Controls.Add(this.tbOrderBeginDate);
            this.Controls.Add(this.lblOrderDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuiltDescription);
            this.Controls.Add(this.tbQuiltDescription);
            this.Controls.Add(this.lblQuiltName);
            this.Controls.Add(this.tbQuiltName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbQuiltName;
        private System.Windows.Forms.Label lblQuiltName;
        private System.Windows.Forms.TextBox tbQuiltDescription;
        private System.Windows.Forms.Label lblQuiltDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOrderDescription;
        private System.Windows.Forms.TextBox tbOrderBeginDate;
        private System.Windows.Forms.Label lblOrderBeginDate;
        private System.Windows.Forms.TextBox tbOrderEndDate;
        private System.Windows.Forms.Label lblOrderEndDate;
        private System.Windows.Forms.TextBox tbRecipientFirstName;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.TextBox tbRecipientLastName;
        private System.Windows.Forms.TextBox tbRecipientAddress1;
        private System.Windows.Forms.Label lblRecipientAddress1;
        private System.Windows.Forms.TextBox tbRecipientAddress2;
        private System.Windows.Forms.TextBox tbDesignBlockDesc;
        private System.Windows.Forms.Label lblDesignBlockDesc;
        private System.Windows.Forms.TextBox tbDesignBlockGenesis;
        private System.Windows.Forms.Label lblDesignBlockGenesis;
        private System.Windows.Forms.Button btnSubmitCreate;
    }
}