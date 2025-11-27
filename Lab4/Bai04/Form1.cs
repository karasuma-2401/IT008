namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(btnCopy, "Nhấn để bắt đầu sao chép tập tin từ Nguồn sang Đích");
        }
        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourceDir = txtSource.Text; 
            string destDir = txtDestination.Text; 

            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(destDir))
            {
                MessageBox.Show("Thư mục đích không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] files = Directory.GetFiles(sourceDir);
            if (files.Length == 0)
            {
                MessageBox.Show("Thư mục nguồn không chứa tập tin nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            progressBarTotal.Maximum = files.Length;
            progressBarTotal.Value = 0;

            btnCopy.Enabled = false;

            try
            {
                foreach (string sourceFile in files)
                {
                    string fileName = Path.GetFileName(sourceFile);
                    string destFile = Path.Combine(destDir, fileName);

                    tssl_Copying.Text = $"Đang sao chép: {sourceFile}";
                    toolTip1.SetToolTip(progressBarTotal, $"Đang sao chép: {sourceFile}");

                    Application.DoEvents(); 
                    File.Copy(sourceFile, destFile, true);
                    progressBarTotal.Value++;
                }
                MessageBox.Show("Quá trình sao chép đã hoàn thành!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình sao chép: {ex.Message}", "Lỗi Sao Chép", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCopy.Enabled = true;
            }
        }
    }
}
