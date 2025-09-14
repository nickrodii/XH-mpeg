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
            videoSaveButton = new Button();
            label5 = new Label();
            videoSaveDestination = new TextBox();
            groupBox1 = new GroupBox();
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
            videoSaveDialog = new SaveFileDialog();
            tabVideo.SuspendLayout();
            tabPage1.SuspendLayout();
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
            label5.Size = new Size(149, 15);
            label5.TabIndex = 6;
            label5.Text = "Choose folder to save file...";
            // 
            // videoSaveDestination
            // 
            videoSaveDestination.Font = new Font("Segoe UI", 12F);
            videoSaveDestination.Location = new Point(20, 196);
            videoSaveDestination.Name = "videoSaveDestination";
            videoSaveDestination.Size = new Size(320, 29);
            videoSaveDestination.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(fileTypeLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(562, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 279);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Conversion";
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
            comboBox1.Items.AddRange(new object[] { "mov", "mp4", "flv", "avi" });
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
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Choose video file...";
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
            videoFileDialog.Title = "Choose Video";
            videoFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // audioFileDialog
            // 
            audioFileDialog.FileName = "audioFileDialog";
            audioFileDialog.Title = "Choose Audio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(tabVideo);
            Name = "Form1";
            Text = "XH mpeg";
            Load += Form1_Load;
            tabVideo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}
