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
            SetupAwards();
            SetupBoms();

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
            iCnt = lvAwards.Items.Count;
            for (int i = 0; i < iCnt; i++)
            {
                ListViewItem lvi1 = lvAwards.Items[i];
                ListViewItem.ListViewSubItem si1 = lvi1.SubItems[0];
                string sAwardingBody = si1.Text;
                ListViewItem.ListViewSubItem si2 = lvi1.SubItems[1];
                string sDate = si2.Text;
                ListViewItem.ListViewSubItem si3 = lvi1.SubItems[2];
                string sDescription = si3.Text;
                var aw = new Award()
                {
                    AwardingBody = sAwardingBody,
                    DateOfAward = sDate,
                    Description = sDescription
                };
                listAwards.Add(aw);
            }
            // end of awards

            // bom
            List<BOM> listBom = new List<BOM>();
            iCnt = lvBom.Items.Count;
            for (int i = 0; i < iCnt; i++)
            {
                ListViewItem lvi1 = lvBom.Items[i];
                ListViewItem.ListViewSubItem si1 = lvi1.SubItems[0];
                string sTypeOfItem = si1.Text;
                ListViewItem.ListViewSubItem si2 = lvi1.SubItems[1];
                string sCount = si2.Text;
                ListViewItem.ListViewSubItem si3 = lvi1.SubItems[2];
                string sDescription = si3.Text;
                var bom = new BOM()
                {
                    TypeOfItem = sTypeOfItem,
                    Count = sCount,
                    Description = sDescription
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

        public void NotifyAward(PopupInfoAwards popupInfo)
        {
            // use the popupInfo that was passed back
            ListViewItem listviewitem;

            // Ensure that the view is set to show details.
            lvAwards.View = View.Details;

            listviewitem = new ListViewItem(popupInfo.sAwardingBody);
            listviewitem.SubItems.Add(popupInfo.sDate);
            listviewitem.SubItems.Add(popupInfo.sDescription);
            lvAwards.Items.Add(listviewitem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupAwards()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            lvAwards.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Awarding Body";
            lvAwards.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Date";
            lvAwards.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Description";
            lvAwards.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in lvAwards.Columns)
            {
                ch.Width = -2;
            }
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            PopupAward popup = new PopupAward(this);
            popup.Show();
        }

        private void SetupBoms()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            lvBom.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Type of Item";
            lvBom.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Count";
            lvBom.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Description";
            lvBom.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in lvBom.Columns)
            {
                ch.Width = -2;
            }
        }
        private void btnAddBom_Click(object sender, EventArgs e)
        {
            PopupBom popup = new PopupBom(this);
            popup.Show();
        }

        public void NotifyBom(PopupInfoBom popupInfo)
        {
            // use the popupInfo that was passed back
            ListViewItem listviewitem;

            // Ensure that the view is set to show details.
            lvBom.View = View.Details;

            listviewitem = new ListViewItem(popupInfo.sType);
            listviewitem.SubItems.Add(popupInfo.sCount);
            listviewitem.SubItems.Add(popupInfo.sDescription);
            lvBom.Items.Add(listviewitem);
        }
    }
}
