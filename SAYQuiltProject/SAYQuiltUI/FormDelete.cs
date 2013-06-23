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
    public partial class FormDelete : Form
    {
        private Form1 f1 = null;
        public FormDelete(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            MdiParent = parent;

            CSimpleQuiltManager qm = new CSimpleQuiltManager();
            // quilts
            IEnumerable<Quilt> quiltEnum = qm.GetQuilts();
            List<Quilt> quiltList = quiltEnum.ToList();
            foreach (var item in quiltList)
            {
                cbQuiltToDelete.Items.Add(item.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int comboIdx = cbQuiltToDelete.SelectedIndex;
            if (comboIdx == -1)
            {
                MessageBox.Show("You must pick a quilt name.");
                f1.SetIsChildRunning(false);
                return;
            }

            String sQuiltName = (String)cbQuiltToDelete.SelectedItem;
            if (sQuiltName.Length == 0)
            {
                MessageBox.Show("You must pick a quilt name.");
                f1.SetIsChildRunning(false);
                Dispose(true);
            }

            COrderManager om = new COrderManager();
            bool bRet = om.DeleteOrderForce(sQuiltName);
            if (bRet == true)
            {
                cbQuiltToDelete.Items.RemoveAt(comboIdx);
                MessageBox.Show("That Worked !!");
            }
            else
            {
                MessageBox.Show("That Failed !!");
            }

            return ;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.SetIsChildRunning(false);
            Dispose(true);
        }
    }
}
