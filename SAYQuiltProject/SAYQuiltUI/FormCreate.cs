using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
