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
    public partial class PopupBom : Form
    {
        private PopupInfoBom popupInfo = new PopupInfoBom();
        private FormCreate callback = null;

        public PopupBom()
        {
            InitializeComponent();
        }

        public PopupBom(FormCreate callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popupInfo.sType = tbType.Text;
            popupInfo.sCount = tbCount.Text;
            popupInfo.sDescription = tbDescription.Text;

            callback.NotifyBom(popupInfo);
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
