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
            SetupOrderHistory();
            SetupAwards();
            SetupBoms();
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
            AddItemsToOrderHistory(listOrderHistory);

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

            // boms
            IEnumerable<BOM> enumBoms = om.GetBOM(quiltId);
            List<BOM> listBoms = enumBoms.ToList();
            AddItemsToBoms(listBoms);

            // awards
            IEnumerable<Award> enumAwards = om.GetAwards(quiltId);
            List<Award> listAwards = enumAwards.ToList();
            AddItemsToAwards(listAwards);
        }

        private void AddItemsToOrderHistory(List<OrderHistory> listOrderHistory)
        {
            foreach (var item in listOrderHistory)
            {
                ListViewItem listviewitem = new ListViewItem(item.Phase);
                listviewitem.SubItems.Add(item.BeginDate);
                listviewitem.SubItems.Add(item.EndDate);
                this.listView1.Items.Add(listviewitem);
            }
        }

        private void SetupOrderHistory()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            listView1.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Phase";
            this.listView1.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Start Date";
            this.listView1.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "End Date";
            this.listView1.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.listView1.Columns)
            {
                ch.Width = -2;
            }
        }

        private void AddItemsToAwards(List<Award> listAward)
        {
            foreach (var item in listAward)
            {
                ListViewItem listviewitem = new ListViewItem(item.AwardingBody);
                listviewitem.SubItems.Add(item.DateOfAward);
                listviewitem.SubItems.Add(item.Description);
                this.listView2.Items.Add(listviewitem);
            }
        }

        private void SetupAwards()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            listView2.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Awarding Body";
            this.listView2.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Date";
            this.listView2.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Description";
            this.listView2.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.listView2.Columns)
            {
                ch.Width = -2;
            }
        }

        private void AddItemsToBoms(List<BOM> listBOM)
        {
            foreach (var item in listBOM)
            {
                ListViewItem listviewitem = new ListViewItem(item.TypeOfItem);
                listviewitem.SubItems.Add(item.Count);
                listviewitem.SubItems.Add(item.Description);
                this.listView3.Items.Add(listviewitem);
            }
        }

        private void SetupBoms()
        {
            ColumnHeader columnheader;		// Used for creating column headers.

            // Ensure that the view is set to show details.
            listView3.View = View.Details;

            // Create some column headers for the data. 
            columnheader = new ColumnHeader();
            columnheader.Text = "Type of Item";
            this.listView3.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Count";
            this.listView3.Columns.Add(columnheader);

            columnheader = new ColumnHeader();
            columnheader.Text = "Description";
            this.listView3.Columns.Add(columnheader);

            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in this.listView3.Columns)
            {
                ch.Width = -2;
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
            //bool bSelected = true;
            //cbQuiltNames.SelectedIndex;
        }

        private void tbDesignBlockDesc_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
