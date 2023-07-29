namespace usb_deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SimgeDurumunaKüçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxUsbPorts = new System.Windows.Forms.ListBox();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonTogglePower = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Usb port";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimgeDurumunaKüçültToolStripMenuItem,
            this.KapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 52);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KapatToolStripMenuItem_Click);
            // 
            // SimgeDurumunaKüçültToolStripMenuItem
            // 
            this.SimgeDurumunaKüçültToolStripMenuItem.Name = "SimgeDurumunaKüçültToolStripMenuItem";
            this.SimgeDurumunaKüçültToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.SimgeDurumunaKüçültToolStripMenuItem.Text = "simge durumuna küçült";
            this.SimgeDurumunaKüçültToolStripMenuItem.Click += new System.EventHandler(this.SimgeDurumunaKüçültToolStripMenuItem_Click);
            // 
            // KapatToolStripMenuItem
            // 
            this.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem";
            this.KapatToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.KapatToolStripMenuItem.Text = "kapat";
            this.KapatToolStripMenuItem.Click += new System.EventHandler(this.KapatToolStripMenuItem_Click);
            // 
            // ListBoxUsbPorts
            // 
            this.ListBoxUsbPorts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxUsbPorts.FormattingEnabled = true;
            this.ListBoxUsbPorts.ItemHeight = 16;
            this.ListBoxUsbPorts.Location = new System.Drawing.Point(32, 51);
            this.ListBoxUsbPorts.Name = "ListBoxUsbPorts";
            this.ListBoxUsbPorts.Size = new System.Drawing.Size(518, 338);
            this.ListBoxUsbPorts.TabIndex = 1;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.DimGray;
            this.ButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonRefresh.Location = new System.Drawing.Point(598, 95);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(145, 87);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "YENİLE";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonTogglePower
            // 
            this.ButtonTogglePower.BackColor = System.Drawing.Color.DimGray;
            this.ButtonTogglePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonTogglePower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonTogglePower.Location = new System.Drawing.Point(598, 229);
            this.ButtonTogglePower.Name = "ButtonTogglePower";
            this.ButtonTogglePower.Size = new System.Drawing.Size(145, 87);
            this.ButtonTogglePower.TabIndex = 3;
            this.ButtonTogglePower.Text = "GÜÇ DEĞİŞTİR";
            this.ButtonTogglePower.UseVisualStyleBackColor = false;
            this.ButtonTogglePower.Click += new System.EventHandler(this.ButtonTogglePower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonTogglePower);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ListBoxUsbPorts);
            this.Name = "Form1";
            this.Text = "USB PORT";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SimgeDurumunaKüçültToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KapatToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox ListBoxUsbPorts;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonTogglePower;
    }
}

