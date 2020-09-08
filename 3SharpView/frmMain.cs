using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace _3SharpView
{

    
    public partial class frmMain : Form
    {
        Socket sockConn;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn3DsConn_Click(object sender, EventArgs e)
        {
            if(btn3DsConn.Text == "Connect!")
            {
                int colonIndex = txt3dsIp.Text.IndexOf(':');
                String ipStr;
                String port;
                String jsonValues;
                if (colonIndex == -1)
                {
                    MessageBox.Show("Invalid host:port format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ipStr = txt3dsIp.Text.Substring(0, colonIndex);
                    port = txt3dsIp.Text.Substring(colonIndex + 1);
                }
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Thread.CurrentThread.Name = "SockInput";
                    sockConn = new Socket(AddressFamily.InterNetwork,
                     SocketType.Stream,
                     ProtocolType.Tcp);
                    sockConn.Connect(ipStr, Int32.Parse(port));
                    byte[] incBuff = new byte[65535];
                    //Loop and constantly receive messages.
                    if (sockConn.Connected)
                    {
                        btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                        {
                            btn3DsConn.Text = "Disconnect";
                        }));
                    }
                    while (sockConn.Connected)
                    {
                        try {
                            int bytesRecvd = sockConn.Receive(incBuff);
                            string jsonValues = Encoding.UTF8.GetString(incBuff.Take(bytesRecvd).ToArray());
                            // Remove last semi-colon.
                            jsonValues = jsonValues.Remove(jsonValues.Length - 1);
                            incBuff = new byte[65535];
                        } catch
                        {
                            btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                            {
                                btn3DsConn.Text = "Connect!";
                            }));
                        }
                        
                    }


                }).Start();
            }
            else
            {
                sockConn.Close();
            }
            
        }
    }
    public class inputs
    {
        //inputs myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public int btn { get; set; }
        public int cp_x { get; set; }
        public int cp_y { get; set; }
        public int tp_x { get; set; }
        public int tp_y { get; set; }
        public int ir_btn { get; set; }
        public int cpp_x { get; set; }
        public int cpp_y { get; set; }
    }
}
