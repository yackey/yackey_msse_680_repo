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
    public partial class Form1 : Form
    {
        private bool bIsDbSetup = false;
        private COrderManager om = null;
        private CSimpleQuiltManager qm = null;

        public Form1()
        {
            InitializeComponent();
            COrderManager om = new COrderManager();
            CSimpleQuiltManager qm = new CSimpleQuiltManager();
            if (bIsDbSetup == false)
            {
                om.SetupDb(false);
                bIsDbSetup = true;
            }
            // quilts
            IEnumerable<Quilt> quiltEnum = qm.GetQuilts();
            List<Quilt> quiltList = quiltEnum.ToList();
            if (quiltList.Count > 0)
            {
                Quilt qFirst = quiltList.First();
                tbQuiltName.Text = qFirst.Name;
            }
        }

        private void SetQuiltProjectNames()
        {
            
        }
        private void btnGetQuiltInfo_Click(object sender, EventArgs e)
        {

            COrderManager om = new COrderManager();
            CSimpleQuiltManager qm = new CSimpleQuiltManager();

            if (bIsDbSetup == false)
            {
                om.SetupDb(false);
                bIsDbSetup = true;
            }

#if OLDWAY
            // quilts
            IEnumerable<Quilt> quiltEnum = qm.GetQuilts();
            List<Quilt> quiltList = quiltEnum.ToList();
            if (quiltList.Count > 0)
            {
                Quilt qFirst = quiltList.First();
                tbQuiltName.Text = qFirst.Name;
            }
#endif

            // the above needs to populate a combo box
            Quilt q = new Quilt();
            q.Name = tbQuiltName.Text;

            // order
            Order orderFromQuilt = om.GetOrderFromQuilt(q);
            tbOrderStart.Text = orderFromQuilt.StartDate;
            tbOrderEnd.Text = orderFromQuilt.EndDate;
            tbOrderDescription.Text = orderFromQuilt.Description;

            // we'll need this
            int orderId = orderFromQuilt.OrderId;
            int quiltId = om.GetQuiltIdFromQuiltName(tbQuiltName.Text);

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
    }
}
