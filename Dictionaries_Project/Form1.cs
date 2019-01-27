using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/******************************************************************
 * © powered by CopyChristos Mizikakis!                           *   
 * You Only live once but if you work it wright once is enough    *
 *                                                                *
 *   Got You!!!! Someone is curious about the code!!              *
******************************************************************/                    
namespace Dictionaries_Project
{
    public partial class Form1 : Form
    {
        Queue<string> ListWithTheSourcePaths = new Queue<string>();
        //Queue<string> ListWithTheDestinationPaths = new Queue<string>();
        Queue<KeyValuePair<string, FileInfo>> queueWithTwoPairs = new Queue<KeyValuePair<string, FileInfo>>();
        BackgroundWorker worker = new BackgroundWorker();

        public static List<string> lastdestinationpath = new List<string>(); // contains all destination paths to Customization folder
        List<FileInfo> listWithChechedItems = new List<FileInfo>();

        List<string> ResetList = new List<string>();
        List<string> ResetListOfListBoxWithCheckedItems = new List<string>();
        List<DirectoryInfo> ListOfClientsAfterRegularExpression = new List<DirectoryInfo>();

        Regex objClientsStartEndAZ = new Regex("^[A-Za-z](^_|^-|[A-Za-z])[A-Za-z]*");
        Regex objNielsenName = new Regex("^[Mm][Yy][\\s][Nn][Ii][Ee][Ll][Ss][Ee][Nn]*");
        string keywords = "(My Nielsen Answers|Nielsen Answer)";
        string keywordLatestClientCF = "1. Latest Client Content Folder";
        //Regex objRegExp = new Regex(content, @"\b(shoes|shirt|pants)\b");

        string userProfileDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // public int NumberOfClientsCFToBeCopied;
        //public void setCounter(int counter)
        //{
        //    NumberOfClientsCFToBeCopied = counter;
        //}
        bool CheckIfButtonPressedTwice = false;

        long maxbytes = 0;
        int copied = 0;
        int total = 0;
        public Form1()
        {
            InitializeComponent();
            
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;

        }

        public void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var totalFiles = queueWithTwoPairs.Count;
            var processed = 0;
            while (queueWithTwoPairs.Count > 0)
            {
                var info = queueWithTwoPairs.Dequeue();
                CopySourceFile(info.Key, info.Value, e);
                worker.ReportProgress(++processed * 100 / totalFiles);
            }

           //  foreach (var kvp in queueWithTwoPairs)
           // {
           //// for (int i = 0; i < queueWithTwoPairs.Count; i++)
           // //{
           //     CopySourceFile(kvp.Key, kvp.Value, e);
                
                
            
           //     //var kvp1 = queueWithTwoPairs.Peek();
           //     //string desst = kvp.Key;
           //     //FileInfo src = kvp.Value;
                
           // }



        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //int RCBRead = 0;
            //RCBRead = (int)ReadCurrentBytes;
            //progressBar1.Increment(RCBRead);
            lblStatus.Text = "Working...";
            progressBar1.Value = e.ProgressPercentage;
            lbl_percent.Text = e.ProgressPercentage.ToString() + "%";
            //  lbl_percent.Text = progressBar1.Value.ToString() + "%";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Operation is aborted", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatus.Text = "Completed";
                progressBar1.Visible = true;
               MessageBox.Show("Files have been successfully copied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Check your Desktop." + Environment.NewLine + "File Created --> Project_Dictionaries.csv" + Environment.NewLine + "File Created --> ProjectZipFiles.txt", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckIfButtonPressedTwice = false;
                progressBar1.Value = 0;
                lblStatus.Text = "Status:";
            }
        }



        // Button Get files from Directory
        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();

