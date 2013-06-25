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
    public partial class PopupOrderHistory : Form
    {
        private PopupInfoOrderHistory popupInfo = new PopupInfoOrderHistory();
        private FormCreate callback = null;

        public PopupOrderHistory()
        {
            InitializeComponent();
        }

        public PopupOrderHistory(FormCreate callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            popupInfo.sPhase = tbPhase.Text;
            popupInfo.sBeginDate = tbBeginDate.Text;
            popupInfo.sEndDate = tbEndDate.Text;

            callback.Notify(popupInfo);
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
