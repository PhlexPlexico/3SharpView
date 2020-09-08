using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _3SharpView
{

    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn3DsConn_Click(object sender, EventArgs e)
        {
            int colonIndex = txt3dsIp.Text.IndexOf(':');
            String ipStr;
            String port;
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
               Socket sockConn = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
               sockConn.Connect(ipStr, Int32.Parse(port));
               byte[] incBuff = new byte[65536];
               //Loop and constantly receive messages.
               if (sockConn.Connected)
               {

               }
               while (sockConn.Connected)
               {
                   sockConn.Receive(incBuff);

               }


           }).Start();
            //TODO: Create new connection thread.
            Socket s = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            byte[] buf = new byte[65536];
            String tmp;
            s.Connect("192.168.1.219", 65534);
            s.Receive(buf);
            // Keep receiving on different thread, append to global JSON array.
            // Other thread then reads from top of array, then keeps processing
            // and updating graphics?
            tmp = Encoding.UTF8.GetString(buf);
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
