namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (videoFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoDirectory.Text = videoFileDialog.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (videoFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoDirectory.Text = videoFileDialog.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void videoSaveButton_Click(object sender, EventArgs e)
        {
            if (videoFolderDialog.ShowDialog() == DialogResult.OK)
            {
                videoSaveDestination.Text = videoFolderDialog.SelectedPath;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void videoSaveDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void videoSaveDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void videoFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
