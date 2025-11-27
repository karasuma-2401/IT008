namespace Bai03
{
    public partial class FormWindowsMediaPlayer : Form
    {
        public FormWindowsMediaPlayer()
        {
            InitializeComponent();

        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file|*.avi|MPEG File|*.mpeg|"
                + "WAV file|*.wav|MIDI file|*.midi|"
                + "MP3 file|*.mp3|MP4 file|*.mp4";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWMPMain.URL = dlg.FileName;
            }
        }
        private void FormWindowsMediaPlayer_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            tsslDate.Text = "Hôm nay " + date.ToString("dd/MM/yyyy")
                + " - Bây giờ " + date.ToString("hh:mm:ss tt");
        }
    }
}