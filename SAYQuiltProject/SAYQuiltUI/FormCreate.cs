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
        private string sValidationComments;
        private List<Quilt> quiltList;

        public FormCreate(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            this.MdiParent = parent;
            SetupOrderHistory();

            COrderManager om = new COrderManager();
            CSimpleQuiltManager qm = new CSimpleQuiltManager();
            // quilts
            IEnumerable<Quilt> quiltEnum = qm.GetQuilts();
            quiltList = quiltEnum.ToList();

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
                MessageBox.Show(sValidationComments);
                return;
            }
            bRet = CreateProject();
            if (bRet == true)
            {
                MessageBox.Show("That Worked !!");
            }
            else
            {
                MessageBox.Show("That Failed !!");
            }
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

            // Order History
            // Is there no editable collection  control - ugh
            List<OrderHistory> listOrderHistory = new List<OrderHistory>();
            int iCnt = lvOrderHistory.Items.Count;
            for (int i = 0; i < iCnt; i++)
            {
                ListViewItem lvi1 = lvOrderHistory.Items[i];
                ListViewItem.ListViewSubItem si1 = lvi1.SubItems[0];
                string sPhase = si1.Text;
                ListViewItem.ListViewSubItem si2 = lvi1.SubItems[1];
                string sBeginDate = si2.Text;
                ListViewItem.ListViewSubItem si3 = lvi1.SubItems[2];
                string sEndDate = si3.Text;
                var oh = new OrderHistory
                {
                    BeginDate = sBeginDate,
                    EndDate = sEndDate,
                    Phase = sPhase,
                    Comments = ""
                };
                listOrderHistory.Add(oh);
            }
            // end order history

            // Awards
            List<Award> listAwards = new List<Award>();
            if ((tbAwardBody1.Text.Length != 0) && (tbAwardDate1.Text.Length != 0) &&
                (tbAwardDescription1.Text.Length != 0))
            {
                var aw = new Award
                {
                    AwardingBody = tbAwardBody1.Text,
                    DateOfAward = tbAwardDate1.Text,
                    Description = tbAwardDescription1.Text
                };
                listAwards.Add(aw);
            }

            if ((tbAwardBody2.Text.Length != 0) && (tbAwardDate2.Text.Length != 0) &&
                (tbAwardDescription2.Text.Length != 0))
            {
                var aw = new Award
                {
                    AwardingBody = tbAwardBody2.Text,
                    DateOfAward = tbAwardDate2.Text,
                    Description = tbAwardDescription2.Text
                };
                listAwards.Add(aw);
            }
            // end of awards

            // bom
            List<BOM> listBom = new List<BOM>();
            if ((tbBomCount1.Text.Length != 0) && (tbBomDescription1.Text.Length != 0) &&
                (tbBomType1.Text.Length != 0))
            {
                var bom = new BOM
                {
                    Count = tbBomCount1.Text,
                    Description = tbBomDescription1.Text,
                    TypeOfItem = tbBomType1.Text
                };
                listBom.Add(bom);
            }

            if ((tbBomCount2.Text.Length != 0) && (tbBomDescription2.Text.Length != 0) &&
                (tbBomType2.Text.Length != 0))
            {
                var bom = new BOM
                {
                    Count = tbBomCount2.Text,
                    Description = tbBomDescription2.Text,
                    TypeOfItem = tbBomType2.Text
                };
                listBom.Add(bom);
            }

            //
            //
            COrderManager om = new COrderManager();
            bool bRet = om.CreateQuiltOrder(order, quilt, recipient, dblock, listOrderHistory, listAwards, listBom);
            return bRet;
        }

        private bool CheckRequiredFields()
        {
            string sLowerTextBox = tbQuiltName.Text.ToLower();
            foreach (var item in quiltList)
            {
                string sLowerListItem = item.Name.ToLower();
                int iCmp = sLowerListItem.CompareTo(sLowerTextBox);
                if (iCmp == 0)
                {
                    sValidationComments = "Quilt name already taken";
                    return false;
                }
            }

            if ((tbQuiltName.Text.Length == 0) || (tbQuiltDescription.Text.Length == 0))
            {
                sValidationComments = "Quilt items must be provided";
                return false;
            }

            if ((tbRecipientFirstName.Text.Length == 0) || (tbRecipientLastName.Text.Length == 0) || 
                (tbRecipientAddress1.Text.Length == 0) || (tbRecipientAddress2.Text.Length == 0))
            {
                sValidationComments = "Recipient items must be provided";
                return false;
            }

            if ((tbOrderBeginDate.Text.Length == 0) || (tbOrderDescription.Text.Length == 0) ||(tbOrderEndDate.Text.Length == 0))
            {
                sValidationComments = "Order items must be provided";
                return false;
            }

            if ((tbDesignBlockDesc.Text.Length == 0) || (tbDesignBlockGenesis.Text.Length == 0))
            {
                sValidationComments = "Design Block items must be provided";
                return false;
            }

            return true;
        }

        private void tbQuiltName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesignBlockGenesis_Click(object sender, EventArgs e)
        {

        }

        private void lvComponents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAwardBody_Click(object sender, EventArgs e)
        {

        }

        private void lblAwardDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderHistory_Click(object sender, EventArgs e)
        {

        }

        private void SetupOrderHistory()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            lvOrderHistory.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Phase";
            lvOrderHistory.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Start Date";
            lvOrderHistory.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "End Date";
            lvOrderHistory.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in lvOrderHistory.Columns)
            {
                ch.Width = -2;
            }
        }

        private void btnAddOrderHistory_Click(object sender, EventArgs e)
        {
            PopupOrderHistory popup = new PopupOrderHistory(this);
            popup.Show();
        }

        public void Notify(PopupInfoOrderHistory popupInfo)
        {
            // use the popupInfo that was passed back
            ListViewItem listviewitem;

            // Ensure that the view is set to show details.
            lvOrderHistory.View = View.Details;

            listviewitem = new ListViewItem(popupInfo.sPhase);
            listviewitem.SubItems.Add(popupInfo.sBeginDate);
            listviewitem.SubItems.Add(popupInfo.sEndDate);
            lvOrderHistory.Items.Add(listviewitem);
        }
    }
}
