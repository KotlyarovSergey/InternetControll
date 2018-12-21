using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
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
        private IPAddress defGateWay;
        private enum pingStatus
        {
            siteOK,
            gateWayOK,
            lost
        };

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
                pinger();
                timerOfPing.Start();
                notifyIcon1.Visible = true;
            }

            groupBox2.Enabled = !groupBox2.Enabled;
            // change status
            isRunning = !isRunning;
        }

        private void pinger()
        {
            Ping png = new Ping();
            PingReply pngReply;
            tryPingCount++;
            toolStripStatusLabel1.Text = "attempts to ping: " + tryPingCount.ToString();
            // try ping site
            //IPAddress ipSite = 
            IPHostEntry ipHE = null ;// = Dns.GetHostEntry(txbPingSite.Text.Trim());
            //bool hostEntryExist = true;
            try
            {
                ipHE = Dns.GetHostEntry(txbPingSite.Text.Trim());
                //pngReply = png.Send(txbPingSite.Text.Trim(),1500);
                
            }
            catch
            {
                // не удалось разрешить хост
                // если стоит галка, надо пробовать пингануть шлюз
                //changePingStatusOK(pingStatus.lost);
                //return;
                //hostEntryExist = false;
            }

            // если хост разрешен, пытаемя пингануть, если нет пингуем шлюз
            if(ipHE!=null)
            {
                // pngReply = png.Send(ipHE.AddressList[0], 1500);
                pngReply = png.Send(txbPingSite.Text.Trim(), 1500);
                // if ping site success
                if (pngReply.Status == IPStatus.Success)
                {
                    changePingStatusOK(pingStatus.siteOK);
                }
                else
                {
                    pingGate();
                }
            }
            else // пингуем шлюз
            {

                pingGate();

            }
            timerOfPing.Start();
            return;
            void pingGate()
            {
                // if cheked ping gateway
                if (checkBoxPingGateWay.Checked == true)
                {
                    // try ping GateWay
                    try
                    {
                        pngReply = png.Send(defGateWay);
                    }
                    catch
                    {
                        changePingStatusOK(pingStatus.lost);
                        return;
                    }

                    // if ping GateWay success
                    if (pngReply.Status == IPStatus.Success)
                    {
                        changePingStatusOK(pingStatus.gateWayOK);
                    }
                    else  // if don't ping gateway
                    {
                        changePingStatusOK(pingStatus.lost);
                    }
                }
            }
            
        }

        private void changePingStatusOK(pingStatus pStat)
        {
            switch(pStat)
            {
                case pingStatus.siteOK:
                    if (lblPing.Text.CompareTo("OK") != 0) // iw now not OK
                    {
                        lblPing.Text = "OK";
                        lblPing.ForeColor = System.Drawing.Color.Green;
                        notifyIcon1.Icon = Properties.Resources.pingok;
                    }
                    break;

                case pingStatus.gateWayOK:
                    if (lblPing.Text.CompareTo("only Gate") != 0) // iw now not OK
                    {
                        lblPing.Text = "only Gate";
                        lblPing.ForeColor = System.Drawing.Color.Yellow;
                        notifyIcon1.Icon = Properties.Resources.pingok;
                    }
                    break;

                default:
                    if (lblPing.Text.CompareTo("Lost") != 0) // iw now not OK
                    {
                        lblPing.Text = "Lost";
                        lblPing.ForeColor = System.Drawing.Color.Red;
                        notifyIcon1.Icon = Properties.Resources.pinglost;
                    }
                    break;
            }
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


        // -------------  TIMER ------------------
        private void timerOfPing_Tick(object sender, EventArgs e)
        {
            timerOfPing.Stop();
            pinger();
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


        // get IP Config
        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            getIFStatus();
        }

        private void getIFStatus()
        {
            // get all IF and fill combo
            cmBoxInterFaces.Items.Clear();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) ||
                    (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                {
                    cmBoxInterFaces.Items.Add(nic.Description);
                }
            }
            if (cmBoxInterFaces.Items.Count > 0)
            {
                cmBoxInterFaces.SelectedIndex = 0;
            }
            else
            {
                return;
            }

        }


        // selected InterFace changed
        private void cmBoxInterFaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblIP.Text = "IP: "; 

            foreach (NetworkInterface NI in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in NI.GetIPProperties().UnicastAddresses)
                {
                    if (NI.Description == cmBoxInterFaces.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            //MessageBox.Show(ip.Address.ToString());
                            lblIP.Text = "IP: " + ip.Address.ToString();
                            lblMask.Text = "Mask: " + ip.IPv4Mask.ToString();
                        }
                        IPInterfaceProperties ipifpr = NI.GetIPProperties();
                        lblDNS.Text = getDNS(ipifpr);
                        lblGatWay.Text = getGateWay(ipifpr);
                    }
                }
            }
        }

        private string getDNS(IPInterfaceProperties IPIFProp)
        {
            IPAddressCollection IPColl = IPIFProp.DnsAddresses;
            foreach (IPAddress ip in IPColl)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return "DNS: " + ip.ToString();
                }
            }

            return "DNS: ";
        }

        private string getGateWay(IPInterfaceProperties IPIFProp)
        {
            GatewayIPAddressInformationCollection GIPAIC = IPIFProp.GatewayAddresses;
            foreach  (GatewayIPAddressInformation iP in GIPAIC)
            {
                if (iP.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    defGateWay = iP.Address;
                    return "GateWay: " + defGateWay.ToString();
                }
            }
            return "GateWay:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getIFStatus();
        }
    }
}
