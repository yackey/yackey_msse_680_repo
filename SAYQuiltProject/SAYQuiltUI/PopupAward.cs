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
    public partial class PopupAward : Form
    {
        private PopupInfoAwards popupInfo = new PopupInfoAwards();
        private FormCreate callback = null;

        public PopupAward()
        {
            InitializeComponent();
        }

        public PopupAward(FormCreate callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popupInfo.sAwardingBody = tbAwardingBody.Text;
            popupInfo.sDate = tbDate.Text;
            popupInfo.sDescription = tbDescription.Text;

            callback.NotifyAward(popupInfo);
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
