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
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _3SharpView
{


    public partial class frmMain : Form
    {
        Socket sockConn;
        ConcurrentQueue<inputs> objInputQueue = new ConcurrentQueue<inputs>();
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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

        private void tsmnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input viewer for the 3DS, to be used with 3input.\nMade by PhlexPlexico.\nSpecial Thanks to N3rdsWithGame, Megahirtz, Gaby.\nAny issues? Please report on the GitHub repo.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                // Reset state.
                                incBuff = new byte[65535];
                            }
                            catch (JsonSerializationException)
                            {
                                // Reset state.
                                incBuff = new byte[65535];
                            }
                            catch (SocketException)
                            {
                                btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                                {
                                    btn3DsConn.Text = "Connect!";
                                }));
                            }
                            catch (Exception ex)
                            {
                                Cursor.Current = Cursors.Default;
                                btn3DsConn.BeginInvoke(new MethodInvoker(() =>
                                {
                                    btn3DsConn.Text = "Connect!";
                                }));
                                MessageBox.Show("Uknown exception. Please report as an issue to the repository.\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Get the single input and read the buttons pressed.
            Func<uint, uint, bool[]> ToBits = (uint input, uint numberOfBits) => Enumerable.Range(0, (int)numberOfBits)
                .Select(bitIndex => 1 << bitIndex)
                .Select(bitMask => (input & bitMask) == bitMask)
                .ToArray();
            btns allButtons = new btns();
            bool[] bitArray;
            new Thread(() =>
            {
            Thread.CurrentThread.IsBackground = true;
            Thread.CurrentThread.Name = "QueueRead";
            while (true)
            {
                // Read and update graphics.
                while (objInputQueue.TryDequeue(out inputs singleInput))
                {
                    bitArray = ToBits(singleInput.btn, 15);
                    // For each true, grab the index and assign to button. 
                    // Button will draw dependent on index returned?
                    // There will have to be a link from location to button as well on the viewer.
                    for (uint button = 0; button < bitArray.Length; button++)
                    {
                        if (bitArray[button])
                        {
                            //paintOnPictureBox(btnPosition[0], btnPosition[1]);
                            if (button == allButtons.a)
                            {
                                pbA.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbA.Visible = true;
                                }));
                            }
                            else if (button == allButtons.b)
                            {
                                pbB.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbB.Visible = true;
                                }));
                            }
                            else if (button == allButtons.x)
                            {
                                pbX.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbX.Visible = true;
                                }));
                            }
                            else if (button == allButtons.y)
                            {
                                pbY.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbY.Visible = true;
                                }));
                            }
                            else if (button == allButtons.l)
                            {
                                pbL.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbL.Visible = true;
                                }));
                            }
                            else if (button == allButtons.r)
                            {
                                pbR.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbR.Visible = true;
                                }));
                            }
                            else if (button == allButtons.d_up)
                            {
                                pbDUp.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDUp.Visible = true;
                                }));
                            }
                            else if (button == allButtons.d_down)
                            {
                                pbDDown.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDDown.Visible = true;
                                }));
                            }
                            else if (button == allButtons.d_left)
                            {
                                pbDLeft.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDLeft.Visible = true;
                                }));
                            }
                            else if (button == allButtons.d_right)
                            {
                                pbDRight.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDRight.Visible = true;
                                }));
                            }
                            else if (button == allButtons.start)
                            {
                                    pbStart.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbStart.Visible = true;
                                }));
                            }
                            else if (button == allButtons.select)
                            {
                                pbSelect.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbSelect.Visible = true;
                                }));
                            }
                            }
                        else
                        {
                            if (button == allButtons.a)
                            {
                                pbA.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbA.Visible = false;
                                }));
                            }
                            else if (button == allButtons.b)
                            {
                                pbB.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbB.Visible = false;
                                }));
                            }
                            else if (button == allButtons.x)
                            {
                                pbX.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbX.Visible = false;
                                }));
                            }
                            else if (button == allButtons.y)
                            {
                                pbY.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbY.Visible = false;
                                }));
                            }
                            else if(button == allButtons.l)
                            {
                                pbL.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbL.Visible = false;
                                }));
                            }
                            else if (button == allButtons.r)
                            {
                                pbR.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbR.Visible = false;
                                }));
                            }
                            else if (button == allButtons.d_up)
                            {
                                pbDUp.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDUp.Visible = false;
                                }));
                            }
                            else if (button == allButtons.d_down)
                            {
                                pbDDown.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDDown.Visible = false;
                                }));
                            }
                            else if (button == allButtons.d_left)
                            {
                                pbDLeft.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDLeft.Visible = false;
                                }));
                            }
                            else if (button == allButtons.d_right)
                            {
                                pbDRight.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbDRight.Visible = false;
                                }));
                            }
                            else if (button == allButtons.start)
                            {
                                pbStart.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbStart.Visible = false;
                                }));
                            }
                            else if (button == allButtons.select)
                            {
                                pbSelect.BeginInvoke(new MethodInvoker(() =>
                                {
                                    pbSelect.Visible = false;
                                }));
                            }
                            }
                        opbCirclePad.BeginInvoke(new MethodInvoker(() =>
                        {
                            opbCirclePad.Location = new Point((int)((singleInput.cp_x) * opbCirclePad.scale + opbCirclePad.defaultX), opbCirclePad.defaultY - (int)((singleInput.cp_y) * opbCirclePad.scale));
                            opbCirclePad.Refresh();
                            lblCpX.Text = "Circle Pad X: " + singleInput.cp_x;
                            lblCpY.Text = "Circle Pad Y: " + singleInput.cp_y;

                        }));                         
                        }
                    }
                }
            }).Start();
        }
    }



    public class inputs
    {
        public uint btn { get; set; }
        public int cp_x { get; set; }
        public int cp_y { get; set; }
        public int tp_x { get; set; }
        public int tp_y { get; set; }
        public int ir_btn { get; set; }
        public int cpp_x { get; set; }
        public int cpp_y { get; set; }
    }

    public class btns
    {
        public uint a = 0;
        public uint b = 1;
        public uint select = 2;
        public uint start = 3;
        public uint d_right = 4;
        public uint d_left = 5;
        public uint d_up = 6;
        public uint d_down = 7;
        public uint r = 8;
        public uint l = 9;
        public uint x = 10;
        public uint y = 11;
        public uint zl = 14;
        public uint zr = 15;
    }


class OvalPictureBox : PictureBox
    {
        public int defaultX = 33;
        public int defaultY = 96;
        public double scale = 1 / 5.0;
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }

}
