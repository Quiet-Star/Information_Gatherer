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
    public partial class Settings : Form
    {
        Information_Gatherer f1;
        public Settings(Information_Gatherer frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.checkBox1;
            checkBox2.Checked = Properties.Settings.Default.checkBox2;
            checkBox3.Checked = Properties.Settings.Default.checkBox3;
            checkBox4.Checked = Properties.Settings.Default.checkBox4;
            checkBox5.Checked = Properties.Settings.Default.checkBox5;
            checkBox6.Checked = Properties.Settings.Default.checkBox6;
            checkBox7.Checked = Properties.Settings.Default.checkBox7;
            checkBox8.Checked = Properties.Settings.Default.checkBox8;
        }

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.checkBox1 = checkBox1.Checked;
            Properties.Settings.Default.checkBox2 = checkBox2.Checked;
            Properties.Settings.Default.checkBox3 = checkBox3.Checked;
            Properties.Settings.Default.checkBox4 = checkBox4.Checked;
            Properties.Settings.Default.checkBox5 = checkBox5.Checked;
            Properties.Settings.Default.checkBox6 = checkBox6.Checked;
            Properties.Settings.Default.checkBox7 = checkBox7.Checked;
            Properties.Settings.Default.checkBox8 = checkBox8.Checked;

            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                f1.button1.Enabled = true;
            }
            if (checkBox1.Checked == true)
            {
                f1.button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                f1.button2.Enabled = true;
                f1.button3.Enabled = true;
                f1.button2.Visible = true;
                f1.button3.Visible = true;
                f1.button4.Location = new Point(13, 172);
                f1.button5.Location = new Point(13, 222);
            }
            if (checkBox2.Checked == true)
            {
                f1.button2.Enabled = false;
                f1.button3.Enabled = false;
                f1.button2.Visible = false;
                f1.button3.Visible = false;
                f1.button4.Location = new Point(169, 172);
                f1.button5.Location = new Point(169, 222);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                f1.button4.Enabled = true;
                f1.button5.Enabled = true;
                f1.button4.Visible = true;
                f1.button5.Visible = true;
            }
            if (checkBox3.Checked == true)
            {
                f1.button4.Enabled = false;
                f1.button5.Enabled = false;
                f1.button4.Visible = false;
                f1.button5.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                f1.button6.Enabled = false;
            }
            else if (checkBox4.Checked == false)
            {
                f1.button6.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                f1.button7.Enabled = false;
            }
            if (checkBox5.Checked == false)
            {
                f1.button7.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                this.BackColor = Color.Aqua;
                this.f1.BackColor = Color.Aqua;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.checkBox4.ForeColor = Color.Black;
                this.checkBox5.ForeColor = Color.Black;
                this.checkBox6.ForeColor = Color.Black;
                this.checkBox7.ForeColor = Color.Black;
                this.f1.button2.BackColor = Color.White;
                this.f1.button3.BackColor = Color.White;
                this.f1.button4.BackColor = Color.White;
                this.f1.button5.BackColor = Color.White;
                this.f1.button6.BackColor = Color.White;
                this.f1.button7.BackColor = Color.White;
                this.f1.richTextBox1.BackColor = Color.White;
                this.f1.lblPing.ForeColor = Color.Black;
                this.f1.lblPing.BackColor = Color.Aqua;
                this.f1.label1.ForeColor = Color.Black;
                this.f1.label1.BackColor = Color.Aqua;
            }
            if (checkBox6.Checked == false)
            {
                this.BackColor = Color.Black;
                this.f1.BackColor = Color.Black;
                this.checkBox1.ForeColor = Color.White;
                this.checkBox2.ForeColor = Color.White;
                this.checkBox3.ForeColor = Color.White;
                this.checkBox4.ForeColor = Color.White;
                this.checkBox5.ForeColor = Color.White;
                this.checkBox6.ForeColor = Color.White;
                this.checkBox7.ForeColor = Color.White;
                this.f1.button2.BackColor = Color.DimGray;
                this.f1.button3.BackColor = Color.DimGray;
                this.f1.button4.BackColor = Color.DimGray;
                this.f1.button5.BackColor = Color.DimGray;
                this.f1.button6.BackColor = Color.DimGray;
                this.f1.button7.BackColor = Color.DimGray;
                this.f1.lblPing.ForeColor = Color.DimGray;
                this.f1.richTextBox1.BackColor = Color.DimGray;
                this.f1.lblPing.BackColor = Color.Black;
                this.f1.label1.ForeColor = Color.White;
                this.f1.label1.BackColor = Color.Black;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox6.Enabled = false;
                checkBox6.Visible = false;
                checkBox7.Location = new Point(179, 317);
            }
            if (checkBox7.Checked == false)
            {
                checkBox6.Enabled = true;
                checkBox6.Visible = true;
                checkBox7.Location = new Point(257, 340);
            }

        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                f1.button6.Enabled = false;
                f1.button6.Visible = false;
            }
            if (checkBox4.Checked == false)
            {
                f1.button6.Enabled = true;
                f1.button6.Visible = true;
            }
            
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                f1.button7.Enabled = false;
                f1.button7.Visible = false;
            }
            if (checkBox5.Checked == false)
            {
                f1.button7.Enabled = true;
                f1.button7.Visible = true;
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                //this.f1.BackColor = Color.Coral;
                this.BackColor = Color.Coral;
                this.checkBox1.ForeColor = Color.Black;
                this.checkBox2.ForeColor = Color.Black;
                this.checkBox3.ForeColor = Color.Black;
                this.checkBox4.ForeColor = Color.Black;
                this.checkBox5.ForeColor = Color.Black;
                this.checkBox6.ForeColor = Color.Black;
                this.checkBox7.ForeColor = Color.Black;
                this.checkBox8.ForeColor = Color.Black;
                this.f1.button2.BackColor = Color.White;
                this.f1.button3.BackColor = Color.White;
                this.f1.button4.BackColor = Color.White;
                this.f1.button5.BackColor = Color.White;
                this.f1.button6.BackColor = Color.White;
                this.f1.button7.BackColor = Color.White;
                this.f1.button8.BackColor = Color.White;
                this.f1.button9.BackColor = Color.White;
                this.f1.button10.BackColor = Color.White;
                this.f1.button8.ForeColor = Color.Black;
                this.f1.button9.ForeColor = Color.Black;
                this.f1.button10.ForeColor = Color.Black;
                this.f1.richTextBox1.BackColor = Color.White;
                this.f1.lblPing.ForeColor = Color.Coral;
                this.f1.label1.ForeColor = Color.Coral;
                this.f1.label2.ForeColor = Color.Coral;
            }
            if (checkBox6.Checked == false)
            {
                //this.f1.BackColor = Color.Black;
                this.BackColor = Color.Black;
                this.checkBox1.ForeColor = Color.White;
                this.checkBox2.ForeColor = Color.White;
                this.checkBox3.ForeColor = Color.White;
                this.checkBox4.ForeColor = Color.White;
                this.checkBox5.ForeColor = Color.White;
                this.checkBox6.ForeColor = Color.White;
                this.checkBox7.ForeColor = Color.White;
                this.checkBox8.ForeColor = Color.White;
                this.f1.button2.BackColor = Color.DimGray;
                this.f1.button3.BackColor = Color.DimGray;
                this.f1.button4.BackColor = Color.DimGray;
                this.f1.button5.BackColor = Color.DimGray;
                this.f1.button6.BackColor = Color.DimGray;
                this.f1.button7.BackColor = Color.DimGray;
                this.f1.button8.BackColor = Color.DimGray;
                this.f1.button9.BackColor = Color.DimGray;
                this.f1.button10.BackColor = Color.DimGray;
                this.f1.button8.ForeColor = Color.White;
                this.f1.button9.ForeColor = Color.White;
                this.f1.button10.ForeColor = Color.White;
                this.f1.lblPing.ForeColor = Color.DimGray;
                this.f1.richTextBox1.BackColor = Color.DimGray;
                this.f1.lblPing.ForeColor = Color.White;
                this.f1.label1.ForeColor = Color.White;
                this.f1.label2.ForeColor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                f1.button1.Enabled = false;
            }
            if (checkBox1.Checked == false)
            {
                f1.button1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                f1.button2.Enabled = false;
                f1.button3.Enabled = false;
                f1.button2.Visible = false;
                f1.button3.Visible = false;
                f1.button4.Location = new Point(169, 141);
                f1.button5.Location = new Point(169, 191);
            }
            if (checkBox2.Checked == false)
            {
                f1.button2.Enabled = true;
                f1.button3.Enabled = true;
                f1.button2.Visible = true;
                f1.button3.Visible = true;
                f1.button4.Location = new Point(13, 141);
                f1.button5.Location = new Point(13, 191);
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                f1.button4.Enabled = false;
                f1.button5.Enabled = false;
                f1.button4.Visible = false;
                f1.button5.Visible = false;
            }
            if (checkBox3.Checked == false)
            {
                f1.button4.Enabled = true;
                f1.button5.Enabled = true;
                f1.button4.Visible = true;
                f1.button5.Visible = true;
            }
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox6.Enabled = false;
                checkBox6.Visible = false;
                checkBox7.Location = new Point(8, 12);
            }
            if (checkBox7.Checked == false)
            {
                checkBox6.Enabled = true;
                checkBox6.Visible = true;
                checkBox7.Location = new Point(8, 68);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == false)
            {
                f1.timer2.Enabled = false;
                f1.label2.Text = "IP: 000.000.000.000";
            }
            if (checkBox8.Checked == true)
            {
                f1.timer2.Enabled = true;
                f1.label2.Enabled = true;
                f1.label2.Visible = true;
                String direction = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    direction = stream.ReadToEnd();
                }

                //Search for the ip in the html
                int first = direction.IndexOf("Address: ") + 9;
                int last = direction.LastIndexOf("</body>");
                direction = direction.Substring(first, last - first);

                f1.label2.Text = "IP: " + direction;
            }
        }
    }
}
