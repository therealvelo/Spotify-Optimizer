using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Spotify_Optimizer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Stripped();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Focus();
            if(File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat"))
            {
                Process process = new Process();
                process.StartInfo.FileName = Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat";
                process.StartInfo.Arguments = "/c";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                label1.Text = "In Progress...";
                process.WaitForExit();
                label1.Text = "Done!";
                timer1.Enabled = true;
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat");
            }
            else
            {
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("https://download848.mediafire.com/i086iz54dhbg/gh4660he0gg7umh/downgrade.bat", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat");
                    }
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd";
                    process.StartInfo.Arguments = "/c" + Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    label1.Text = "In Progress...";
                    process.WaitForExit();
                    label1.Text = "Done!";
                    timer1.Enabled = true;
                    File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\downgrade.bat");
                }
                catch(Exception)
                {
                    MessageBox.Show("Offline!");
                }
            }
            label2.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Focus();
            foreach (Process proc in Process.GetProcessesByName("Spotify"))
            {
                proc.Kill();
            }
            retry:
            try
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\chrome_elf.dll");
                using (WebClient webclient = new WebClient())
                {
                    webclient.DownloadFile("https://download1580.mediafire.com/7wxn33xdxpjg/ug2u1s91jv5lsko/config.ini", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\config.ini");
                    webclient.DownloadFile("https://download1653.mediafire.com/vrk5c6vfm3yg/bpl68c1laflwj61/chrome_elf.dll", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\chrome_elf.dll");
                }
                label1.Text = "Ads Blocked";
                timer1.Enabled = true;
            }
            catch(Exception)
            {
                goto retry;
            }
        }

        private void Stripped()
        {
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\buddy-list.spa"))
            {
                checkBox1.Checked = true;
            }
            else if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\findfriends.spa"))
            {
                checkBox1.Checked = true;
            }
            else
            {
                
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\radio-hub.spa"))
            {
                checkBox2.Checked = true;
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection.spa"))
            {
                checkBox3.Checked = true;
            }
            else if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-album.spa"))
            {
                checkBox3.Checked = true;
            }
            else if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-artist.spa"))
            {
                checkBox3.Checked = true;
            }
            else if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-songs.spa"))
            {
                checkBox3.Checked = true;
            }
            else
            {

            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\browse.spa"))
            {
                checkBox4.Checked = true;
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\login.spa"))
            {
                checkBox5.Checked = true;
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\settings.spa"))
            {
                checkBox6.Checked = true;
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\glue-resources.spa"))
            {
                checkBox7.Checked = true;
            }
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\station.spa"))
            {
                checkBox8.Checked = true;
            }
            else if (File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\stations.spa"))
            {
                checkBox8.Checked = true;
            }
            else
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://www.paypal.com/paypalme/asher790");
            }
            catch(Exception)
            {
                Clipboard.SetText("https://www.paypal.com/paypalme/asher790");
                MessageBox.Show("Unable to open default web browser. Link copied to clipboard.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Focus();
            if (checkBox1.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\buddy-list.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\findfriends.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\buddy-list.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1595.mediafire.com/vmr0ju75d4ag/m29uov4zied5f4h/buddy-list.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\buddy-list.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\findfriends.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1582.mediafire.com/uwb4btvljepg/3sh6h4bnnzj2xsu/findfriends.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\findfriends.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox2.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\radio-hub.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\radio-hub.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1509.mediafire.com/ws7rczkwt1pg/tqdbc4d8ayt4alh/radio-hub.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\radio-hub.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox3.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-album.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-artist.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-songs.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1519.mediafire.com/b2u2mdeki3ag/ojphudp9qrdet7a/collection.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-album.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1521.mediafire.com/sgbgyn6gneug/ingg63egx6zfuh1/collection-album.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-album.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-artist.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1585.mediafire.com/zrexqozm8ogg/74q61j76ewqfok1/collection-artist.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-artist.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-songs.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download855.mediafire.com/4jd6qklj1b6g/btwab8yb1epk5k3/collection-songs.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\collection-songs.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox4.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\browse.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\chart.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\browse.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1522.mediafire.com/6qb89eby8blg/ds3rpsr5dw1mvf7/browse.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\browse.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\chart.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1587.mediafire.com/9eulepftsn8g/bsogtgp9zdqpllj/chart.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\chart.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox5.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\login.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\login.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1499.mediafire.com/3iajfsu07wyg/9jaqeo79oleb162/login.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\login.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox6.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\settings.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\settings.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1324.mediafire.com/0h08e23rqmeg/1ij0ick74rsfh1r/settings.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\settings.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox7.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\glue-resources.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\glue-resources.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download946.mediafire.com/2hhfdqgx2xrg/04feqt2ofgimpax/glue-resources.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\glue-resources.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox8.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\station.spa");
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\sstations.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\station.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download941.mediafire.com/v6uhxbb11eng/rchz0bmpg9v74dg/station.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\station.spa");
                    }
                }
                else
                {

                }
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\stations.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download946.mediafire.com/o1g5bqnubabg/njgejhvfmwq14uo/stations.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\stations.spa");
                    }
                }
                else
                {

                }
            }
            if (checkBox9.Checked == false)
            {
                File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\genre.spa");
            }
            else
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\genre.spa"))
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.DownloadFile("https://download1647.mediafire.com/jeets55323rg/qji4tirxygqeclk/genre.spa", Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\genre.spa");
                    }
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Focus();
            File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\error.spa");
            File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\concert.spa");
            File.Delete(Environment.GetEnvironmentVariable("appdata") + @"\Spotify\Apps\concerts.spa");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == false)
            {
                checkBox9.Checked = false;
            }
            else
            {

            }
        }
    }
}
