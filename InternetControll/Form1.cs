using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace InternetControll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int tryPingCount = 0;
        private bool isRunning = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning) // to BREAK
            {
                timerOfPing.Stop();
                btnStart.Text = "START";
                lblPingLabel.Visible = false;
                lblPing.Visible = false;
                notifyIcon1.Visible = false;
                // pinger stop
                //pinger(false);

            }
            else // to RUN
            {
                timerOfPing.Interval = System.Convert.ToInt32(txbFrequence.Text) * 1000;
                btnStart.Text = "STOP";
                lblPingLabel.Visible = true;
                lblPing.Visible = true;
                // pinger run
                pinger(true);
                timerOfPing.Start();
                notifyIcon1.Visible = true;
            }

            groupBox2.Enabled = !groupBox2.Enabled;
            // change status
            isRunning = !isRunning;
        }

        private void pinger(bool run)
        {
            Ping png = new Ping();
            PingReply pngReply;
            tryPingCount++;
            toolStripStatusLabel1.Text = "attempts to ping: " + tryPingCount.ToString();
            try
            {
                pngReply = png.Send(txbPingSite.Text.Trim());
            }
            catch
            {
                changePingStatusOK(false);
                return;
            }
            if (pngReply.Status == IPStatus.Success)
            {
                changePingStatusOK(true);
            }
            else
                changePingStatusOK(false);
        }

        private void changePingStatusOK(bool isOK)
        {
            if (isOK) // we need write: OK
            {
                if (lblPing.Text.CompareTo("OK") != 0) // iw now not OK
                {
                    lblPing.Text = "OK";
                    lblPing.ForeColor = System.Drawing.Color.Green;
                    notifyIcon1.Icon = Properties.Resources.pingok;
                }
            }
            else // we need write: lost
            {
                if (lblPing.Text.CompareTo("Lost") != 0) // iw now not OK
                {
                    lblPing.Text = "Lost";
                    lblPing.ForeColor = System.Drawing.Color.Red;
                    notifyIcon1.Icon = Properties.Resources.pinglost;
                }
            }
        }

        private void timerOfPing_Tick(object sender, EventArgs e)
        {
            pinger(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (isRunning && WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Show();
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
