using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using Information_Gatherer.Properties;
using System.Data.SqlTypes;

namespace Information_Gatherer
{
    public partial class Information_Gatherer : Form
    {

        public string OnClientClick { get; private set; }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        public static bool IsInternetAvailable()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }

        public Information_Gatherer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Settings f2 = new Settings(this);

            f2.checkBox1.Checked = Properties.Settings.Default.checkBox1;
            f2.checkBox2.Checked = Properties.Settings.Default.checkBox2;
            f2.checkBox3.Checked = Properties.Settings.Default.checkBox3;
            f2.checkBox4.Checked = Properties.Settings.Default.checkBox4;
            f2.checkBox5.Checked = Properties.Settings.Default.checkBox5;
            f2.checkBox6.Checked = Properties.Settings.Default.checkBox6;
            f2.checkBox7.Checked = Properties.Settings.Default.checkBox7;
            f2.checkBox8.Checked = Properties.Settings.Default.checkBox8;

            this.Location = new Point(Properties.Settings.Default.PX, Properties.Settings.Default.PY);

            if (IsInternetAvailable() == true)
            {
                //MessageBox.Show("You have a Internet Connection - Ping Initilization has started", "Internet Check", MessageBoxButtons.OK);
            }
            if (IsInternetAvailable() == false)
            {
                DialogResult dialogResult = MessageBox.Show("Your Network Interface is not enabled/connected" + "\nPing Initilization has failed - Information Gatherer will not initilize ping test do you still want to continue?", "Network Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                }
                if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Settings f2 = new Settings(this);

            Properties.Settings.Default.PX = this.Location.X;
            Properties.Settings.Default.PY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            if (button1.Text == "Check if IP Matches What's My IP")
            {
                richTextBox1.Text = "Gathering Information";
                button1.Text = "Terminate Information";
                button1.BackColor = Color.Red;

                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }

                String direction = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    direction = stream.ReadToEnd();
                }

                int first = direction.IndexOf("Address: ") + 9;
                int last = direction.LastIndexOf("</body>");
                direction = direction.Substring(first, last - first);

                richTextBox1.Text = "Your Public IP: "+direction+"\nYour Local IP: "+localIP+"\n\n"+"If your IP is a IPv6 then check 'Whats my IP *If IPV6*' and none of the others!\nWARNING: Do not give your public or local IP to anyone!";
            }
            else if (button1.Text == "Terminate Information")
            {
                richTextBox1.Text = "Connection closing!";
                button1.Text = "Check if IP Matches What's My IP";
                richTextBox1.Text = "This app is called 'Information Gatherer' it is intended to give you your current IP (with or without a VPN) to give you a accurate reading of if you are or not leaking VPN information that can expose your real IP.\n\n* All Data is Terminated automatically *including user settings\n* Nothing is stored information is always Terminated - no need to manually terminate app will auto terminate on exit if connected.";
                button1.BackColor = Color.Green;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://dnsleaktest.com");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ipleak.net");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsmyip.org/");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatismyipaddress.com/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsInternetAvailable() == true)
            {
                lblPing.Text = "My Ping to Speedtest is: " + new Ping().Send("www.speedtest.net").RoundtripTime.ToString() + "ms";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
            //MessageBox.Show("Why is a IP important to hide?\n\nA IP is a unique address designated for you and you only. If you do anything on that IP it tracks back to your ISP and then back to you. If you torrent or want to unlock geo-blocked content you need to change your IP to 1: be safe or 2: unlock the geo-blocked content.\n\nUse the resources located in this app to know for certain if you are safe - read 'Whats a DNS leak' if you do not know what a DNS leak is.", "Help Menu");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
            //MessageBox.Show("A DNS leak is when your VPN is leaking your real IP which in turn is counter productive to what a VPN is trying to do. If you use the DNS Leak Tests above and it ever says your ISPs name and or IP then you are leaking DNS and should reconnect your VPN and test again.", "DNS Leak");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Settings f2 = new Settings(this);
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPing_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (button1.Text == "Terminate Information")
                {
                    richTextBox1.Text = "App Exiting - Please Wait\n\nInformation Closing";
                    await Task.Delay(250);
                    button1.BackColor = Color.Green;
                    button1.Text = "Check if IP Matches What's My IP";
                    await Task.Delay(250);
                    Application.Exit();
                }
                if (button1.Text == "Check if IP Matches What's My IP")
                {
                    Application.Exit();
                }
            if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            await Task.Delay(50);
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
