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
            this.tbOrderDescription = new System.Windows.Forms.TextBox();
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
            this.lvOrderHistory = new System.Windows.Forms.ListView();
            this.gbOrderHistory = new System.Windows.Forms.GroupBox();
            this.btnAddOrderHistory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvAwards = new System.Windows.Forms.ListView();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvBom = new System.Windows.Forms.ListView();
            this.btnAddBom = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbOrderHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 28);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tbQuiltName
            // 
            this.tbQuiltName.Location = new System.Drawing.Point(10, 71);
            this.tbQuiltName.Name = "tbQuiltName";
            this.tbQuiltName.Size = new System.Drawing.Size(149, 22);
            this.tbQuiltName.TabIndex = 1;
            this.tbQuiltName.TextChanged += new System.EventHandler(this.tbQuiltName_TextChanged);
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
            this.tbQuiltDescription.Location = new System.Drawing.Point(10, 118);
            this.tbQuiltDescription.Name = "tbQuiltDescription";
            this.tbQuiltDescription.Size = new System.Drawing.Size(146, 22);
            this.tbQuiltDescription.TabIndex = 3;
            // 
            // lblQuiltDescription
            // 
            this.lblQuiltDescription.AutoSize = true;
            this.lblQuiltDescription.Location = new System.Drawing.Point(27, 96);
            this.lblQuiltDescription.Name = "lblQuiltDescription";
            this.lblQuiltDescription.Size = new System.Drawing.Size(112, 17);
            this.lblQuiltDescription.TabIndex = 4;
            this.lblQuiltDescription.Text = "Quilt Description";
            // 
            // tbOrderDescription
            // 
            this.tbOrderDescription.Location = new System.Drawing.Point(538, 71);
            this.tbOrderDescription.Name = "tbOrderDescription";
            this.tbOrderDescription.Size = new System.Drawing.Size(180, 22);
            this.tbOrderDescription.TabIndex = 5;
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Location = new System.Drawing.Point(542, 52);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(120, 17);
            this.lblOrderDescription.TabIndex = 6;
            this.lblOrderDescription.Text = "Order Description";
            // 
            // tbOrderBeginDate
            // 
            this.tbOrderBeginDate.Location = new System.Drawing.Point(232, 71);
            this.tbOrderBeginDate.Name = "tbOrderBeginDate";
            this.tbOrderBeginDate.Size = new System.Drawing.Size(144, 22);
            this.tbOrderBeginDate.TabIndex = 7;
            // 
            // lblOrderBeginDate
            // 
            this.lblOrderBeginDate.AutoSize = true;
            this.lblOrderBeginDate.Location = new System.Drawing.Point(252, 53);
            this.lblOrderBeginDate.Name = "lblOrderBeginDate";
            this.lblOrderBeginDate.Size = new System.Drawing.Size(79, 17);
            this.lblOrderBeginDate.TabIndex = 8;
            this.lblOrderBeginDate.Text = "Order Start";
            // 
            // tbOrderEndDate
            // 
            this.tbOrderEndDate.Location = new System.Drawing.Point(383, 70);
            this.tbOrderEndDate.Name = "tbOrderEndDate";
            this.tbOrderEndDate.Size = new System.Drawing.Size(139, 22);
            this.tbOrderEndDate.TabIndex = 9;
            // 
            // lblOrderEndDate
            // 
            this.lblOrderEndDate.AutoSize = true;
            this.lblOrderEndDate.Location = new System.Drawing.Point(399, 53);
            this.lblOrderEndDate.Name = "lblOrderEndDate";
            this.lblOrderEndDate.Size = new System.Drawing.Size(74, 17);
            this.lblOrderEndDate.TabIndex = 10;
            this.lblOrderEndDate.Text = "Order End";
            // 
            // tbRecipientFirstName
            // 
            this.tbRecipientFirstName.Location = new System.Drawing.Point(10, 176);
            this.tbRecipientFirstName.Name = "tbRecipientFirstName";
            this.tbRecipientFirstName.Size = new System.Drawing.Size(112, 22);
            this.tbRecipientFirstName.TabIndex = 11;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(14, 156);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(108, 17);
            this.lblRecipient.TabIndex = 12;
            this.lblRecipient.Text = "Recipient Name";
            // 
            // tbRecipientLastName
            // 
            this.tbRecipientLastName.Location = new System.Drawing.Point(128, 175);
            this.tbRecipientLastName.Name = "tbRecipientLastName";
            this.tbRecipientLastName.Size = new System.Drawing.Size(112, 22);
            this.tbRecipientLastName.TabIndex = 13;
            // 
            // tbRecipientAddress1
            // 
            this.tbRecipientAddress1.Location = new System.Drawing.Point(252, 176);
            this.tbRecipientAddress1.Name = "tbRecipientAddress1";
            this.tbRecipientAddress1.Size = new System.Drawing.Size(126, 22);
            this.tbRecipientAddress1.TabIndex = 14;
            // 
            // lblRecipientAddress1
            // 
            this.lblRecipientAddress1.AutoSize = true;
            this.lblRecipientAddress1.Location = new System.Drawing.Point(268, 156);
            this.lblRecipientAddress1.Name = "lblRecipientAddress1";
            this.lblRecipientAddress1.Size = new System.Drawing.Size(60, 17);
            this.lblRecipientAddress1.TabIndex = 15;
            this.lblRecipientAddress1.Text = "Address";
            // 
            // tbRecipientAddress2
            // 
            this.tbRecipientAddress2.Location = new System.Drawing.Point(384, 176);
            this.tbRecipientAddress2.Name = "tbRecipientAddress2";
            this.tbRecipientAddress2.Size = new System.Drawing.Size(117, 22);
            this.tbRecipientAddress2.TabIndex = 16;
            // 
            // tbDesignBlockDesc
            // 
            this.tbDesignBlockDesc.Location = new System.Drawing.Point(10, 239);
            this.tbDesignBlockDesc.Name = "tbDesignBlockDesc";
            this.tbDesignBlockDesc.Size = new System.Drawing.Size(249, 22);
            this.tbDesignBlockDesc.TabIndex = 17;
            // 
            // lblDesignBlockDesc
            // 
            this.lblDesignBlockDesc.AutoSize = true;
            this.lblDesignBlockDesc.Location = new System.Drawing.Point(15, 219);
            this.lblDesignBlockDesc.Name = "lblDesignBlockDesc";
            this.lblDesignBlockDesc.Size = new System.Drawing.Size(165, 17);
            this.lblDesignBlockDesc.TabIndex = 18;
            this.lblDesignBlockDesc.Text = "Design Block Description";
            // 
            // tbDesignBlockGenesis
            // 
            this.tbDesignBlockGenesis.Location = new System.Drawing.Point(271, 239);
            this.tbDesignBlockGenesis.Name = "tbDesignBlockGenesis";
            this.tbDesignBlockGenesis.Size = new System.Drawing.Size(237, 22);
            this.tbDesignBlockGenesis.TabIndex = 19;
            // 
            // lblDesignBlockGenesis
            // 
            this.lblDesignBlockGenesis.AutoSize = true;
            this.lblDesignBlockGenesis.Location = new System.Drawing.Point(273, 219);
            this.lblDesignBlockGenesis.Name = "lblDesignBlockGenesis";
            this.lblDesignBlockGenesis.Size = new System.Drawing.Size(146, 17);
            this.lblDesignBlockGenesis.TabIndex = 20;
            this.lblDesignBlockGenesis.Text = "Design Block Genesis";
            this.lblDesignBlockGenesis.Click += new System.EventHandler(this.lblDesignBlockGenesis_Click);
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.Location = new System.Drawing.Point(447, 457);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCreate.TabIndex = 21;
            this.btnSubmitCreate.Text = "Submit";
            this.btnSubmitCreate.UseVisualStyleBackColor = true;
            this.btnSubmitCreate.Click += new System.EventHandler(this.btnSubmitCreate_Click);
            // 
            // lvOrderHistory
            // 
            this.lvOrderHistory.Location = new System.Drawing.Point(25, 23);
            this.lvOrderHistory.Name = "lvOrderHistory";
            this.lvOrderHistory.Size = new System.Drawing.Size(312, 90);
            this.lvOrderHistory.TabIndex = 55;
            this.lvOrderHistory.UseCompatibleStateImageBehavior = false;
            // 
            // gbOrderHistory
            // 
            this.gbOrderHistory.Controls.Add(this.btnAddOrderHistory);
            this.gbOrderHistory.Controls.Add(this.lvOrderHistory);
            this.gbOrderHistory.Location = new System.Drawing.Point(538, 109);
            this.gbOrderHistory.Name = "gbOrderHistory";
            this.gbOrderHistory.Size = new System.Drawing.Size(355, 151);
            this.gbOrderHistory.TabIndex = 56;
            this.gbOrderHistory.TabStop = false;
            this.gbOrderHistory.Text = "Order History";
            // 
            // btnAddOrderHistory
            // 
            this.btnAddOrderHistory.Location = new System.Drawing.Point(122, 119);
            this.btnAddOrderHistory.Name = "btnAddOrderHistory";
            this.btnAddOrderHistory.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrderHistory.TabIndex = 56;
            this.btnAddOrderHistory.Text = "Add Item";
            this.btnAddOrderHistory.UseVisualStyleBackColor = true;
            this.btnAddOrderHistory.Click += new System.EventHandler(this.btnAddOrderHistory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAward);
            this.groupBox1.Controls.Add(this.lvAwards);
            this.groupBox1.Location = new System.Drawing.Point(538, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 166);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Awards";
            // 
            // lvAwards
            // 
            this.lvAwards.Location = new System.Drawing.Point(25, 21);
            this.lvAwards.Name = "lvAwards";
            this.lvAwards.Size = new System.Drawing.Size(312, 97);
            this.lvAwards.TabIndex = 0;
            this.lvAwards.UseCompatibleStateImageBehavior = false;
            this.lvAwards.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(127, 134);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(75, 23);
            this.btnAddAward.TabIndex = 1;
            this.btnAddAward.Text = "Add Item";
            this.btnAddAward.UseVisualStyleBackColor = true;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBom);
            this.groupBox2.Controls.Add(this.lvBom);
            this.groupBox2.Location = new System.Drawing.Point(66, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 165);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quilt Components";
            // 
            // lvBom
            // 
            this.lvBom.Location = new System.Drawing.Point(19, 27);
            this.lvBom.Name = "lvBom";
            this.lvBom.Size = new System.Drawing.Size(316, 98);
            this.lvBom.TabIndex = 0;
            this.lvBom.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddBom
            // 
            this.btnAddBom.Location = new System.Drawing.Point(165, 133);
            this.btnAddBom.Name = "btnAddBom";
            this.btnAddBom.Size = new System.Drawing.Size(75, 23);
            this.btnAddBom.TabIndex = 1;
            this.btnAddBom.Text = "Add Item";
            this.btnAddBom.UseVisualStyleBackColor = true;
            this.btnAddBom.Click += new System.EventHandler(this.btnAddBom_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.tbOrderDescription);
            this.Controls.Add(this.lblQuiltDescription);
            this.Controls.Add(this.tbQuiltDescription);
            this.Controls.Add(this.lblQuiltName);
            this.Controls.Add(this.tbQuiltName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbOrderHistory);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCreate";
            this.Text = "Create Quilt Project";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbOrderHistory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbOrderDescription;
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
        private System.Windows.Forms.ListView lvOrderHistory;
        private System.Windows.Forms.GroupBox gbOrderHistory;
        private System.Windows.Forms.Button btnAddOrderHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvAwards;
        private System.Windows.Forms.Button btnAddAward;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBom;
        private System.Windows.Forms.ListView lvBom;
    }
}