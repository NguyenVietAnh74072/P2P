using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using CHAT_P2P.File_Transfer;

namespace CHAT_P2P
{
    public partial class frmMain : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public frmMain()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            txtIPC1.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try 
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    UTF8Encoding eEncoding = new UTF8Encoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    lbMSG.Items.Add("Friend: "+receivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnGuiFile.Enabled = false;
            btnNhanFile.Enabled = false;
            btnVideoCall.Enabled = false;
            lbMSG.Items.Add("Nhập IP của người bạn muốn trò chuyện vào ô Client 2, sau đó bấm 'Kết Nối' để bắt đầu trò chuyện ");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(txtMSG.Text);

                sck.Send(msg);

                lbMSG.Items.Add("You: "+txtMSG.Text);
                txtMSG.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtMSG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnSend.PerformClick();
                txtMSG.Focus();
            }
        }

        private void btnVideoCall_Click(object sender, EventArgs e)
        {
            P2PVideoCall frm = new P2PVideoCall(this);
            frm.ShowDialog();
        }

        private void btnGuiFile_Click(object sender, EventArgs e)
        {
            frmSender frm = new frmSender(this);
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            byte[] msg = new byte[1500];
            msg = enc.GetBytes("Phát hiện yêu cầu gửi file, vui lòng click 'Nhận File' để bắt đầu quá trình gửi file");
            sck.Send(msg);
            frm.ShowDialog();
        }

        private void btnNhanFile_Click(object sender, EventArgs e)
        {
            frmReceiver frm = new frmReceiver();
            frm.ShowDialog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(txtIPC1.Text), Convert.ToInt32(txtPortC1.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(txtIPC2.Text), Convert.ToInt32(txtPortC2.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                btnConnect.Text = "Đã kết nối";
                btnGuiFile.Enabled = true;
                btnNhanFile.Enabled = true;
                btnVideoCall.Enabled = true;
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
                txtMSG.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
