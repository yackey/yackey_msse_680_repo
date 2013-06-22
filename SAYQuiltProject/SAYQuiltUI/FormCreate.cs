using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAYQuiltProject;
using SAYQuiltProject.business;

namespace SAYQuiltUI
{
    public partial class FormCreate : Form
    {
        private Form1 f1 = null;

        public FormCreate(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            this.MdiParent = parent;
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.SetIsChildRunning(false);
            this.Dispose(true);
        }

        private void btnSubmitCreate_Click(object sender, EventArgs e)
        {
            bool bRet = CheckRequiredFields();
            if (bRet == false)
            {
                MessageBox.Show("You did not enter all information.");
                return;
            }
            bRet = CreateProject();
        }

        private bool CreateProject()
        {
            var order = new Order 
            { 
                Description = tbOrderDescription.Text, 
                StartDate = tbOrderBeginDate.Text, 
                EndDate = tbOrderEndDate.Text 
            };

            var quilt = new Quilt
                {
                    Name = tbQuiltName.Text, 
                    Description = tbQuiltDescription.Text
                };

            var recipient = new Recipient
                {
                    FirstName = tbRecipientFirstName.Text, 
                    LastName = tbRecipientLastName.Text, 
                    Address1 = tbRecipientAddress1.Text, 
                    Address2 = tbRecipientAddress2.Text, 
                    Type = "Individual"
                };

            var dblock = new DesignBlock
                {
                    Genesis = tbDesignBlockGenesis.Text, 
                    Description = tbDesignBlockDesc.Text
                };

            COrderManager om = new COrderManager();
            bool bRet = om.CreateQuiltOrder(order, quilt, recipient, dblock);
            if (bRet == true)
            {
                MessageBox.Show("That Worked !!");                
            }
            else
            {
                MessageBox.Show("That Failed !!");
            }

            return bRet;
        }

        private bool CheckRequiredFields()
        {
            return true;
        }

        private void tbQuiltName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
