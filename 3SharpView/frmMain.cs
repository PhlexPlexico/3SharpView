using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.IO;

namespace _3SharpView
{

    
    public partial class frmMain : Form
    {
        Socket sockConn;
        ConcurrentQueue<inputs> objInputQueue = new ConcurrentQueue<inputs>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            readFromQueue();
        }

        private void btn3DsConn_Click(object sender, EventArgs e)
        {
            connectTo3DS();
        }

        private void txt3dsIp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                connectTo3DS();
            }
        }

        /**
         * Uses the IP:Port in the text file to connect to the socket.
         */
        private void connectTo3DS()
        {
            if (btn3DsConn.Text == "Connect!")
            {
                Cursor.Current = Cursors.WaitCursor;
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
                    Thread.CurrentThread.Name = "SockInput";
                    sockConn = new Socket(AddressFamily.InterNetwork,
                     SocketType.Stream,
                     ProtocolType.Tcp);
                    ConcurrentQueue<inputs> tmpJsonBuffer = new ConcurrentQueue<inputs>();
                    try 
                    {
                        sockConn.Connect(ipStr, Int32.Parse(port));
                        byte[] incBuff = new byte[65535];

                        //Loop and constantly receive messages.
                        if (sockConn.Connected)
                        {
                            Cursor.Current = Cursors.Default;
                            btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                            {
                                btn3DsConn.Text = "Disconnect";
                            }));
                        }
                        while (sockConn.Connected)
                        {
                            try
                            {
                                int bytesRecvd = sockConn.Receive(incBuff);
                                String jsonValues = Encoding.UTF8.GetString(incBuff.Take(bytesRecvd).ToArray());

                                // Remove last semi-colon.
                                jsonValues = jsonValues.Remove(jsonValues.Length - 1);
                                jsonValues = jsonValues.Insert(jsonValues.Length, "]");
                                jsonValues = jsonValues.Insert(0, "[");
                                tmpJsonBuffer = JsonConvert.DeserializeObject<ConcurrentQueue<inputs>>(jsonValues);
                                foreach (inputs input in tmpJsonBuffer)
                                {
                                    inputs inputCheck;
                                    if (objInputQueue.TryPeek(out inputCheck) || objInputQueue.Count < 1)
                                    //if ((objInputQueue.Last() == null || objInputQueue.Last() != input))
                                    {
                                        // If the queue is empty add, or if the new input does not equal the same, add to queue.
                                        if (inputCheck == null || (inputCheck.btn != input.btn))
                                        {
                                            objInputQueue.Enqueue(input);
                                        }
                                    }
                                }
                                incBuff = new byte[65535];
                            }
                            catch (JsonReaderException)
                            {
                                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //objInputQueue.
                            }
                            catch(Exception ex)
                            {
                                Cursor.Current = Cursors.Default;
                                btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                                {
                                    btn3DsConn.Text = "Connect!";
                                }));
                            }

                        }
                    } 
                    catch (SocketException) 
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Could not connect to the 3DS. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                        {
                            btn3DsConn.Text = "Connect!";
                        }));
                    }
                }).Start();
            }
            else
            {
                sockConn.Close();
            }
        }


        /**
         Read from the ConcurrentQueue and update the fields accordingly.
        */
        private void readFromQueue()
        {
            inputs singleInput;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Thread.CurrentThread.Name = "QueueRead";
                while (true)
                {
                    // Read and update graphics.
                    //objInputQueue.Distinct
                    while (objInputQueue.TryDequeue(out singleInput))
                    {
                        if (singleInput.btn == 1)
                        {
                            pbA.BeginInvoke(new MethodInvoker(() =>
                            {
                                pbA.Visible = true;
                            }));

                        }
                        else
                        {
                            pbA.BeginInvoke(new MethodInvoker(() =>
                            {
                                pbA.Visible = false;
                            }));
                        }
                    }
                }
            }).Start();
        }
    }
    
    public class inputs
    {
        //inputs myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public uint btn { get; set; }
        public int cp_x { get; set; }
        public int cp_y { get; set; }
        public int tp_x { get; set; }
        public int tp_y { get; set; }
        public int ir_btn { get; set; }
        public int cpp_x { get; set; }
        public int cpp_y { get; set; }
    }
}
