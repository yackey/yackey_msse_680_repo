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
    public partial class FormDisplay : Form
    {
        private Form1 f1 = null;
        private bool _bIsDbSetup = false;

        public FormDisplay(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            this.MdiParent = parent;

            COrderManager om = new COrderManager();
            CSimpleQuiltManager qm = new CSimpleQuiltManager();
            if (_bIsDbSetup == false)
            {
                om.SetupDb(false);
                _bIsDbSetup = true;
            }
            // quilts
            IEnumerable<Quilt> quiltEnum = qm.GetQuilts();
            List<Quilt> quiltList = quiltEnum.ToList();
            foreach (var item in quiltList)
            {
                cbQuiltNames.Items.Add(item.Name);
            }
        }

        private void btnGetQuiltInfo_Click_1(object sender, EventArgs e)
        {
            COrderManager om = new COrderManager();
            CSimpleQuiltManager qm = new CSimpleQuiltManager();

            if (_bIsDbSetup == false)
            {
                om.SetupDb(false);
                _bIsDbSetup = true;
            }

            // the above needs to populate a combo box
            int comboIdx = cbQuiltNames.SelectedIndex;
            if (comboIdx == -1)
            {
                MessageBox.Show("You must pick a quilt name.");
                f1.SetIsChildRunning(false);
                return;
            }

            String sQuiltName = (String)cbQuiltNames.SelectedItem;
            if (sQuiltName.Length == 0)
            {
                MessageBox.Show("You must pick a quilt name.");
                f1.SetIsChildRunning(false);
                this.Dispose(true);
            }

            Quilt q = new Quilt();
            q.Name = sQuiltName;

            // order
            Order orderFromQuilt = om.GetOrderFromQuilt(q);
            tbOrderStart.Text = orderFromQuilt.StartDate;
            tbOrderEnd.Text = orderFromQuilt.EndDate;
            tbOrderDescription.Text = orderFromQuilt.Description;

            // we'll need this
            int orderId = orderFromQuilt.OrderId;
            int quiltId = om.GetQuiltIdFromQuiltName(sQuiltName);

            // histories
            IEnumerable<OrderHistory> enumOrderHistory = om.GetOrderHistory(orderId);
            List<OrderHistory> listOrderHistory = enumOrderHistory.ToList();
            if (listOrderHistory.Count > 0)
            {
                OrderHistory oh = listOrderHistory.Last();
                tbPhase.Text = oh.Phase;
                tbPhaseComments.Text = oh.Comments;
                tbPhaseStart.Text = oh.BeginDate;
            }

            // recipient
            Recipient r = om.GetOrderRecipient(orderId);
            tbRecipientAddr1.Text = r.Address1;
            tbRecipientAddr2.Text = r.Address2;
            tbRecipientFirstName.Text = r.FirstName;
            tbRecipientLastName.Text = r.LastName;

            // design block
            DesignBlock blk = om.GetDesignBlock(quiltId);
            tbDesignBlockDesc.Text = blk.Description;
            tbDesignBlockGenesis.Text = blk.Genesis;

            // awards
            // histories
            IEnumerable<Award> enumAwards = om.GetAwards(quiltId);
            List<Award> listAwards = enumAwards.ToList();
            if (listAwards.Count > 0)
            {
                Award a = listAwards.Last();
                tbAwardBody.Text = a.AwardingBody;
                tbAwardDate.Text = a.DateOfAward;
                tbAwardDesc.Text = a.Description;
            }
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.SetIsChildRunning(false);
            this.Dispose(true);
        }

        private void cbQuiltNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool bSelected = true;
        }
    }
}
