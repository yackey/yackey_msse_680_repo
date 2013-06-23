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
        private bool bIsChildRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void SetIsChildRunning(bool bIsRunning)
        {
            bIsChildRunning = bIsRunning;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            // exit the application
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todo.");
            return;
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            doDeleteAction(sender, e);
        }

        private void doDeleteAction(object sender, EventArgs e)
        {
            if (bIsChildRunning == true)
            {
                MessageBox.Show("Only one activity permitted.");
                return;
            }

            FormDelete child = new FormDelete(this);
            child.Show();
            bIsChildRunning = true;
        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            doCreateAction(sender, e);
        }

        private void doCreateAction(object sender, EventArgs e)
        {
            if (bIsChildRunning == true)
            {
                MessageBox.Show("Only one activity permitted.");
                return;
            }

            FormCreate child = new FormCreate(this);
            child.Show();
            bIsChildRunning = true;
        }

        private void toolStripDisplay_Click(object sender, EventArgs e)
        {
            doDisplayAction(sender, e);
        }

        private void doDisplayAction(object sender, EventArgs e)
        {
            if (bIsChildRunning == true)
            {
                MessageBox.Show("Only one activity permitted.");
                return;
            }

            FormDisplay child = new FormDisplay(this);
            child.Show();
            bIsChildRunning = true;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // exit the application
            System.Windows.Forms.Application.Exit();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDisplayAction(sender, e);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCreateAction(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDeleteAction(sender, e);
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todo.");
            return;
        }
    }
}
