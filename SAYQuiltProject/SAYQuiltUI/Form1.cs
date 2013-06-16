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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetQuiltInfo_Click(object sender, EventArgs e)
        {
            Quilt q = new Quilt();
            q.Name = tbQuiltName.Text;

            COrderManager om = new COrderManager();
            Order orderFromQuilt = om.GetOrderFromQuilt(q);
            tbOrderStart.Text = orderFromQuilt.StartDate;
            tbOrderEnd.Text = orderFromQuilt.EndDate;
            tbOrderDescription.Text = orderFromQuilt.Description;
        }
    }
}
