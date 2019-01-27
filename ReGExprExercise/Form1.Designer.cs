namespace ReGExprExercise
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkRegExp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_IncludeDoWorker = new System.Windows.Forms.Button();
            this.txtBox_Source = new System.Windows.Forms.TextBox();
            this.lbl_source = new System.Windows.Forms.Label();
            this.txtbox_destination = new System.Windows.Forms.TextBox();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lbl_percent);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.lbl_destination);
            this.tabPage1.Controls.Add(this.txtbox_destination);
            this.tabPage1.Controls.Add(this.lbl_source);
            this.tabPage1.Controls.Add(this.txtBox_Source);
            this.tabPage1.Controls.Add(this.btn_IncludeDoWorker);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.checkRegExp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // checkRegExp
            // 
            this.checkRegExp.Location = new System.Drawing.Point(92, 77);
            this.checkRegExp.Name = "checkRegExp";
            this.checkRegExp.Size = new System.Drawing.Size(75, 23);
            this.checkRegExp.TabIndex = 32;
            this.checkRegExp.Text = "Check ReGEX";
            this.checkRegExp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_IncludeDoWorker
            // 
            this.btn_IncludeDoWorker.Location = new System.Drawing.Point(301, 77);
            this.btn_IncludeDoWorker.Name = "btn_IncludeDoWorker";
            this.btn_IncludeDoWorker.Size = new System.Drawing.Size(75, 23);
            this.btn_IncludeDoWorker.TabIndex = 34;
            this.btn_IncludeDoWorker.Text = "include worker";
            this.btn_IncludeDoWorker.UseVisualStyleBackColor = true;
            // 
            // txtBox_Source
            // 
            this.txtBox_Source.Location = new System.Drawing.Point(375, 206);
            this.txtBox_Source.Name = "txtBox_Source";
            this.txtBox_Source.Size = new System.Drawing.Size(245, 20);
            this.txtBox_Source.TabIndex = 38;
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(306, 206);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(41, 13);
            this.lbl_source.TabIndex = 39;
            this.lbl_source.Text = "Source";
            // 
            // txtbox_destination
            // 
            this.txtbox_destination.Location = new System.Drawing.Point(375, 232);
            this.txtbox_destination.Name = "txtbox_destination";
            this.txtbox_destination.Size = new System.Drawing.Size(245, 20);
            this.txtbox_destination.TabIndex = 40;
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Location = new System.Drawing.Point(306, 239);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(41, 13);
            this.lbl_destination.TabIndex = 41;
            this.lbl_destination.Text = "Source";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "copy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 43;
            this.button5.Text = "cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Load Progress Bar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(293, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 23);
            this.progressBar1.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(314, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 13);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Working...";
            this.lblStatus.Visible = false;
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(647, 306);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(35, 13);
            this.lbl_percent.TabIndex = 37;
            this.lbl_percent.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.TextBox txtbox_destination;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.TextBox txtBox_Source;
        private System.Windows.Forms.Button btn_IncludeDoWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkRegExp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
    }
}

