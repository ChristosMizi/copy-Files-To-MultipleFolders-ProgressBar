using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReGExprExercise
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();

        string inputFile = null;
        string outputFile = null;

        public Form1()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;

        }
        private void CopyFile (string source, string destination, DoWorkEventArgs e)
        {
            FileStream fsout = new FileStream(destination, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] buffer = new byte[1048756]; //1 MB
            int readbytes;

            while ((readbytes = fsIn.Read(buffer,0,buffer.Length))>0)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.ReportProgress(0);
                    fsIn.Close();
                    fsout.Close();
                    return;
                }
                else
                {
                    fsout.Write(buffer, 0, readbytes);
                    worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
                   // this.timer1.Start();
                }
                
            }
            fsIn.Close();
            fsout.Close();
         
            
        }

       

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(txtBox_Source.Text, txtbox_destination.Text,e);
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
                MessageBox.Show("Operation is completed", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_percent.Text = e.ProgressPercentage.ToString() + "%";
        }

        string userProfileDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        private void checkRegExp_Click(object sender, EventArgs e)
        {
            
           
        }

       
       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                lblStatus.Visible = true;
            }
            else
            {
                progressBar1.Visible = true;
                lblStatus.Visible = true;
                worker.RunWorkerAsync();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //txtBox_Source.Text = inputFile;
        }




        private void button1_Click(object sender, EventArgs e)
        {

            File.Create(@"C:\Users\mizich01\Documents\Testinggg.txt");
            FileInfo f1 = new FileInfo(@"C:\Users\mizich01\Documents\Testinggg.txt");
            DateTime dtcreated = f1.CreationTime;
            DateTime dateonly = dtcreated.Date;
            MessageBox.Show(dateonly.ToString("dd_mm_yyyy"));

            string datestr = dateonly.ToString("dd_mm_yyyy");

            string newstr = "TestProjectChris" + datestr + ".txt";
            //MessageBox.Show(newstr);
            string destfilename = $@"C:\Users\mizich01\Documents\" + newstr;
            MessageBox.Show(destfilename);
            File.Move(@"C:\Users\mizich01\Documents\Testinggg.txt", destfilename);


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_IncludeDoWorker_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
