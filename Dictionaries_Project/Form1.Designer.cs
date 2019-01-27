namespace Dictionaries_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.txtBoxGetFiles = new System.Windows.Forms.TextBox();
            this.btnGetCountryDirectories = new System.Windows.Forms.Button();
            this.BtnSendFiles = new System.Windows.Forms.Button();
            this.txtServerPathCountryDirectories = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_CorrectGetFiles = new System.Windows.Forms.Button();
            this.btnGetCheckedItems = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ListBoxGetCheckedItemsold = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAllItems = new System.Windows.Forms.TextBox();
            this.Clear_ListBoxWithSourceFiels = new System.Windows.Forms.Button();
            this.ClearCheckedItems_ListboxWithSourceFiles = new System.Windows.Forms.Button();
            this.btnResetListWithSourceFiles = new System.Windows.Forms.Button();
            this.btn_Clear_Listbox_With_Checked_items = new System.Windows.Forms.Button();
            this.btn_Reset_ListBox_With_Checked_Items = new System.Windows.Forms.Button();
            this.Clear_Listbox_With_CheckedItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_all_Items_in_ListBoxWithCheckedItems = new System.Windows.Forms.TextBox();
            this.ListBoxGetCheckedItems = new System.Windows.Forms.CheckedListBox();
            this.btn_PassOneItem = new System.Windows.Forms.Button();
            this.btn_PassItemToTheLeftListBox = new System.Windows.Forms.Button();
            this.chkBox_AllChecked = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.AutoSize = true;
            this.btnGetFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetFiles.Location = new System.Drawing.Point(533, 11);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(26, 23);
            this.btnGetFiles.TabIndex = 32;
            this.btnGetFiles.Text = "...";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // txtBoxGetFiles
            // 
            this.txtBoxGetFiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBoxGetFiles.Location = new System.Drawing.Point(98, 11);
            this.txtBoxGetFiles.Name = "txtBoxGetFiles";
            this.txtBoxGetFiles.Size = new System.Drawing.Size(427, 20);
            this.txtBoxGetFiles.TabIndex = 35;
            // 
            // btnGetCountryDirectories
            // 
            this.btnGetCountryDirectories.AutoSize = true;
            this.btnGetCountryDirectories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetCountryDirectories.Location = new System.Drawing.Point(533, 35);
            this.btnGetCountryDirectories.Name = "btnGetCountryDirectories";
            this.btnGetCountryDirectories.Size = new System.Drawing.Size(26, 23);
            this.btnGetCountryDirectories.TabIndex = 33;
            this.btnGetCountryDirectories.Text = "...";
            this.btnGetCountryDirectories.UseVisualStyleBackColor = true;
            this.btnGetCountryDirectories.Click += new System.EventHandler(this.btnGetCountryDirectories_Click_1);
            // 
            // BtnSendFiles
            // 
            this.BtnSendFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSendFiles.Location = new System.Drawing.Point(572, 93);
            this.BtnSendFiles.Name = "BtnSendFiles";
            this.BtnSendFiles.Size = new System.Drawing.Size(50, 23);
            this.BtnSendFiles.TabIndex = 34;
            this.BtnSendFiles.Text = "Copy";
            this.BtnSendFiles.UseVisualStyleBackColor = true;
            this.BtnSendFiles.Click += new System.EventHandler(this.BtnSendFiles_Click);
            this.BtnSendFiles.MouseLeave += new System.EventHandler(this.BtnSendFiles_MouseLeave);
            this.BtnSendFiles.MouseHover += new System.EventHandler(this.BtnSendFiles_MouseHover);
            // 
            // txtServerPathCountryDirectories
            // 
            this.txtServerPathCountryDirectories.AutoCompleteCustomSource.AddRange(new string[] {
            "C:\\NielsenAD\\CF",
            "\\\\athwinfsvp001\\File_Transfers\\EU Support Deployment\\Chris\\CF"});
            this.txtServerPathCountryDirectories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtServerPathCountryDirectories.Location = new System.Drawing.Point(98, 35);
            this.txtServerPathCountryDirectories.Name = "txtServerPathCountryDirectories";
            this.txtServerPathCountryDirectories.Size = new System.Drawing.Size(427, 20);
            this.txtServerPathCountryDirectories.TabIndex = 36;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status:";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(432, 41);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(0, 13);
            this.lbl_percent.TabIndex = 28;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 23);
            this.progressBar1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lbl_percent);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Location = new System.Drawing.Point(98, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 73);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress Bar";
            // 
            // lbl_source
            // 
            this.lbl_source.AutoEllipsis = true;
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(19, 16);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(44, 13);
            this.lbl_source.TabIndex = 38;
            this.lbl_source.Text = "Source:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoEllipsis = true;
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Location = new System.Drawing.Point(18, 38);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(63, 13);
            this.lbl_destination.TabIndex = 39;
            this.lbl_destination.Text = "Destination:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Location = new System.Drawing.Point(572, 117);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(50, 23);
            this.btn_cancel.TabIndex = 40;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_CorrectGetFiles
            // 
            this.btn_CorrectGetFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CorrectGetFiles.Location = new System.Drawing.Point(572, 11);
            this.btn_CorrectGetFiles.Name = "btn_CorrectGetFiles";
            this.btn_CorrectGetFiles.Size = new System.Drawing.Size(58, 23);
            this.btn_CorrectGetFiles.TabIndex = 41;
            this.btn_CorrectGetFiles.Text = "Get Files";
            this.btn_CorrectGetFiles.UseVisualStyleBackColor = true;
            this.btn_CorrectGetFiles.Click += new System.EventHandler(this.btn_CorrectGetFiles_Click);
            // 
            // btnGetCheckedItems
            // 
            this.btnGetCheckedItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetCheckedItems.AutoSize = true;
            this.btnGetCheckedItems.Location = new System.Drawing.Point(392, 126);
            this.btnGetCheckedItems.Name = "btnGetCheckedItems";
            this.btnGetCheckedItems.Size = new System.Drawing.Size(39, 23);
            this.btnGetCheckedItems.TabIndex = 10;
            this.btnGetCheckedItems.Text = ">>";
            this.btnGetCheckedItems.UseVisualStyleBackColor = true;
            this.btnGetCheckedItems.Click += new System.EventHandler(this.btnGetCheckedItems_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(22, 53);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(333, 274);
            this.checkedListBox1.TabIndex = 50;
            // 
            // ListBoxGetCheckedItemsold
            // 
            this.ListBoxGetCheckedItemsold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxGetCheckedItemsold.FormattingEnabled = true;
            this.ListBoxGetCheckedItemsold.Location = new System.Drawing.Point(516, 89);
            this.ListBoxGetCheckedItemsold.Name = "ListBoxGetCheckedItemsold";
            this.ListBoxGetCheckedItemsold.Size = new System.Drawing.Size(130, 238);
            this.ListBoxGetCheckedItemsold.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "All items";
            // 
            // txtBoxAllItems
            // 
            this.txtBoxAllItems.Location = new System.Drawing.Point(323, 28);
            this.txtBoxAllItems.Name = "txtBoxAllItems";
            this.txtBoxAllItems.ReadOnly = true;
            this.txtBoxAllItems.Size = new System.Drawing.Size(32, 20);
            this.txtBoxAllItems.TabIndex = 24;
            // 
            // Clear_ListBoxWithSourceFiels
            // 
            this.Clear_ListBoxWithSourceFiels.AutoSize = true;
            this.Clear_ListBoxWithSourceFiels.Location = new System.Drawing.Point(21, 350);
            this.Clear_ListBoxWithSourceFiels.Name = "Clear_ListBoxWithSourceFiels";
            this.Clear_ListBoxWithSourceFiels.Size = new System.Drawing.Size(75, 23);
            this.Clear_ListBoxWithSourceFiels.TabIndex = 1;
            this.Clear_ListBoxWithSourceFiels.Text = "Clear List";
            this.Clear_ListBoxWithSourceFiels.UseVisualStyleBackColor = true;
            this.Clear_ListBoxWithSourceFiels.Click += new System.EventHandler(this.Clear_ListBoxWithSourceFiels_Click);
            // 
            // ClearCheckedItems_ListboxWithSourceFiles
            // 
            this.ClearCheckedItems_ListboxWithSourceFiles.AutoSize = true;
            this.ClearCheckedItems_ListboxWithSourceFiles.Location = new System.Drawing.Point(205, 350);
            this.ClearCheckedItems_ListboxWithSourceFiles.Name = "ClearCheckedItems_ListboxWithSourceFiles";
            this.ClearCheckedItems_ListboxWithSourceFiles.Size = new System.Drawing.Size(122, 23);
            this.ClearCheckedItems_ListboxWithSourceFiles.TabIndex = 2;
            this.ClearCheckedItems_ListboxWithSourceFiles.Text = "Clear Checked Items";
            this.ClearCheckedItems_ListboxWithSourceFiles.UseVisualStyleBackColor = true;
            this.ClearCheckedItems_ListboxWithSourceFiles.Click += new System.EventHandler(this.ClearCheckedItems_ListboxWithSourceFiles_Click);
            // 
            // btnResetListWithSourceFiles
            // 
            this.btnResetListWithSourceFiles.AutoSize = true;
            this.btnResetListWithSourceFiles.Location = new System.Drawing.Point(115, 350);
            this.btnResetListWithSourceFiles.Name = "btnResetListWithSourceFiles";
            this.btnResetListWithSourceFiles.Size = new System.Drawing.Size(75, 23);
            this.btnResetListWithSourceFiles.TabIndex = 3;
            this.btnResetListWithSourceFiles.Text = "Reset List";
            this.btnResetListWithSourceFiles.UseVisualStyleBackColor = true;
            this.btnResetListWithSourceFiles.Click += new System.EventHandler(this.btnResetListWithSourceFiles_Click);
            // 
            // btn_Clear_Listbox_With_Checked_items
            // 
            this.btn_Clear_Listbox_With_Checked_items.Location = new System.Drawing.Point(468, 350);
            this.btn_Clear_Listbox_With_Checked_items.Name = "btn_Clear_Listbox_With_Checked_items";
            this.btn_Clear_Listbox_With_Checked_items.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_Listbox_With_Checked_items.TabIndex = 5;
            this.btn_Clear_Listbox_With_Checked_items.Text = "Clear List";
            this.btn_Clear_Listbox_With_Checked_items.UseVisualStyleBackColor = true;
            this.btn_Clear_Listbox_With_Checked_items.Click += new System.EventHandler(this.btn_Clear_Listbox_With_Checked_items_Click);
            // 
            // btn_Reset_ListBox_With_Checked_Items
            // 
            this.btn_Reset_ListBox_With_Checked_Items.Location = new System.Drawing.Point(555, 350);
            this.btn_Reset_ListBox_With_Checked_Items.Name = "btn_Reset_ListBox_With_Checked_Items";
            this.btn_Reset_ListBox_With_Checked_Items.Size = new System.Drawing.Size(67, 23);
            this.btn_Reset_ListBox_With_Checked_Items.TabIndex = 7;
            this.btn_Reset_ListBox_With_Checked_Items.Text = "Reset List";
            this.btn_Reset_ListBox_With_Checked_Items.UseVisualStyleBackColor = true;
            this.btn_Reset_ListBox_With_Checked_Items.Click += new System.EventHandler(this.btn_Reset_ListBox_With_Checked_Items_Click);
            // 
            // Clear_Listbox_With_CheckedItems
            // 
            this.Clear_Listbox_With_CheckedItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Clear_Listbox_With_CheckedItems.AutoSize = true;
            this.Clear_Listbox_With_CheckedItems.Location = new System.Drawing.Point(392, 222);
            this.Clear_Listbox_With_CheckedItems.Name = "Clear_Listbox_With_CheckedItems";
            this.Clear_Listbox_With_CheckedItems.Size = new System.Drawing.Size(39, 23);
            this.Clear_Listbox_With_CheckedItems.TabIndex = 6;
            this.Clear_Listbox_With_CheckedItems.Text = "<<";
            this.Clear_Listbox_With_CheckedItems.UseVisualStyleBackColor = true;
            this.Clear_Listbox_With_CheckedItems.Click += new System.EventHandler(this.Clear_Listbox_With_CheckedItems_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "All items";
            // 
            // txtBox_all_Items_in_ListBoxWithCheckedItems
            // 
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.Location = new System.Drawing.Point(769, 30);
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.Name = "txtBox_all_Items_in_ListBoxWithCheckedItems";
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.ReadOnly = true;
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.Size = new System.Drawing.Size(32, 20);
            this.txtBox_all_Items_in_ListBoxWithCheckedItems.TabIndex = 22;
            // 
            // ListBoxGetCheckedItems
            // 
            this.ListBoxGetCheckedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxGetCheckedItems.CheckOnClick = true;
            this.ListBoxGetCheckedItems.FormattingEnabled = true;
            this.ListBoxGetCheckedItems.Location = new System.Drawing.Point(468, 56);
            this.ListBoxGetCheckedItems.Name = "ListBoxGetCheckedItems";
            this.ListBoxGetCheckedItems.Size = new System.Drawing.Size(333, 274);
            this.ListBoxGetCheckedItems.TabIndex = 30;
            // 
            // btn_PassOneItem
            // 
            this.btn_PassOneItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_PassOneItem.AutoSize = true;
            this.btn_PassOneItem.Location = new System.Drawing.Point(392, 155);
            this.btn_PassOneItem.Name = "btn_PassOneItem";
            this.btn_PassOneItem.Size = new System.Drawing.Size(39, 23);
            this.btn_PassOneItem.TabIndex = 51;
            this.btn_PassOneItem.Text = ">";
            this.btn_PassOneItem.UseVisualStyleBackColor = true;
            this.btn_PassOneItem.Click += new System.EventHandler(this.btn_PassOneItem_Click);
            // 
            // btn_PassItemToTheLeftListBox
            // 
            this.btn_PassItemToTheLeftListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_PassItemToTheLeftListBox.AutoSize = true;
            this.btn_PassItemToTheLeftListBox.Location = new System.Drawing.Point(392, 193);
            this.btn_PassItemToTheLeftListBox.Name = "btn_PassItemToTheLeftListBox";
            this.btn_PassItemToTheLeftListBox.Size = new System.Drawing.Size(39, 23);
            this.btn_PassItemToTheLeftListBox.TabIndex = 53;
            this.btn_PassItemToTheLeftListBox.Text = "<";
            this.btn_PassItemToTheLeftListBox.UseVisualStyleBackColor = true;
            this.btn_PassItemToTheLeftListBox.Click += new System.EventHandler(this.btn_PassItemToTheLeftListBox_Click);
            // 
            // chkBox_AllChecked
            // 
            this.chkBox_AllChecked.AutoSize = true;
            this.chkBox_AllChecked.Location = new System.Drawing.Point(22, 30);
            this.chkBox_AllChecked.Name = "chkBox_AllChecked";
            this.chkBox_AllChecked.Size = new System.Drawing.Size(120, 17);
            this.chkBox_AllChecked.TabIndex = 57;
            this.chkBox_AllChecked.Text = "Check/Uncheck All";
            this.chkBox_AllChecked.UseVisualStyleBackColor = true;
            this.chkBox_AllChecked.Click += new System.EventHandler(this.chkBox_AllChecked_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(468, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 17);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "Check/Uncheck All";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.chkBox_AllChecked);
            this.groupBox1.Controls.Add(this.btn_PassItemToTheLeftListBox);
            this.groupBox1.Controls.Add(this.btn_PassOneItem);
            this.groupBox1.Controls.Add(this.ListBoxGetCheckedItems);
            this.groupBox1.Controls.Add(this.txtBox_all_Items_in_ListBoxWithCheckedItems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Clear_Listbox_With_CheckedItems);
            this.groupBox1.Controls.Add(this.btn_Reset_ListBox_With_Checked_Items);
            this.groupBox1.Controls.Add(this.btn_Clear_Listbox_With_Checked_items);
            this.groupBox1.Controls.Add(this.btnResetListWithSourceFiles);
            this.groupBox1.Controls.Add(this.ClearCheckedItems_ListboxWithSourceFiles);
            this.groupBox1.Controls.Add(this.Clear_ListBoxWithSourceFiels);
            this.groupBox1.Controls.Add(this.txtBoxAllItems);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListBoxGetCheckedItemsold);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.btnGetCheckedItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 392);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CorrectGetFiles);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.BtnSendFiles);
            this.panel1.Controls.Add(this.btnGetFiles);
            this.panel1.Controls.Add(this.lbl_destination);
            this.panel1.Controls.Add(this.txtBoxGetFiles);
            this.panel1.Controls.Add(this.lbl_source);
            this.panel1.Controls.Add(this.btnGetCountryDirectories);
            this.panel1.Controls.Add(this.txtServerPathCountryDirectories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 182);
            this.panel1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deployment YTDs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.TextBox txtBoxGetFiles;
        private System.Windows.Forms.Button btnGetCountryDirectories;
        private System.Windows.Forms.Button BtnSendFiles;
        private System.Windows.Forms.TextBox txtServerPathCountryDirectories;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_CorrectGetFiles;
        private System.Windows.Forms.Button btnGetCheckedItems;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox ListBoxGetCheckedItemsold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAllItems;
        private System.Windows.Forms.Button Clear_ListBoxWithSourceFiels;
        private System.Windows.Forms.Button ClearCheckedItems_ListboxWithSourceFiles;
        private System.Windows.Forms.Button btnResetListWithSourceFiles;
        private System.Windows.Forms.Button btn_Clear_Listbox_With_Checked_items;
        private System.Windows.Forms.Button btn_Reset_ListBox_With_Checked_Items;
        private System.Windows.Forms.Button Clear_Listbox_With_CheckedItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_all_Items_in_ListBoxWithCheckedItems;
        private System.Windows.Forms.CheckedListBox ListBoxGetCheckedItems;
        private System.Windows.Forms.Button btn_PassOneItem;
        private System.Windows.Forms.Button btn_PassItemToTheLeftListBox;
        private System.Windows.Forms.CheckBox chkBox_AllChecked;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

