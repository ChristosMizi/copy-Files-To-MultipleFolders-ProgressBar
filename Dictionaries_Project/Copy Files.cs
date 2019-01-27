using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Dictionaries_Project
{
    public partial class Copy_Files : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Copy_Files()
        {
            InitializeComponent();
           
            
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_percent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Loperation is aborted", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                progressBar1.Visible = true;
                MessageBox.Show("Operation is completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
           // Form1 f1 = new Form1();
           // f1.CopySourceFile();
           // CopyFile(txtBox_Source.Text, txtbox_destination.Text, e);
            //CopySourceFile(destFile, x,e);
        }

        private void Copy_Files_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
