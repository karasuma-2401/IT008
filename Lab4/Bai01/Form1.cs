namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file|*.avi|MPEG File|*.mpeg|"
                + "WAV file|*.wav|MIDI file|*.midi|"
                + "MP3 file|*.mp3|MP4 file|*.mp4";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            toolStripStatusLabel1.Text = "Hôm nay "+ date.ToString("dd/MM/yyyy")
                + " - Bây giờ " + date.ToString("hh:mm:ss tt");
        }
    }
}