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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt3dsIp = new System.Windows.Forms.TextBox();
            this.btn3DsConn = new System.Windows.Forms.Button();
            this.pb3DS = new System.Windows.Forms.PictureBox();
            this.mnuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3DS)).BeginInit();
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
            this.mnuTop.Size = new System.Drawing.Size(755, 24);
            this.mnuTop.TabIndex = 1;
            this.mnuTop.Text = "mnuTop";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
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
            this.pb3DS.Image = ((System.Drawing.Image)(resources.GetObject("pb3DS.Image")));
            this.pb3DS.Location = new System.Drawing.Point(0, 27);
            this.pb3DS.Name = "pb3DS";
            this.pb3DS.Size = new System.Drawing.Size(581, 329);
            this.pb3DS.TabIndex = 4;
            this.pb3DS.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.pb3DS);
            this.Controls.Add(this.btn3DsConn);
            this.Controls.Add(this.txt3dsIp);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Name = "frmMain";
            this.Text = "3SharpView";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3DS)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

