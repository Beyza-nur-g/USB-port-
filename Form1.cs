using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;


namespace usb_deneme
{
    public partial class Form1 : Form
    {
        private List<string> usbPorts = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false; 
            RefreshUSBPorts();
        }

        private void SimgeDurumunaKüçültToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(1, "Bilgi", "Uygulama Küçültüldü", ToolTipIcon.Info);
        }

        private void KapatToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        private void RefreshUSBPorts()
        {
            ListBoxUsbPorts.Items.Clear();
            // WMI sınıfını kullanarak USB bağlantı noktalarını tespit etme işlemi
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");

            foreach (ManagementObject usbPort in searcher.Get())
            {
                string portName = usbPort["DeviceID"].ToString();
                string portStatus = usbPort["Status"].ToString();
                // USB portunu arayüze ekleme işlemi
                ListBoxUsbPorts.Items.Add($"{portName} - Durum: {portStatus}");
            }
        }
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshUSBPorts();
        }
        private void ButtonTogglePower_Click(object sender, EventArgs e)
        {
            if (ListBoxUsbPorts.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir USB port seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedPort = ListBoxUsbPorts.SelectedItem.ToString();
            string portName = selectedPort.Split('-')[0].Trim();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT * FROM Win32_USBHub WHERE DeviceID='{portName}'");

            // LINQ sorgusu ile seçilen portu bulma :
            //ManagementObject usbPort = searcher.Get().OfType<ManagementObject>().FirstOrDefault();

            foreach (ManagementObject usbPort in searcher.Get())
            //if (usbPort != null) LINQ sorgusu için gerekli olan kod
            {
                
                uint portState = (uint)usbPort["PowerState"];
                if (portState == 0)
                {
                    usbPort.InvokeMethod("SetPowerState", new object[] { 1 }); // 1: Güç açık, 2: Güç kapalı
                    MessageBox.Show("USB portunun gücü açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (portState == 1)
                {
                    usbPort.InvokeMethod("SetPowerState", new object[] { 2 });
                    MessageBox.Show("USB portunun gücü kapatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("USB portunun güç durumu bilinmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshUSBPorts();
        }
    }
}
