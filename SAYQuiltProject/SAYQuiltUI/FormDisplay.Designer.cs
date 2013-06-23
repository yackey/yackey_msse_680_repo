namespace SAYQuiltUI
{
    partial class FormDisplay
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDesignBlockGenesis = new System.Windows.Forms.TextBox();
            this.tbDesignBlockDesc = new System.Windows.Forms.TextBox();
            this.lblDesignBlock = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbRecipientAddr2 = new System.Windows.Forms.TextBox();
            this.tbRecipientAddr1 = new System.Windows.Forms.TextBox();
            this.tbRecipientLastName = new System.Windows.Forms.TextBox();
            this.tbRecipientFirstName = new System.Windows.Forms.TextBox();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecipientNameFirst = new System.Windows.Forms.Label();
            this.lblOrderDescription = new System.Windows.Forms.Label();
            this.tbOrderDescription = new System.Windows.Forms.TextBox();
            this.lblOrderEnd = new System.Windows.Forms.Label();
            this.tbOrderEnd = new System.Windows.Forms.TextBox();
            this.lblOrderStart = new System.Windows.Forms.Label();
            this.tbOrderStart = new System.Windows.Forms.TextBox();
            this.btnGetQuiltInfo = new System.Windows.Forms.Button();
            this.lblQuiltNmae = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbQuiltNames = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblOrderHistory = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lblAwards = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.lbl2BOMs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tbDesignBlockGenesis
            // 
            this.tbDesignBlockGenesis.Location = new System.Drawing.Point(151, 201);
            this.tbDesignBlockGenesis.Name = "tbDesignBlockGenesis";
            this.tbDesignBlockGenesis.Size = new System.Drawing.Size(183, 22);
            this.tbDesignBlockGenesis.TabIndex = 55;
            // 
            // tbDesignBlockDesc
            // 
            this.tbDesignBlockDesc.Location = new System.Drawing.Point(14, 201);
            this.tbDesignBlockDesc.Name = "tbDesignBlockDesc";
            this.tbDesignBlockDesc.Size = new System.Drawing.Size(120, 22);
            this.tbDesignBlockDesc.TabIndex = 54;
            this.tbDesignBlockDesc.TextChanged += new System.EventHandler(this.tbDesignBlockDesc_TextChanged);
            // 
            // lblDesignBlock
            // 
            this.lblDesignBlock.AutoSize = true;
            this.lblDesignBlock.Location = new System.Drawing.Point(22, 181);
            this.lblDesignBlock.Name = "lblDesignBlock";
            this.lblDesignBlock.Size = new System.Drawing.Size(90, 17);
            this.lblDesignBlock.TabIndex = 53;
            this.lblDesignBlock.Text = "Design Block";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(253, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Address";
            // 
            // tbRecipientAddr2
            // 
            this.tbRecipientAddr2.Location = new System.Drawing.Point(353, 136);
            this.tbRecipientAddr2.Name = "tbRecipientAddr2";
            this.tbRecipientAddr2.Size = new System.Drawing.Size(100, 22);
            this.tbRecipientAddr2.TabIndex = 51;
            // 
            // tbRecipientAddr1
            // 
            this.tbRecipientAddr1.Location = new System.Drawing.Point(242, 136);
            this.tbRecipientAddr1.Name = "tbRecipientAddr1";
            this.tbRecipientAddr1.Size = new System.Drawing.Size(100, 22);
            this.tbRecipientAddr1.TabIndex = 50;
            // 
            // tbRecipientLastName
            // 
            this.tbRecipientLastName.Location = new System.Drawing.Point(120, 136);
            this.tbRecipientLastName.Name = "tbRecipientLastName";
            this.tbRecipientLastName.Size = new System.Drawing.Size(100, 22);
            this.tbRecipientLastName.TabIndex = 49;
            // 
            // tbRecipientFirstName
            // 
            this.tbRecipientFirstName.Location = new System.Drawing.Point(14, 136);
            this.tbRecipientFirstName.Name = "tbRecipientFirstName";
            this.tbRecipientFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbRecipientFirstName.TabIndex = 48;
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.projectsToolStripMenuItem.Text = "Actions";
            // 
            // lblRecipientNameFirst
            // 
            this.lblRecipientNameFirst.AutoSize = true;
            this.lblRecipientNameFirst.Location = new System.Drawing.Point(17, 116);
            this.lblRecipientNameFirst.Name = "lblRecipientNameFirst";
            this.lblRecipientNameFirst.Size = new System.Drawing.Size(108, 17);
            this.lblRecipientNameFirst.TabIndex = 47;
            this.lblRecipientNameFirst.Text = "Recipient Name";
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Location = new System.Drawing.Point(589, 47);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(120, 17);
            this.lblOrderDescription.TabIndex = 40;
            this.lblOrderDescription.Text = "Order Description";
            // 
            // tbOrderDescription
            // 
            this.tbOrderDescription.Location = new System.Drawing.Point(555, 68);
            this.tbOrderDescription.Name = "tbOrderDescription";
            this.tbOrderDescription.Size = new System.Drawing.Size(214, 22);
            this.tbOrderDescription.TabIndex = 39;
            // 
            // lblOrderEnd
            // 
            this.lblOrderEnd.AutoSize = true;
            this.lblOrderEnd.Location = new System.Drawing.Point(438, 47);
            this.lblOrderEnd.Name = "lblOrderEnd";
            this.lblOrderEnd.Size = new System.Drawing.Size(74, 17);
            this.lblOrderEnd.TabIndex = 38;
            this.lblOrderEnd.Text = "Order End";
            // 
            // tbOrderEnd
            // 
            this.tbOrderEnd.Location = new System.Drawing.Point(424, 67);
            this.tbOrderEnd.Name = "tbOrderEnd";
            this.tbOrderEnd.Size = new System.Drawing.Size(100, 22);
            this.tbOrderEnd.TabIndex = 37;
            // 
            // lblOrderStart
            // 
            this.lblOrderStart.AutoSize = true;
            this.lblOrderStart.Location = new System.Drawing.Point(309, 47);
            this.lblOrderStart.Name = "lblOrderStart";
            this.lblOrderStart.Size = new System.Drawing.Size(79, 17);
            this.lblOrderStart.TabIndex = 36;
            this.lblOrderStart.Text = "Order Start";
            // 
            // tbOrderStart
            // 
            this.tbOrderStart.Location = new System.Drawing.Point(294, 67);
            this.tbOrderStart.Name = "tbOrderStart";
            this.tbOrderStart.Size = new System.Drawing.Size(100, 22);
            this.tbOrderStart.TabIndex = 35;
            // 
            // btnGetQuiltInfo
            // 
            this.btnGetQuiltInfo.Location = new System.Drawing.Point(341, 415);
            this.btnGetQuiltInfo.Name = "btnGetQuiltInfo";
            this.btnGetQuiltInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetQuiltInfo.TabIndex = 34;
            this.btnGetQuiltInfo.Text = "Submit";
            this.btnGetQuiltInfo.UseVisualStyleBackColor = true;
            this.btnGetQuiltInfo.Click += new System.EventHandler(this.btnGetQuiltInfo_Click_1);
            // 
            // lblQuiltNmae
            // 
            this.lblQuiltNmae.AutoSize = true;
            this.lblQuiltNmae.Location = new System.Drawing.Point(22, 46);
            this.lblQuiltNmae.Name = "lblQuiltNmae";
            this.lblQuiltNmae.Size = new System.Drawing.Size(74, 17);
            this.lblQuiltNmae.TabIndex = 33;
            this.lblQuiltNmae.Text = "QuiltName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 28);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cbQuiltNames
            // 
            this.cbQuiltNames.FormattingEnabled = true;
            this.cbQuiltNames.Location = new System.Drawing.Point(14, 66);
            this.cbQuiltNames.Name = "cbQuiltNames";
            this.cbQuiltNames.Size = new System.Drawing.Size(206, 24);
            this.cbQuiltNames.TabIndex = 61;
            this.cbQuiltNames.SelectedIndexChanged += new System.EventHandler(this.cbQuiltNames_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(507, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(262, 97);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblOrderHistory
            // 
            this.lblOrderHistory.AutoSize = true;
            this.lblOrderHistory.Location = new System.Drawing.Point(610, 106);
            this.lblOrderHistory.Name = "lblOrderHistory";
            this.lblOrderHistory.Size = new System.Drawing.Size(93, 17);
            this.lblOrderHistory.TabIndex = 63;
            this.lblOrderHistory.Text = "Order History";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(449, 275);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(320, 97);
            this.listView2.TabIndex = 64;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lblAwards
            // 
            this.lblAwards.AutoSize = true;
            this.lblAwards.Location = new System.Drawing.Point(528, 255);
            this.lblAwards.Name = "lblAwards";
            this.lblAwards.Size = new System.Drawing.Size(54, 17);
            this.lblAwards.TabIndex = 65;
            this.lblAwards.Text = "Awards";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(12, 275);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(320, 97);
            this.listView3.TabIndex = 66;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // lbl2BOMs
            // 
            this.lbl2BOMs.AutoSize = true;
            this.lbl2BOMs.Location = new System.Drawing.Point(53, 255);
            this.lbl2BOMs.Name = "lbl2BOMs";
            this.lbl2BOMs.Size = new System.Drawing.Size(87, 17);
            this.lbl2BOMs.TabIndex = 67;
            this.lbl2BOMs.Text = "Components";
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.lbl2BOMs);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.lblAwards);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lblOrderHistory);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbQuiltNames);
            this.Controls.Add(this.tbDesignBlockGenesis);
            this.Controls.Add(this.tbDesignBlockDesc);
            this.Controls.Add(this.lblDesignBlock);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbRecipientAddr2);
            this.Controls.Add(this.tbRecipientAddr1);
            this.Controls.Add(this.tbRecipientLastName);
            this.Controls.Add(this.tbRecipientFirstName);
            this.Controls.Add(this.lblRecipientNameFirst);
            this.Controls.Add(this.lblOrderDescription);
            this.Controls.Add(this.tbOrderDescription);
            this.Controls.Add(this.lblOrderEnd);
            this.Controls.Add(this.tbOrderEnd);
            this.Controls.Add(this.lblOrderStart);
            this.Controls.Add(this.tbOrderStart);
            this.Controls.Add(this.btnGetQuiltInfo);
            this.Controls.Add(this.lblQuiltNmae);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormDisplay";
            this.Text = "Display Quilt Project Information";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbDesignBlockGenesis;
        private System.Windows.Forms.TextBox tbDesignBlockDesc;
        private System.Windows.Forms.Label lblDesignBlock;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbRecipientAddr2;
        private System.Windows.Forms.TextBox tbRecipientAddr1;
        private System.Windows.Forms.TextBox tbRecipientLastName;
        private System.Windows.Forms.TextBox tbRecipientFirstName;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.Label lblRecipientNameFirst;
        private System.Windows.Forms.Label lblOrderDescription;
        private System.Windows.Forms.TextBox tbOrderDescription;
        private System.Windows.Forms.Label lblOrderEnd;
        private System.Windows.Forms.TextBox tbOrderEnd;
        private System.Windows.Forms.Label lblOrderStart;
        private System.Windows.Forms.TextBox tbOrderStart;
        private System.Windows.Forms.Button btnGetQuiltInfo;
        private System.Windows.Forms.Label lblQuiltNmae;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbQuiltNames;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblOrderHistory;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label lblAwards;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label lbl2BOMs;
    }
}