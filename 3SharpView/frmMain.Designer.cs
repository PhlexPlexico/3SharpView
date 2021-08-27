namespace _3SharpView
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblIP = new System.Windows.Forms.Label();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txt3dsIp = new System.Windows.Forms.TextBox();
            this.btn3DsConn = new System.Windows.Forms.Button();
            this.pb3DS = new System.Windows.Forms.PictureBox();
            this.opbCirclePad = new _3SharpView.OvalPictureBox();
            this.pbB = new _3SharpView.OvalPictureBox();
            this.pbY = new _3SharpView.OvalPictureBox();
            this.pbA = new _3SharpView.OvalPictureBox();
            this.pbX = new _3SharpView.OvalPictureBox();
            this.pbL = new System.Windows.Forms.PictureBox();
            this.pbR = new System.Windows.Forms.PictureBox();
            this.pnlTouchScreen = new System.Windows.Forms.Panel();
            this.opbTouchDot = new _3SharpView.OvalPictureBox();
            this.pbDUp = new System.Windows.Forms.PictureBox();
            this.pbDRight = new System.Windows.Forms.PictureBox();
            this.pbDDown = new System.Windows.Forms.PictureBox();
            this.pbDLeft = new System.Windows.Forms.PictureBox();
            this.pbStart = new _3SharpView.OvalPictureBox();
            this.pbSelect = new _3SharpView.OvalPictureBox();
            this.lblCpX = new System.Windows.Forms.Label();
            this.lblCpY = new System.Windows.Forms.Label();
            this.lblTpX = new System.Windows.Forms.Label();
            this.lblTpY = new System.Windows.Forms.Label();
            this.pbzl = new System.Windows.Forms.PictureBox();
            this.pbzr = new System.Windows.Forms.PictureBox();
            this.mnuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCirclePad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).BeginInit();
            this.pnlTouchScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opbTouchDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(587, 37);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(43, 15);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "3DS IP:";
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(776, 24);
            this.mnuTop.TabIndex = 1;
            this.mnuTop.Text = "mnuTop";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsmnuExit
            // 
            this.tsmnuExit.Name = "tsmnuExit";
            this.tsmnuExit.Size = new System.Drawing.Size(93, 22);
            this.tsmnuExit.Text = "E&xit";
            this.tsmnuExit.Click += new System.EventHandler(this.tsmnuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsmnuAbout
            // 
            this.tsmnuAbout.Name = "tsmnuAbout";
            this.tsmnuAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmnuAbout.Text = "&About...";
            this.tsmnuAbout.Click += new System.EventHandler(this.tsmnuAbout_Click);
            // 
            // txt3dsIp
            // 
            this.txt3dsIp.Location = new System.Drawing.Point(636, 34);
            this.txt3dsIp.Name = "txt3dsIp";
            this.txt3dsIp.Size = new System.Drawing.Size(100, 23);
            this.txt3dsIp.TabIndex = 2;
            this.txt3dsIp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt3dsIp_KeyDown);
            // 
            // btn3DsConn
            // 
            this.btn3DsConn.Location = new System.Drawing.Point(636, 64);
            this.btn3DsConn.Name = "btn3DsConn";
            this.btn3DsConn.Size = new System.Drawing.Size(75, 23);
            this.btn3DsConn.TabIndex = 3;
            this.btn3DsConn.Text = "Connect!";
            this.btn3DsConn.UseVisualStyleBackColor = true;
            this.btn3DsConn.Click += new System.EventHandler(this.btn3DsConn_Click);
            // 
            // pb3DS
            // 
            this.pb3DS.BackColor = System.Drawing.Color.Transparent;
            this.pb3DS.Image = ((System.Drawing.Image)(resources.GetObject("pb3DS.Image")));
            this.pb3DS.Location = new System.Drawing.Point(0, 27);
            this.pb3DS.Name = "pb3DS";
            this.pb3DS.Size = new System.Drawing.Size(581, 329);
            this.pb3DS.TabIndex = 4;
            this.pb3DS.TabStop = false;
            // 
            // opbCirclePad
            // 
            this.opbCirclePad.BackColor = System.Drawing.Color.DarkGray;
            this.opbCirclePad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opbCirclePad.Image = ((System.Drawing.Image)(resources.GetObject("opbCirclePad.Image")));
            this.opbCirclePad.Location = new System.Drawing.Point(33, 96);
            this.opbCirclePad.Margin = new System.Windows.Forms.Padding(0);
            this.opbCirclePad.Name = "opbCirclePad";
            this.opbCirclePad.Size = new System.Drawing.Size(52, 52);
            this.opbCirclePad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.opbCirclePad.TabIndex = 6;
            this.opbCirclePad.TabStop = false;
            // 
            // pbB
            // 
            this.pbB.BackColor = System.Drawing.Color.DarkGray;
            this.pbB.Image = ((System.Drawing.Image)(resources.GetObject("pbB.Image")));
            this.pbB.Location = new System.Drawing.Point(505, 168);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(33, 33);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbB.TabIndex = 7;
            this.pbB.TabStop = false;
            this.pbB.Visible = false;
            // 
            // pbY
            // 
            this.pbY.BackColor = System.Drawing.Color.DarkGray;
            this.pbY.Image = ((System.Drawing.Image)(resources.GetObject("pbY.Image")));
            this.pbY.Location = new System.Drawing.Point(472, 137);
            this.pbY.Name = "pbY";
            this.pbY.Size = new System.Drawing.Size(33, 33);
            this.pbY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbY.TabIndex = 7;
            this.pbY.TabStop = false;
            this.pbY.Visible = false;
            // 
            // pbA
            // 
            this.pbA.BackColor = System.Drawing.Color.DarkGray;
            this.pbA.Image = ((System.Drawing.Image)(resources.GetObject("pbA.Image")));
            this.pbA.Location = new System.Drawing.Point(536, 136);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(33, 33);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbA.TabIndex = 7;
            this.pbA.TabStop = false;
            this.pbA.Visible = false;
            // 
            // pbX
            // 
            this.pbX.BackColor = System.Drawing.Color.DarkGray;
            this.pbX.Image = ((System.Drawing.Image)(resources.GetObject("pbX.Image")));
            this.pbX.Location = new System.Drawing.Point(505, 107);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(33, 33);
            this.pbX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbX.TabIndex = 7;
            this.pbX.TabStop = false;
            this.pbX.Visible = false;
            // 
            // pbL
            // 
            this.pbL.BackColor = System.Drawing.Color.Transparent;
            this.pbL.Image = ((System.Drawing.Image)(resources.GetObject("pbL.Image")));
            this.pbL.Location = new System.Drawing.Point(3, 29);
            this.pbL.Name = "pbL";
            this.pbL.Size = new System.Drawing.Size(50, 27);
            this.pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbL.TabIndex = 8;
            this.pbL.TabStop = false;
            this.pbL.Visible = false;
            // 
            // pbR
            // 
            this.pbR.BackColor = System.Drawing.Color.Transparent;
            this.pbR.Image = ((System.Drawing.Image)(resources.GetObject("pbR.Image")));
            this.pbR.Location = new System.Drawing.Point(527, 29);
            this.pbR.Name = "pbR";
            this.pbR.Size = new System.Drawing.Size(50, 27);
            this.pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbR.TabIndex = 8;
            this.pbR.TabStop = false;
            this.pbR.Visible = false;
            // 
            // pnlTouchScreen
            // 
            this.pnlTouchScreen.BackColor = System.Drawing.Color.Lime;
            this.pnlTouchScreen.Controls.Add(this.opbTouchDot);
            this.pnlTouchScreen.Location = new System.Drawing.Point(133, 74);
            this.pnlTouchScreen.Name = "pnlTouchScreen";
            this.pnlTouchScreen.Size = new System.Drawing.Size(315, 240);
            this.pnlTouchScreen.TabIndex = 9;
            // 
            // opbTouchDot
            // 
            this.opbTouchDot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.opbTouchDot.Location = new System.Drawing.Point(0, 0);
            this.opbTouchDot.Name = "opbTouchDot";
            this.opbTouchDot.Size = new System.Drawing.Size(24, 24);
            this.opbTouchDot.TabIndex = 0;
            this.opbTouchDot.TabStop = false;
            this.opbTouchDot.Visible = false;
            // 
            // pbDUp
            // 
            this.pbDUp.BackColor = System.Drawing.Color.Transparent;
            this.pbDUp.Image = ((System.Drawing.Image)(resources.GetObject("pbDUp.Image")));
            this.pbDUp.Location = new System.Drawing.Point(48, 181);
            this.pbDUp.Margin = new System.Windows.Forms.Padding(0);
            this.pbDUp.Name = "pbDUp";
            this.pbDUp.Size = new System.Drawing.Size(22, 20);
            this.pbDUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDUp.TabIndex = 10;
            this.pbDUp.TabStop = false;
            this.pbDUp.Visible = false;
            // 
            // pbDRight
            // 
            this.pbDRight.BackColor = System.Drawing.Color.Transparent;
            this.pbDRight.Image = ((System.Drawing.Image)(resources.GetObject("pbDRight.Image")));
            this.pbDRight.Location = new System.Drawing.Point(71, 204);
            this.pbDRight.Margin = new System.Windows.Forms.Padding(0);
            this.pbDRight.Name = "pbDRight";
            this.pbDRight.Size = new System.Drawing.Size(22, 20);
            this.pbDRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDRight.TabIndex = 10;
            this.pbDRight.TabStop = false;
            this.pbDRight.Visible = false;
            // 
            // pbDDown
            // 
            this.pbDDown.BackColor = System.Drawing.Color.Transparent;
            this.pbDDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDDown.Image")));
            this.pbDDown.Location = new System.Drawing.Point(48, 229);
            this.pbDDown.Margin = new System.Windows.Forms.Padding(0);
            this.pbDDown.Name = "pbDDown";
            this.pbDDown.Size = new System.Drawing.Size(22, 20);
            this.pbDDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDDown.TabIndex = 10;
            this.pbDDown.TabStop = false;
            this.pbDDown.Visible = false;
            // 
            // pbDLeft
            // 
            this.pbDLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbDLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbDLeft.Image")));
            this.pbDLeft.Location = new System.Drawing.Point(24, 204);
            this.pbDLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pbDLeft.Name = "pbDLeft";
            this.pbDLeft.Size = new System.Drawing.Size(22, 20);
            this.pbDLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDLeft.TabIndex = 10;
            this.pbDLeft.TabStop = false;
            this.pbDLeft.Visible = false;
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.DarkGray;
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.Location = new System.Drawing.Point(479, 239);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(20, 20);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 7;
            this.pbStart.TabStop = false;
            this.pbStart.Visible = false;
            // 
            // pbSelect
            // 
            this.pbSelect.BackColor = System.Drawing.Color.DarkGray;
            this.pbSelect.Image = ((System.Drawing.Image)(resources.GetObject("pbSelect.Image")));
            this.pbSelect.Location = new System.Drawing.Point(479, 276);
            this.pbSelect.Margin = new System.Windows.Forms.Padding(0);
            this.pbSelect.Name = "pbSelect";
            this.pbSelect.Size = new System.Drawing.Size(20, 20);
            this.pbSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelect.TabIndex = 7;
            this.pbSelect.TabStop = false;
            this.pbSelect.Visible = false;
            // 
            // lblCpX
            // 
            this.lblCpX.AutoSize = true;
            this.lblCpX.Location = new System.Drawing.Point(587, 96);
            this.lblCpX.Name = "lblCpX";
            this.lblCpX.Size = new System.Drawing.Size(76, 15);
            this.lblCpX.TabIndex = 11;
            this.lblCpX.Text = "Circle Pad X: ";
            // 
            // lblCpY
            // 
            this.lblCpY.AutoSize = true;
            this.lblCpY.Location = new System.Drawing.Point(587, 115);
            this.lblCpY.Name = "lblCpY";
            this.lblCpY.Size = new System.Drawing.Size(76, 15);
            this.lblCpY.TabIndex = 12;
            this.lblCpY.Text = "Circle Pad Y: ";
            // 
            // lblTpX
            // 
            this.lblTpX.AutoSize = true;
            this.lblTpX.Location = new System.Drawing.Point(587, 137);
            this.lblTpX.Name = "lblTpX";
            this.lblTpX.Size = new System.Drawing.Size(75, 15);
            this.lblTpX.TabIndex = 13;
            this.lblTpX.Text = "Touchpad X: ";
            // 
            // lblTpY
            // 
            this.lblTpY.AutoSize = true;
            this.lblTpY.Location = new System.Drawing.Point(588, 155);
            this.lblTpY.Name = "lblTpY";
            this.lblTpY.Size = new System.Drawing.Size(75, 15);
            this.lblTpY.TabIndex = 13;
            this.lblTpY.Text = "Touchpad Y: ";
            // 
            // pbzl
            // 
            this.pbzl.BackColor = System.Drawing.Color.Transparent;
            this.pbzl.Image = ((System.Drawing.Image)(resources.GetObject("pbzl.Image")));
            this.pbzl.Location = new System.Drawing.Point(56, 29);
            this.pbzl.Name = "pbzl";
            this.pbzl.Size = new System.Drawing.Size(37, 27);
            this.pbzl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbzl.TabIndex = 8;
            this.pbzl.TabStop = false;
            this.pbzl.Visible = false;
            // 
            // pbzr
            // 
            this.pbzr.BackColor = System.Drawing.Color.Transparent;
            this.pbzr.Image = ((System.Drawing.Image)(resources.GetObject("pbzr.Image")));
            this.pbzr.Location = new System.Drawing.Point(496, 29);
            this.pbzr.Name = "pbzr";
            this.pbzr.Size = new System.Drawing.Size(31, 27);
            this.pbzr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbzr.TabIndex = 8;
            this.pbzr.TabStop = false;
            this.pbzr.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(776, 361);
            this.Controls.Add(this.pbzr);
            this.Controls.Add(this.pbzl);
            this.Controls.Add(this.pnlTouchScreen);
            this.Controls.Add(this.lblTpY);
            this.Controls.Add(this.lblTpX);
            this.Controls.Add(this.lblCpY);
            this.Controls.Add(this.lblCpX);
            this.Controls.Add(this.pbSelect);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pbDLeft);
            this.Controls.Add(this.pbDDown);
            this.Controls.Add(this.pbDRight);
            this.Controls.Add(this.pbDUp);
            this.Controls.Add(this.pbR);
            this.Controls.Add(this.pbL);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.pbA);
            this.Controls.Add(this.pbY);
            this.Controls.Add(this.pbB);
            this.Controls.Add(this.opbCirclePad);
            this.Controls.Add(this.btn3DsConn);
            this.Controls.Add(this.txt3dsIp);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.pb3DS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "3SharpView";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbCirclePad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).EndInit();
            this.pnlTouchScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opbTouchDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.TextBox txt3dsIp;
        private System.Windows.Forms.Button btn3DsConn;
        private System.Windows.Forms.PictureBox pb3DS;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmnuExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmnuAbout;
        private OvalPictureBox opbCirclePad;
        private OvalPictureBox pbB;
        private OvalPictureBox pbY;
        private OvalPictureBox pbA;
        private OvalPictureBox pbX;
        private System.Windows.Forms.PictureBox pbL;
        private System.Windows.Forms.PictureBox pbR;
        private System.Windows.Forms.Panel pnlTouchScreen;
        private System.Windows.Forms.PictureBox pbDUp;
        private System.Windows.Forms.PictureBox pbDDown;
        private System.Windows.Forms.PictureBox pbDLeft;
        private System.Windows.Forms.PictureBox pbDRight;
        private OvalPictureBox pbStart;
        private OvalPictureBox pbSelect;
        private System.Windows.Forms.Label lblCpX;
        private System.Windows.Forms.Label lblCpY;
        private System.Windows.Forms.Label lblTpX;
        private System.Windows.Forms.Label lblTpY;
        private OvalPictureBox opbTouchDot;
        private System.Windows.Forms.PictureBox pbzl;
        private System.Windows.Forms.PictureBox pbzr;
    }
}

