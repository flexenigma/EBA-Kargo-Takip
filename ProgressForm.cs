using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public partial class ProgressForm : Form
{
    public ProgressForm()
    {
        InitializeComponent();
    }

    private async void btnStartProcess_Click(object sender, EventArgs e)
    {
        progressBar1.Style = ProgressBarStyle.Marquee;
        await Task.Run(() => SimulateLongRunningProcess());
        progressBar1.Style = ProgressBarStyle.Blocks;
        MessageBox.Show("İşlem tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void SimulateLongRunningProcess()
    {
        System.Threading.Thread.Sleep(3000);  // 3 saniye bekleme
    }
}