            if (FDB.ShowDialog() == DialogResult.OK)
            {
                checkedListBox1.Items.Clear();
                txtBoxGetFiles.Text = FDB.SelectedPath;


            }

        }


        long ReadAllBytes = 0;
        long ReadCurrentBytes = 0;
        long fsinPreviousLength = 0;




        public void CopySourceFile(string destFile, FileInfo x, DoWorkEventArgs e)
        {
            
           
                FileStream fsIn = new FileStream(x.FullName, FileMode.Open);
                byte[] buffer = new byte[1048756]; //1 MB
                int readbytes;
                 
                FileInfo destFileCanBeReadOnly = new FileInfo(destFile);
                while ((readbytes = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
               // ReadCurrentBytes = readbytes;
                 // ReadAllBytes += readbytes;
                if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        //worker.ReportProgress(0);
                        fsIn.Close();

                        return;
                    }
                    else
                    {
                        //fsout.Write(buffer, 0, readbytes);

                        // this.timer1.Start();

                        if (destFileCanBeReadOnly.IsReadOnly == true)
                        {
                            // File with the same Name Exists and Attributes ReadOnly
                            File.SetAttributes(destFile, FileAttributes.Normal);
                            File.Delete(destFile);

                            x.CopyTo(destFile, true);
                            File.SetAttributes(destFile, FileAttributes.ReadOnly);
                          // fsinPreviousLength +=  fsIn.Length;


                        // worker.ReportProgress((int)((fsIn.Length +fsIn.Position) * 100 / ReadAllBytes));
                          //worker.ReportProgress((int)(( fsIn.Position) * 100 / fsIn.Length));
                    }
                        //EDW GINETAI TO COPy
                        else
                        { // File with same name Exists and Attributes not ReadOnly
                        File.SetAttributes(destFile, FileAttributes.Normal);
                        File.Delete(destFile);
                            x.CopyTo(destFile, true);
                           //worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
                            File.SetAttributes(destFile, FileAttributes.ReadOnly);
                       // fsinPreviousLength += (byte)fsIn.Length;


                      //  worker.ReportProgress((int)((fsIn.Length + fsIn.Position) * 100 / ReadAllBytes));

                    }
                   // worker.ReportProgress((int)(ReadCurrentBytes * 100 / ReadAllBytes));
                }
                //worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
                //int[] TelikoArrayClientsCF = new int[NumberOfClientsCFToBeCopied];
              // int AllCFs=  ListOfClientsAfterRegularExpression.Count();
               // worker.ReportProgress((int)(queueWithTwoPairs.Count * 100 / AllCFs));
            }
            
            fsIn.Close();
          
           

        }
        

        //  -----------------Button send files From BoxList with Checked Items and send to Server
        private void BtnSendFiles_Click(object sender, EventArgs e)
        {
            if (txtServerPathCountryDirectories.Text == ""|| checkedListBox1.Items.Count<=0 ||ListBoxGetCheckedItems.Items.Count<=0|| txtBoxGetFiles.Text=="")
            {
                MessageBox.Show("Please Fill all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtServerPathCountryDirectories.Focus();
                txtServerPathCountryDirectories.BackColor = Color.Silver;
            }
            else
            {
                
                
                bool csvResult = false;
                bool result = false; // exists to all blocks that copy process is done the file(s)
                bool FileCreatedToDesktopBecauseNotCopied =false;

                if (CheckIfButtonPressedTwice == true)
                {
                    MessageBox.Show("Process....in progress! Please Wait.", "Proccess Copy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    listWithChechedItems.Clear();
                    GetDirectoriesFromSelectedPath(txtServerPathCountryDirectories.Text);

                    for (int i = 0; i < ListBoxGetCheckedItems.Items.Count; i++)
                    {

                        string str = (string)ListBoxGetCheckedItems.Items[i];
                        //Source File pou thelw                       // prepei na valw allo path 
                        FileInfo f4 = new FileInfo(Path.Combine(txtBoxGetFiles.Text, str));
                        listWithChechedItems.Add(f4); //
                                                      // MessageBox.Show(f4.Name); // Output Test6.txt

                    }
                    // Apo pou tha parei ta arxeia  tha ta parei apo ton ListCheckedItems            


                    ListWithTheSourcePaths.Clear();
                    foreach (FileInfo x in listWithChechedItems)
                    {
                        int counterz = 0;

                        foreach (string st1 in lastdestinationpath)
                        {
                            // >>>>>>>>>>>>> x                  

                            if (x.IsReadOnly == true)
                            {

                                string str6 = Path.Combine(lastdestinationpath[counterz], @"Answers Data\Customization");

                                // ->>destfile destination File auto thelw 
                                string destFile = Path.Combine(str6, x.Name);
                                //MessageBox.Show(destFile);


                                // if File Not  Exists
                                if (!File.Exists(destFile))
                                {



                                    string csvPath = Path.Combine(userProfileDesktop, "Project_Dictionaries.csv");

                                    string strline = $"File {x.Name} Not copied to --> {str6}";
                                    string textName = Path.Combine(userProfileDesktop, "ProjectDictionaries.txt");

                                      string Finalstring = SetTempString(txtServerPathCountryDirectories.Text, str6);


                                    //string ClientNameFullPathuntilCustomization = str6;
                                    //string strFirst = "_ELENI TEST\\";
                                    //string strSecond = "\\1. Latest Client Content Folder";
                                    //string Finalstring;
                                    //string TempString;
                                    //int Pos1 = ClientNameFullPathuntilCustomization.IndexOf(strFirst) + strFirst.Length;
                                    //int pos2 = ClientNameFullPathuntilCustomization.IndexOf(strSecond);
                                    //Finalstring = ClientNameFullPathuntilCustomization.Substring(Pos1, pos2 - Pos1);

                                    if (!File.Exists(csvPath))
                                    {

                                        StringBuilder csvContent = new StringBuilder();
                                        string HeaderLine = "File Name,Not Coppied to Below Clients ,Not Coppied to Below Path" + Environment.NewLine;
                                        File.WriteAllText(csvPath, HeaderLine);
                                        csvContent.AppendLine($"{x.Name},{Finalstring},{str6}");
                                         File.AppendAllText(csvPath, csvContent.ToString());
                                        csvResult = true;
                                        


                                    }
                                    else
                                    {
                                        // File.Delete(csvPath);
                                        StringBuilder csvContent = new StringBuilder();
                                        // string HeaderLine = "File Name,Not Coppied to Below Clients ,Not Coppied to Below Path" + Environment.NewLine;
                                        // File.WriteAllText(csvPath, HeaderLine);

                                        csvContent.AppendLine($"{x.Name},{Finalstring},{str6}");

                                        File.AppendAllText(csvPath, csvContent.ToString());
                                        csvResult = true;
                                      
                                        CheckIfButtonPressedTwice = true;
                                    }

                                    if (!File.Exists(textName))
                                    {
                                        var f1 = File.Create(textName);
                                        f1.Close();
                                        File.AppendAllText(textName, strline + Environment.NewLine);

                                       
                                        CheckIfButtonPressedTwice = true;
                                    }
                                    else
                                    {
                                        File.AppendAllText(textName, strline + Environment.NewLine);
                                     
                                        CheckIfButtonPressedTwice = true;
                                    }

                                    FileCreatedToDesktopBecauseNotCopied =true;
                                }

                                // File exists in the destination folder kai to source file einai RO
                                else
                                {
                                    File.SetAttributes(x.FullName, FileAttributes.Normal);
                                    byte[] buffer = new byte[1048756]; //1 MB
                                    int readbytes;

                                    FileStream fsIn = new FileStream(x.FullName, FileMode.Open);
                                    readbytes = fsIn.Read(buffer, 0, buffer.Length);

                                    ReadAllBytes += readbytes;

                                    //EDW GINETAI TO COPY


                                    queueWithTwoPairs.Enqueue(new KeyValuePair<string, FileInfo>(destFile, x));


                                    result = true;
                                    CheckIfButtonPressedTwice = true;
                                    
                                    fsIn.Close();
                                }

                                counterz++;

                            }
                            // (The files to be copied are not Read Only) to if tou einai sti 261
                            else
                            {

                                string str10 = Path.Combine(lastdestinationpath[counterz], @"Answers Data\Customization");
                                // MessageBox.Show(str10);

                                string destFile = Path.Combine(str10, x.Name);



                                // Check if File with same Name not Exists
                                if (!File.Exists(destFile))
                                {
                                    //path file .txt
                                    string strline = $"File {x.Name} Not copied to --> {str10}";
                                    string textName = Path.Combine(userProfileDesktop, "ProjectDictionaries.txt");

                                    //Path file .csv
                                    string csvPath = Path.Combine(userProfileDesktop, "Project_Dictionaries.csv");
                                    //Substring
                                    string Finalstring = SetTempString(txtServerPathCountryDirectories.Text, str10);
                                    //string ClientNameFullPathuntilCustomization = str10;
                                    //string strFirst = "_ELENI TEST\\";
                                    //string strSecond = "\\1. Latest Client Content Folder";
                                    //string Finalstring;
                                    //string TempString;
                                    //int Pos1 = ClientNameFullPathuntilCustomization.IndexOf(strFirst) + strFirst.Length;
                                    //int pos2 = ClientNameFullPathuntilCustomization.IndexOf(strSecond);
                                    //Finalstring = ClientNameFullPathuntilCustomization.Substring(Pos1, pos2 - Pos1);

                                    if (!File.Exists(csvPath))
                                    {

                                        StringBuilder csvContent = new StringBuilder();
                                        string HeaderLine = "File Name, Not Coppied to Below Clients, Not Coppied to Below Path" + Environment.NewLine;
                                        File.WriteAllText(csvPath, HeaderLine);
                                        csvContent.AppendLine($"{x.Name},{Finalstring},{str10}");
                                       File.AppendAllText(csvPath, csvContent.ToString());
                                        csvResult = true;
                                        
                                        CheckIfButtonPressedTwice = true;
                                    }
                                    else
                                    {
                                        //File.Delete(csvPath);
                                        StringBuilder csvContent = new StringBuilder();
                                        // string HeaderLine = "File Name, Not Coppied to Below Clients, Not Coppied to Below Path" + Environment.NewLine;
                                        // File.WriteAllText(csvPath, HeaderLine);
                                        csvContent.AppendLine($"{x.Name},{Finalstring},{str10}");
                                       File.AppendAllText(csvPath, csvContent.ToString());
                                        csvResult = true;
                                       
                                        CheckIfButtonPressedTwice = true;
                                    }

                                    if (!File.Exists(textName))
                                    {
                                        var f1 = File.Create(textName);
                                        f1.Close();
                                        File.AppendAllText(textName, strline + Environment.NewLine);
                                    
                                        CheckIfButtonPressedTwice = true;
                                    }
                                    else
                                    {
                                        File.AppendAllText(textName, strline + Environment.NewLine);
                                       
                                        CheckIfButtonPressedTwice = true;
                                    }
                                    FileCreatedToDesktopBecauseNotCopied = true;
                                }
                                // EDW GINETAI TO COPY Src File Not RO and DestFile is RO 
                                else
                                {
                                    File.SetAttributes(x.FullName, FileAttributes.Normal);
                                    byte[] buffer = new byte[1048756]; //1 MB
                                    int readbytes;

                                    FileStream fsIn = new FileStream(x.FullName, FileMode.Open);
                                    readbytes = fsIn.Read(buffer, 0, buffer.Length);

                                    ReadAllBytes += readbytes;
                                    queueWithTwoPairs.Enqueue(new KeyValuePair<string, FileInfo>(destFile, x));
                                    fsIn.Close();
                                    result = true;
                                    CheckIfButtonPressedTwice = true;
                                   
                                }

                                counterz++;
                            }


                        }


                    }


                    if (result == true)
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
                        // MessageBox.Show("Files were successfully Copied.","Success", MessageBoxButtons.OK,MessageBoxIcon.None);
                        //MessageBox.Show("Check your Desktop."+Environment.NewLine+ "File Created --> Project_Dictionaries.csv"+Environment.NewLine+ "File Created --> ProjectZipFiles.txt","Info!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    

                    if (checkedListBox1.Items.Count <= 0 || ListBoxGetCheckedItems.Items.Count <= 0)
                    {
                        MessageBox.Show("No item(s) in the ListBox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if ( result == false && FileCreatedToDesktopBecauseNotCopied== false)
                    {
                        MessageBox.Show("The Path is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    if (result == false && FileCreatedToDesktopBecauseNotCopied == true)
                    {
                        MessageBox.Show("Files Do Not Exist to Destination Folders", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        MessageBox.Show("Check your Desktop." + Environment.NewLine + "File Created --> Project_Dictionaries.csv" + Environment.NewLine + "File Created --> ProjectZipFiles.txt", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CheckIfButtonPressedTwice = false;
                    }
                    if (checkedListBox1.Items.Count > 0 && ListBoxGetCheckedItems.Items.Count > 0 && txtBoxGetFiles.Text == "")
                    {
                        MessageBox.Show(" Check if ListBox is empty OR check if TextBox is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (checkedListBox1.Items.Count > 0 && ListBoxGetCheckedItems.Items.Count > 0 && txtServerPathCountryDirectories.Text == "")
                    {
                        MessageBox.Show(" Check if ListBox is empty OR check if TextBox is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }



                    //if (csvResult == true)
                    //{
                    //    string csvPath = Path.Combine(userProfileDesktop, "Project_Dictionaries.csv");
                    //    StringBuilder csvContent = new StringBuilder();
                    //    csvContent.AppendLine("File Name, Not Coppied to Path");

                    //    //File.AppendAllText(csvPath, csvContent.ToString());
                    //    //for (int i = 0; i < csvContent.c; i++)
                    //    //{
                    //    //    CSV[i].Insert(0, i == 0 ? "<Date>" : "Needs a value but this in the secondrom"

                    //    //    CSV[i].Insert(1, i == 0 ? "A" : "");
                    //    //    CSV[i].Insert(2, i == 0 ? "B" : "");
                    //    //}
                    //}
                }
            }
             
            
            



        }
        private string SetTempString(string str, string str6)
        {
            switch (str)
            {
                //UK
                case @"\\enterprise\sentrum\UK_OXF\Departments\DSS\ALLREAD\AD\CF":
               
                    string ClientNameFullPathuntilCustomization = str6;
                    string strFirst = "CF";
                    string strSecond = "\\1. Latest Client Content Folder";
                    string Finalstring;
                    string TempString;
                    int Pos1 = ClientNameFullPathuntilCustomization.IndexOf(strFirst) + strFirst.Length +1;
                    int pos2 = ClientNameFullPathuntilCustomization.IndexOf(strSecond);
                    Finalstring = ClientNameFullPathuntilCustomization.Substring(Pos1, pos2 - Pos1);
                    return Finalstring;
                   // break;
                   //Sweden Eleni Test
                
                case @"\\ACN046STOFS02\Company\DSS\IDS\System\AD\Category Suite CIP\_ELENI TEST":
                    string ClientNameFullPathuntilCustomizationSWE = str6;
                    string strFirstSWE = "_ELENI TEST";
                    string strSecondSWE = "\\1. Latest Client Content Folder";
                    string FinalstringSWE;
                    string TempStringSWE;
                    int Pos1SWE = ClientNameFullPathuntilCustomizationSWE.IndexOf(strFirstSWE) + strFirstSWE.Length + 1;
                    int pos2SWE = ClientNameFullPathuntilCustomizationSWE.IndexOf(strSecondSWE);
                    FinalstringSWE = ClientNameFullPathuntilCustomizationSWE.Substring(Pos1SWE, pos2SWE - Pos1SWE);
                    return FinalstringSWE;
                //Sweden Works
                case @"\\ACN046STOFS02\Company\DSS\IDS\System\AD\Category Suite CIP":
               
                    string ClientNameFullPathuntilCustomizationSW = str6;
                    string strFirstSW = "Category Suite CIP";
                    string strSecondSW = "\\1. Latest Client Content Folder";
                    string FinalstringSW;
                    string TempStringSW;
                    int Pos1SW = ClientNameFullPathuntilCustomizationSW.IndexOf(strFirstSW) + strFirstSW.Length + 1;
                    int pos2SW = ClientNameFullPathuntilCustomizationSW.IndexOf(strSecondSW);
                    FinalstringSW = ClientNameFullPathuntilCustomizationSW.Substring(Pos1SW, pos2SW - Pos1SW);
                    return FinalstringSW;
                //break;
                //Norway
                case @"\\ACN047OSLFSV05\users\Forretningsområder\NIS\AD\Cat. Suite CIP":
                
                    string ClientNameFullPathuntilCustomizationNO = str6;
                    string strFirstNO = "Cat. Suite CIP";
                    string strSecondNO = "\\1. Latest Client Content Folder";
                    string FinalstringNO;
                    string TempStringNO;
                    int Pos1NO = ClientNameFullPathuntilCustomizationNO.IndexOf(strFirstNO) + strFirstNO.Length +1;
                    int pos2NO = ClientNameFullPathuntilCustomizationNO.IndexOf(strSecondNO);
                    FinalstringNO = ClientNameFullPathuntilCustomizationNO.Substring(Pos1NO, pos2NO - Pos1NO);
                    return FinalstringNO;
                    //Belgium
                    
                case @"\\enterprisenet.org\belgium\snap\Root\workgroups\CS\ids\AD_CLIENT":
               
                    string ClientNameFullPathuntilCustomizationBE = str6;
                    string strFirstBE = "AD_CLIENT";
                    string strSecondBE = "\\1. Latest Client Content Folder";
                    string FinalstringBE;
                    string TempStringBE;
                    int Pos1BE = ClientNameFullPathuntilCustomizationBE.IndexOf(strFirstBE) + strFirstBE.Length +1;
                    int pos2BE = ClientNameFullPathuntilCustomizationBE.IndexOf(strSecondBE);
                    FinalstringBE = ClientNameFullPathuntilCustomizationBE.Substring(Pos1BE, pos2BE - Pos1BE);
                    return FinalstringBE;
                //Denmark
                case @"\\Acn045kbhmtprd3\infact\NIS\Cat.Suite CIP":
                
                    string ClientNameFullPathuntilCustomizationDE = str6;
                    string strFirstDE = "Cat.Suite CIP";
                    string strSecondDE = "\\1. Latest Client Content Folder";
                    string FinalstringDE;
                    string TempStringDE;
                    int Pos1DE = ClientNameFullPathuntilCustomizationDE.IndexOf(strFirstDE) + strFirstDE.Length +1;
                    int pos2DE = ClientNameFullPathuntilCustomizationDE.IndexOf(strSecondDE);
                    FinalstringDE = ClientNameFullPathuntilCustomizationDE.Substring(Pos1DE, pos2DE - Pos1DE);
                    return FinalstringDE;

                default:
                    //MessageBox.Show(" The Destination Path provided has not the Correct structure for subfolders ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string messageNoCorrectStructureForSubfolders =@" The Destination Path provided has not the Correct structure for subfolders";
                    return messageNoCorrectStructureForSubfolders;
            }
        }


        //---------------------------------------Button Get Checked Items -------------------------------------
        private void btnGetCheckedItems_Click(object sender, EventArgs e)
        {
            ListBoxGetCheckedItems.Items.Clear();
            ResetListOfListBoxWithCheckedItems.Clear();

            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the ListBox", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkedListBox1.CheckedItems.Count <= 0) //checkedListBox1.CheckedItems.Count <= 0
            {

                MessageBox.Show("Please select item(s)!", "Hey! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (string s in checkedListBox1.CheckedItems)
                {
                    ListBoxGetCheckedItems.Items.Add(s);

                    ResetListOfListBoxWithCheckedItems.Add(s);
                    txtBox_all_Items_in_ListBoxWithCheckedItems.Text = ListBoxGetCheckedItems.Items.Count.ToString();

                }
            }
            
            
        }


        //----------------------------------------Method GetDirectories () ---------------------------------------------------
        public void GetDirectoriesFromSelectedPath(string DestinationText)
        {
            if (DestinationText == "")
            {

            }
            else
            {
                
                // Get Directories Countries from 
                DirectoryInfo dirTest = new DirectoryInfo(DestinationText); //@"C:\NielsenAD\CF"
                DirectoryInfo[] ArrayOfContentFolders = dirTest.GetDirectories();
               


                // to ArrayOfContentFolders exei Beirsdorf , Ferrero , Dr Oatket
                
                
                
                int counterr = 0;
                lastdestinationpath.Clear();
                foreach (DirectoryInfo d2 in ArrayOfContentFolders)
                {
                    if (objClientsStartEndAZ.IsMatch(d2.Name))
                    {
                        // Array contains all the path 
                        string[] ArrayWithTheFullPathOfEveryFirstSubFolderCountrysContentFolder = Directory.GetDirectories(d2.FullName); //d2.FullName = C:\NielsenAD\CF\Beiersdorf ara o pinakas exei px, prwto stoixeioC:\NielsenAD\CF\Beiersdorf\1. Latest Client Content Folder
                        foreach (string dir6 in ArrayWithTheFullPathOfEveryFirstSubFolderCountrysContentFolder) // dir6 is C:\NielsenAD\CF\Beiersdorf
                        {
                            DirectoryInfo dir7 = new DirectoryInfo(dir6);
                            Match m = Regex.Match(dir7.Name, @"\b" + keywordLatestClientCF + @"\w*", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                            if (m.Success) //objRegExp.IsMatch(dir7.Name)
                            {
                                string[] ArrayCf = Directory.GetDirectories(dir7.FullName); // .....\Alpro\1.Latest Content Folder

                                foreach (string dir8 in ArrayCf)
                                {
                                    DirectoryInfo dir9 = new DirectoryInfo(dir8);

                                    //Match m1 = Regex.Match(dir9.Name, @"\b" + keywords + @"\w*", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                                    // if (m1.Success)
                                    if (objNielsenName.IsMatch(dir9.Name))
                                    {
                                        string strDestFolderWithRegEX = dir9.FullName;
                                        // string destPath = Path.Combine(d2.FullName, strDestFolderWithRegEX); // Edw thelw na valw REGEXP
                                        lastdestinationpath.Add(strDestFolderWithRegEX);
                                        ListOfClientsAfterRegularExpression.Add(dir9);
                                    }

                                }
                                if (Directory.GetFiles(dir7.FullName, "*.zip").Length == 0)
                                {
                                    // MessageBox.Show("No .zip files Found!");

                                }
                                else
                                {
                                    string[] ArrayOfFiles = Directory.GetFiles(dir7.FullName, "*.zip");
                                    //check if Array empty
                                    for (int i = 0; i < ArrayOfFiles.Length; i++)
                                    {
                                        string strline = $"File {ArrayOfFiles[i]} Found to  --> {dir7.FullName}";
                                        string textName = Path.Combine(userProfileDesktop, "Project-Dictionaries-With-ZipFiles.txt");
                                        if (!File.Exists(textName))
                                        {
                                            var f1 = File.Create(textName);
                                            f1.Close();
                                            File.AppendAllText(textName, strline + Environment.NewLine);
                                        }
                                        else
                                        {
                                            File.AppendAllText(textName, strline + Environment.NewLine);
                                        }
                                    }



                                }



                            }

                        }

                        counterr++;
                    }
                    

                }
            }
            

        }
            
            //------------------------------ Button Get Server with Country Directories --------------------------------

        private void btnGetCountryDirectories_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();

            if (FDB.ShowDialog() == DialogResult.OK)
            {
                txtServerPathCountryDirectories.Text = FDB.SelectedPath;

            }
           // GetDirectoriesFromSelectedPath(txtServerPathCountryDirectories.Text);


        }

        private void txtServerPathCountryDirectories_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_ListBoxWithSourceFiels_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            txtBoxAllItems.Text = checkedListBox1.Items.Count.ToString();
        }

        private void ClearCheckedItems_ListboxWithSourceFiles_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the Listbox!", "Hey! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if
            //bool checkedItem = true;
             (checkedListBox1.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please select item(s)", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                while (checkedListBox1.CheckedItems.Count > 0)
                {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
                }
            }

            txtBoxAllItems.Text = checkedListBox1.Items.Count.ToString();
        }

        private void btnResetListWithSourceFiles_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            foreach (string s in ResetList)
            {
                checkedListBox1.Items.Add(s);
            }
            txtBoxAllItems.Text = checkedListBox1.Items.Count.ToString();
        }

        private void txtBoxAllItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Listbox_With_Checked_items_Click(object sender, EventArgs e)
        {
            ListBoxGetCheckedItems.Items.Clear();
            txtBox_all_Items_in_ListBoxWithCheckedItems.Text = ListBoxGetCheckedItems.Items.Count.ToString();
        }

        private void btn_Reset_ListBox_With_Checked_Items_Click(object sender, EventArgs e)
        {
            ListBoxGetCheckedItems.Items.Clear();
            foreach (string s in ResetListOfListBoxWithCheckedItems)
            {
                ListBoxGetCheckedItems.Items.Add(s);
            }
            txtBox_all_Items_in_ListBoxWithCheckedItems.Text = ListBoxGetCheckedItems.Items.Count.ToString();
        }

        private void Clear_Listbox_With_CheckedItems_Click(object sender, EventArgs e)
        {
            if (ListBoxGetCheckedItems.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the ListBox", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ListBoxGetCheckedItems.CheckedItems.Count <= 0) //checkedListBox1.CheckedItems.Count <= 0
            {

                MessageBox.Show("Please select item(s)", "Heads Up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                while (ListBoxGetCheckedItems.CheckedItems.Count > 0)
                {
                    
                    ListBoxGetCheckedItems.Items.RemoveAt(ListBoxGetCheckedItems.CheckedIndices[0]);
                    
                }
                if (checkBox2.Checked== true)

                {
                    checkBox2.Checked =false;
                }
            }
            txtBox_all_Items_in_ListBoxWithCheckedItems.Text = ListBoxGetCheckedItems.Items.Count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PassOneItem_Click(object sender, EventArgs e)
        {
            // foreach (Control c in Controls)
            // {
            //if (c is CheckBox)
            // {
            //CheckBox cb = (CheckBox)c;
            //if (cb.Checked == false)
            //{
            //    MessageBox.Show("Please select Item(s)");
            //}
            //else
            //{
            //    if (ListBoxGetCheckedItems.Items.Contains(checkedListBox1.SelectedItem.ToString()))
            //    {
            //        MessageBox.Show("There seems to be a duplicate in your list");
            //    }

            //    else
            //    {
            //        ListBoxGetCheckedItems.Items.Add(checkedListBox1.SelectedItem.ToString());
            //    }
            //}
            //}
            // }
            //foreach (var s in checkedListBox1.Items)
            //{

            //    if (ListBoxGetCheckedItems.Items.Contains(checkedListBox1.SelectedItem.ToString()))
            //{
            //     MessageBox.Show("There seems to be a duplicate in your list");
            // }

            //           else
            //           {
            //                ListBoxGetCheckedItems.Items.Add(checkedListBox1.SelectedItem.ToString());
            //            }

            //}
            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the ListBox", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkedListBox1.CheckedItems.Count <= 0 ) //checkedListBox1.CheckedItems.Count <= 0
            {

                MessageBox.Show("Please select One item!", "Hey! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetSelected(i) && checkedListBox1.GetItemChecked(i))  //getItemchecked
                    {

                        if (ListBoxGetCheckedItems.Items.Contains(checkedListBox1.SelectedItem.ToString())) //|| ListBoxGetCheckedItems.Items.Contains(checkedListBox1.SelectedItems.ToString())
                        {


                            MessageBox.Show("There seems to be a duplicate in your list", "Heads up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            ListBoxGetCheckedItems.Items.Add(checkedListBox1.SelectedItem.ToString());
                        }
                    }



                }
            }
           


        }

        private void btn_PassItemToTheLeftListBox_Click(object sender, EventArgs e)
        {
            if (ListBoxGetCheckedItems.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the ListBox", "Heads Up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ListBoxGetCheckedItems.CheckedItems.Count <= 0)
            {
                MessageBox.Show("No item(s) checked", "Watch out!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ListBoxGetCheckedItems.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Only 1 Checked Item can be removed", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ListBoxGetCheckedItems.Items.Remove(ListBoxGetCheckedItems.CheckedItems[0]);
                }
                
                
            }
                //checkedListBox1.Items.Add(ListBoxGetCheckedItems.SelectedItem);
                
        }

        private void lbl_destination_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
        }

        private void btn_CheckAllListBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBoxGetCheckedItems.Items.Count; i++)
            {
                ListBoxGetCheckedItems.SetItemChecked(i, false);
            }
        }

        private void btn_UnCheckAllListBox1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("No item(s) in the Listbox!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkedListBox1.CheckedItems.Count <= 0)
            {
                MessageBox.Show("No item(s) checked", "Heads Up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_CorrectGetFiles_Click(object sender, EventArgs e)
        {


            if (txtBoxGetFiles.Text == "")
            {
                MessageBox.Show("Please select a Folder!", "Invalid Input!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtBoxGetFiles.Focus();
                txtBoxGetFiles.BackColor = Color.Silver;
            }
            else
            {
                checkedListBox1.Items.Clear();
                
                string[] files = Directory.GetFiles(txtBoxGetFiles.Text); // hold all the files

                ResetList.Clear();
                foreach (string f in files)
                {
                    checkedListBox1.Items.Add(Path.GetFileName(f)); //GetFileName(f)
                    ResetList.Add(Path.GetFileName(f));
                }
            }
            txtBoxAllItems.Text = checkedListBox1.Items.Count.ToString();
        }

        private void chkBox_AllChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_AllChecked.Checked == true)
            {

                if (checkedListBox1.Items.Count <= 0)
                {
                    

                    chkBox_AllChecked.Checked = false;
                    MessageBox.Show("No item(s) in the ListBox!","Heads up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                
                else
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
                
            }
            else
            {
                if (checkedListBox1.Items.Count <= 0)
                {
                    //MessageBox.Show("No item(s) in the Listbox!");
                }
                else if (checkedListBox1.CheckedItems.Count <= 0)
                {
                    MessageBox.Show("No item(s) checked", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                if (ListBoxGetCheckedItems.Items.Count <= 0)
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("No item(s) in the ListBox!", "Heads up! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < ListBoxGetCheckedItems.Items.Count; i++)
                    {
                        ListBoxGetCheckedItems.SetItemChecked(i, true);
                    }
                }
                
            }
            else
            {
                if (ListBoxGetCheckedItems.Items.Count <= 0)
                {
                    //MessageBox.Show("No item(s) in the Listbox!");
                }
                else if (ListBoxGetCheckedItems.CheckedItems.Count <= 0)
                {
                    MessageBox.Show("No item(s) checked", "Heads Up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    for (int i = 0; i < ListBoxGetCheckedItems.Items.Count; i++)
                    {
                        ListBoxGetCheckedItems.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void lbl_percent_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            this.Hide();
            //Form1 f1 = new Form1();
            //f1.Close();
        }

        private void btn_CorrectGetFiles_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGetCountryDirectories_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();

            if (FDB.ShowDialog() == DialogResult.OK)
            {
                txtServerPathCountryDirectories.Text = FDB.SelectedPath;

            }
        }

        private void BtnSendFiles_MouseHover(object sender, EventArgs e)
        { 
        
            BtnSendFiles.BackColor = Color.AliceBlue;
        }

        private void BtnSendFiles_MouseLeave(object sender, EventArgs e)
        {
            BtnSendFiles.BackColor = Color.Transparent;
        }

        //private void btnGetFiles_Click_1(object sender, EventArgs e)
        //{

        //}







        /*static Ienumerable <Int> Iterator()
         * {
         * yield return 0;
         * yield return 1;
         * yield return 2;
         * 
         * }
         
         foreach (var current in Iterator()))
         {
        console.writeline(current); 
        }
         
         */
    }
}
