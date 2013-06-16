namespace SAYQuiltUI
{
    partial class Form1
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
            this.tbQuiltName = new System.Windows.Forms.TextBox();
            this.lblQuiltNmae = new System.Windows.Forms.Label();
            this.btnGetQuiltInfo = new System.Windows.Forms.Button();
            this.tbOrderStart = new System.Windows.Forms.TextBox();
            this.lblOrderStart = new System.Windows.Forms.Label();
            this.tbOrderEnd = new System.Windows.Forms.TextBox();
            this.lblOrderEnd = new System.Windows.Forms.Label();
            this.tbOrderDescription = new System.Windows.Forms.TextBox();
            this.lblOrderDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbQuiltName
            // 
            this.tbQuiltName.Location = new System.Drawing.Point(64, 87);
            this.tbQuiltName.Name = "tbQuiltName";
            this.tbQuiltName.Size = new System.Drawing.Size(161, 22);
            this.tbQuiltName.TabIndex = 0;
            this.tbQuiltName.Text = "CreateQuiltTest Name";
            // 
            // lblQuiltNmae
            // 
            this.lblQuiltNmae.AutoSize = true;
            this.lblQuiltNmae.Location = new System.Drawing.Point(72, 67);
            this.lblQuiltNmae.Name = "lblQuiltNmae";
            this.lblQuiltNmae.Size = new System.Drawing.Size(74, 17);
            this.lblQuiltNmae.TabIndex = 1;
            this.lblQuiltNmae.Text = "QuiltName";
            // 
            // btnGetQuiltInfo
            // 
            this.btnGetQuiltInfo.Location = new System.Drawing.Point(89, 267);
            this.btnGetQuiltInfo.Name = "btnGetQuiltInfo";
            this.btnGetQuiltInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetQuiltInfo.TabIndex = 2;
            this.btnGetQuiltInfo.Text = "Submit";
            this.btnGetQuiltInfo.UseVisualStyleBackColor = true;
            this.btnGetQuiltInfo.Click += new System.EventHandler(this.btnGetQuiltInfo_Click);
            // 
            // tbOrderStart
            // 
            this.tbOrderStart.Location = new System.Drawing.Point(249, 86);
            this.tbOrderStart.Name = "tbOrderStart";
            this.tbOrderStart.Size = new System.Drawing.Size(100, 22);
            this.tbOrderStart.TabIndex = 3;
            // 
            // lblOrderStart
            // 
            this.lblOrderStart.AutoSize = true;
            this.lblOrderStart.Location = new System.Drawing.Point(264, 66);
            this.lblOrderStart.Name = "lblOrderStart";
            this.lblOrderStart.Size = new System.Drawing.Size(79, 17);
            this.lblOrderStart.TabIndex = 4;
            this.lblOrderStart.Text = "Order Start";
            // 
            // tbOrderEnd
            // 
            this.tbOrderEnd.Location = new System.Drawing.Point(379, 86);
            this.tbOrderEnd.Name = "tbOrderEnd";
            this.tbOrderEnd.Size = new System.Drawing.Size(100, 22);
            this.tbOrderEnd.TabIndex = 5;
            // 
            // lblOrderEnd
            // 
            this.lblOrderEnd.AutoSize = true;
            this.lblOrderEnd.Location = new System.Drawing.Point(393, 66);
            this.lblOrderEnd.Name = "lblOrderEnd";
            this.lblOrderEnd.Size = new System.Drawing.Size(74, 17);
            this.lblOrderEnd.TabIndex = 6;
            this.lblOrderEnd.Text = "Order End";
            // 
            // tbOrderDescription
            // 
            this.tbOrderDescription.Location = new System.Drawing.Point(510, 87);
            this.tbOrderDescription.Name = "tbOrderDescription";
            this.tbOrderDescription.Size = new System.Drawing.Size(214, 22);
            this.tbOrderDescription.TabIndex = 7;
            // 
            // lblOrderDescription
            // 
            this.lblOrderDescription.AutoSize = true;
            this.lblOrderDescription.Location = new System.Drawing.Point(544, 66);
            this.lblOrderDescription.Name = "lblOrderDescription";
            this.lblOrderDescription.Size = new System.Drawing.Size(120, 17);
            this.lblOrderDescription.TabIndex = 8;
            this.lblOrderDescription.Text = "Order Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 413);
            this.Controls.Add(this.lblOrderDescription);
            this.Controls.Add(this.tbOrderDescription);
            this.Controls.Add(this.lblOrderEnd);
            this.Controls.Add(this.tbOrderEnd);
            this.Controls.Add(this.lblOrderStart);
            this.Controls.Add(this.tbOrderStart);
            this.Controls.Add(this.btnGetQuiltInfo);
            this.Controls.Add(this.lblQuiltNmae);
            this.Controls.Add(this.tbQuiltName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuiltName;
        private System.Windows.Forms.Label lblQuiltNmae;
        private System.Windows.Forms.Button btnGetQuiltInfo;
        private System.Windows.Forms.TextBox tbOrderStart;
        private System.Windows.Forms.Label lblOrderStart;
        private System.Windows.Forms.TextBox tbOrderEnd;
        private System.Windows.Forms.Label lblOrderEnd;
        private System.Windows.Forms.TextBox tbOrderDescription;
        private System.Windows.Forms.Label lblOrderDescription;
    }
}

