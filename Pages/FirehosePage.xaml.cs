using System.Threading.Tasks;
using System.Windows.Controls;
using UserControl = System.Windows.Controls.UserControl;
using Microsoft.Win32;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using OplusEdlTool.Services;

namespace OplusEdlTool.Pages
{
    public partial class FirehosePage : UserControl
    {
        private readonly EdlService edl;
        private readonly System.Action<string> log;
        public FirehosePage(EdlService edl, System.Action<string> logger)
        {
            InitializeComponent();
            this.edl = edl; this.log = logger;
        }
        private void PickDevPrg_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog(); if (dlg.ShowDialog() == true) DevPrg.Text = dlg.FileName;
        }
        private void PickDigest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog(); if (dlg.ShowDialog() == true) Digest.Text = dlg.FileName;
        }
        private void PickSig_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog(); if (dlg.ShowDialog() == true) Sig.Text = dlg.FileName;
        }
        private async void Run_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            log("waiting for edl port (9008)...");
            var port = await edl.WaitForEdlPortAsync();
            log("device connected: " + port);
            log("send device programmer...");
            var ok = await edl.SendProgrammerAsync(port, DevPrg.Text);
            if (!ok) { log("failed"); return; }
            log("send digest...");
            await edl.SendDigestsAsync(port, Digest.Text);
            log("send verify command...");
            ok = await edl.SendVerifyAsync(port);
            if (!ok) { log("failed"); return; }
            log("send sig...");
            ok = await edl.SendDigestsAsync(port, Sig.Text);
            if (!ok) { log("failed"); return; }
            log("send sha256init command...");
            ok = await edl.SendSha256InitAsync(port);
            if (!ok) { log("failed"); return; }
            log("configure...");
            ok = await edl.ConfigureAsync(port);
            if (!ok) { log("failed"); return; }
            log("all done");
        }
    }
}
