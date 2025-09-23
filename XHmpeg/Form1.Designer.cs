namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabVideo = new TabControl();
            tabPage1 = new TabPage();
            label21 = new Label();
            textBox8 = new TextBox();
            progressBar1 = new ProgressBar();
            groupBox3 = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            fileSize = new Label();
            label10 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            label6 = new Label();
            label11 = new Label();
            checkBox1 = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            videoSaveButton = new Button();
            label5 = new Label();
            videoSaveDestination = new TextBox();
            groupBox1 = new GroupBox();
            detectedFormat = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            fileTypeLabel = new Label();
            label3 = new Label();
            videoBrowseButton = new Button();
            label1 = new Label();
            videoDirectory = new TextBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            videoFileDialog = new OpenFileDialog();
            audioFileDialog = new OpenFileDialog();
            videoFolderDialog = new FolderBrowserDialog();
            label22 = new Label();
            tabVideo.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabVideo
            // 
            tabVideo.Controls.Add(tabPage1);
            tabVideo.Controls.Add(tabPage2);
            tabVideo.Location = new Point(12, 7);
            tabVideo.Name = "tabVideo";
            tabVideo.SelectedIndex = 0;
            tabVideo.Size = new Size(776, 574);
            tabVideo.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(fileSize);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(videoSaveButton);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(videoSaveDestination);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(videoBrowseButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(videoDirectory);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 326);
            label21.Name = "label21";
            label21.Size = new Size(60, 15);
            label21.TabIndex = 17;
            label21.Text = "File Name";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(20, 344);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(320, 29);
            textBox8.TabIndex = 16;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(147, 496);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(390, 29);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(562, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 161);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Length";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(57, 131);
            label20.Name = "label20";
            label20.Size = new Size(15, 15);
            label20.TabIndex = 13;
            label20.Text = "[]";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 131);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 12;
            label19.Text = "Length:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 76);
            label16.Name = "label16";
            label16.Size = new Size(57, 15);
            label16.TabIndex = 11;
            label16.Text = "End Time";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(74, 96);
            label17.Name = "label17";
            label17.Size = new Size(10, 15);
            label17.TabIndex = 10;
            label17.Text = ":";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(36, 96);
            label18.Name = "label18";
            label18.Size = new Size(10, 15);
            label18.TabIndex = 9;
            label18.Text = ":";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(83, 93);
            textBox5.MaxLength = 2;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "SS";
            textBox5.Size = new Size(29, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(45, 93);
            textBox6.MaxLength = 2;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "MM";
            textBox6.Size = new Size(29, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(7, 93);
            textBox7.MaxLength = 2;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "HH";
            textBox7.Size = new Size(29, 23);
            textBox7.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 32);
            label15.Name = "label15";
            label15.Size = new Size(61, 15);
            label15.TabIndex = 5;
            label15.Text = "Start Time";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(75, 53);
            label14.Name = "label14";
            label14.Size = new Size(10, 15);
            label14.TabIndex = 4;
            label14.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 53);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 3;
            label13.Text = ":";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 50);
            textBox4.MaxLength = 2;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "SS";
            textBox4.Size = new Size(29, 23);
            textBox4.TabIndex = 2;
            textBox4.Text = "00";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(46, 50);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "MM";
            textBox3.Size = new Size(29, 23);
            textBox3.TabIndex = 1;
            textBox3.Text = "00";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 50);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "HH";
            textBox1.Size = new Size(29, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "00";
            // 
            // fileSize
            // 
            fileSize.AutoSize = true;
            fileSize.Location = new Point(79, 475);
            fileSize.Name = "fileSize";
            fileSize.Size = new Size(15, 15);
            fileSize.TabIndex = 13;
            fileSize.Text = "[]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 476);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 12;
            label10.Text = "File size: ";
            // 
            // button1
            // 
            button1.Location = new Point(20, 494);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 11;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(562, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 240);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quality";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(107, 47);
            numericUpDown4.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(73, 23);
            numericUpDown4.TabIndex = 24;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(6, 47);
            numericUpDown3.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(77, 23);
            numericUpDown3.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(6, 197);
            numericUpDown2.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(119, 23);
            numericUpDown2.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 135);
            numericUpDown1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(128, 201);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 20;
            label12.Text = "kbps";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 179);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 18;
            label6.Text = "Bitrate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(78, 138);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 17;
            label11.Text = "FPS";
            label11.Click += label11_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(17, 74);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Lock aspect ratio";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 49);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 14;
            label9.Text = "x";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 27);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 13;
            label8.Text = "Height";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Width";
            // 
            // videoSaveButton
            // 
            videoSaveButton.Location = new Point(20, 231);
            videoSaveButton.Name = "videoSaveButton";
            videoSaveButton.Size = new Size(320, 39);
            videoSaveButton.TabIndex = 7;
            videoSaveButton.Text = "Browse Folder";
            videoSaveButton.UseVisualStyleBackColor = true;
            videoSaveButton.Click += videoSaveButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 178);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "Output Folder";
            // 
            // videoSaveDestination
            // 
            videoSaveDestination.Font = new Font("Segoe UI", 12F);
            videoSaveDestination.Location = new Point(20, 196);
            videoSaveDestination.Name = "videoSaveDestination";
            videoSaveDestination.Size = new Size(320, 29);
            videoSaveDestination.TabIndex = 5;
            videoSaveDestination.TextChanged += videoSaveDestination_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(detectedFormat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(fileTypeLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(562, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 121);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Format Conversion";
            // 
            // detectedFormat
            // 
            detectedFormat.AutoSize = true;
            detectedFormat.Location = new Point(157, 29);
            detectedFormat.Name = "detectedFormat";
            detectedFormat.Size = new Size(15, 15);
            detectedFormat.TabIndex = 4;
            detectedFormat.Text = "[]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 3;
            label4.Text = "Choose format to convert to...";
            label4.Click += label4_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mov", "mp4", "mkv", "avi" });
            comboBox1.Location = new Point(6, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 2;
            // 
            // fileTypeLabel
            // 
            fileTypeLabel.AutoSize = true;
            fileTypeLabel.Location = new Point(145, 29);
            fileTypeLabel.Name = "fileTypeLabel";
            fileTypeLabel.Size = new Size(0, 15);
            fileTypeLabel.TabIndex = 1;
            fileTypeLabel.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Format detected:";
            // 
            // videoBrowseButton
            // 
            videoBrowseButton.Location = new Point(20, 88);
            videoBrowseButton.Name = "videoBrowseButton";
            videoBrowseButton.Size = new Size(320, 39);
            videoBrowseButton.TabIndex = 3;
            videoBrowseButton.Text = "Browse for Video File";
            videoBrowseButton.UseVisualStyleBackColor = true;
            videoBrowseButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Input Video File";
            // 
            // videoDirectory
            // 
            videoDirectory.Font = new Font("Segoe UI", 12F);
            videoDirectory.Location = new Point(20, 53);
            videoDirectory.Name = "videoDirectory";
            videoDirectory.Size = new Size(320, 29);
            videoDirectory.TabIndex = 1;
            videoDirectory.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Audio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(20, 89);
            button3.Name = "button3";
            button3.Size = new Size(320, 39);
            button3.TabIndex = 6;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 36);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 5;
            label2.Text = "Choose audio file...";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(20, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 29);
            textBox2.TabIndex = 4;
            // 
            // videoFileDialog
            // 
            videoFileDialog.FileName = "videoFileDialog";
            videoFileDialog.Filter = "Video|*.mp4;*.mkv;*.avi;*.mov|All files|*.*";
            videoFileDialog.Title = "Choose Video";
            videoFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // audioFileDialog
            // 
            audioFileDialog.FileName = "audioFileDialog";
            audioFileDialog.Title = "Choose Audio";
            // 
            // videoFolderDialog
            // 
            videoFolderDialog.HelpRequest += videoFolderDialog_HelpRequest;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(9, 117);
            label22.Name = "label22";
            label22.Size = new Size(66, 15);
            label22.TabIndex = 25;
            label22.Text = "Frame Rate";
            label22.Click += label22_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(tabVideo);
            MaximizeBox = false;
            MaximumSize = new Size(816, 632);
            MinimumSize = new Size(816, 632);
            Name = "Form1";
            Text = "XHmpeg";
            Load += Form1_Load;
            tabVideo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabVideo;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox videoDirectory;
        private Label label1;
        private OpenFileDialog videoFileDialog;
        private Button videoBrowseButton;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private OpenFileDialog audioFileDialog;
        private GroupBox groupBox1;
        private Label fileTypeLabel;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button videoSaveButton;
        private Label label5;
        private TextBox videoSaveDestination;
        private SaveFileDialog videoSaveDialog;
        private GroupBox groupBox2;
        private Label detectedFormat;
        private CheckBox checkBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button1;
        private Label fileSize;
        private Label label10;
        private Label label6;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label15;
        private Label label14;
        private Label label13;
        private ProgressBar progressBar1;
        private Label label19;
        private Label label20;
        private FolderBrowserDialog videoFolderDialog;
        private Label label21;
        private TextBox textBox8;
        private Label label22;
    }
}
