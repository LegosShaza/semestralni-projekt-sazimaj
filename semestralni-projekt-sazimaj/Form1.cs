using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semestralni_projekt_sazimaj
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> portDescriptions = new Dictionary<int, string>
        {
            { 20, "FTP (Data)" },
            { 21, "FTP (Control)" },
            { 22, "SSH" },
            { 23, "Telnet" },
            { 80, "HTTP" },
            { 443, "HTTPS" },
            { 445, "SMB" },
            { 3389, "Remote Desktop" }
        };

        public Form1()
        {
            InitializeComponent();

            dataGridViewResults.Columns.Add("ip", "IP adresa");
            dataGridViewResults.Columns.Add("status", "Stav");
            dataGridViewResults.Columns.Add("ping", "Ping (ms)");
            dataGridViewResults.Columns.Add("hostname", "Hostname");
            dataGridViewResults.Columns.Add("ports", "Otevřené porty");

            comboBoxFilter.Items.AddRange(new string[] { "Vše", "Pouze online" });
            comboBoxFilter.SelectedIndex = 0;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;

            AutoDetectLocalIPRange();
        }

        private async void buttonScan_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Rows.Clear();
            buttonScan.Enabled = false;
            progressBar.Value = 0;

            string baseIP = textBoxBaseIP.Text.Trim();
            int start = int.Parse(textBoxStartIP.Text);
            int end = int.Parse(textBoxEndIP.Text);
            bool doPortScan = checkBoxPortScan.Checked;

            int total = end - start + 1;
            progressBar.Maximum = total;

            for (int i = start; i <= end; i++)
            {
                string ip = baseIP + i.ToString();
                var result = await PingAndScanAsync(ip, doPortScan);
                dataGridViewResults.Rows.Add(result.IP, result.Status, result.PingTime, result.Hostname, result.OpenPorts);
                progressBar.Value++;
            }

            buttonScan.Enabled = true;
            MessageBox.Show("Skenování dokončeno.");
            ApplyFilter();
        }

        private async Task<ScanResult> PingAndScanAsync(string ip, bool doPortScan)
        {
            ScanResult result = new ScanResult();
            result.IP = ip;

            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = await ping.SendPingAsync(ip, 500);
                    if (reply.Status == IPStatus.Success)
                    {
                        result.Status = "Online";
                        result.PingTime = reply.RoundtripTime.ToString();

                        try
                        {
                            IPHostEntry hostEntry = await Dns.GetHostEntryAsync(ip);
                            result.Hostname = hostEntry.HostName;
                        }
                        catch
                        {
                            result.Hostname = "-";
                        }

                        if (doPortScan)
                        {
                            int[] portsToScan = { 20, 21, 22, 23, 80, 443, 445, 3389 };
                            List<string> openPorts = new List<string>();

                            foreach (int port in portsToScan)
                            {
                                if (await IsPortOpen(ip, port, 300))
                                {
                                    string description = portDescriptions.ContainsKey(port) ? $" ({portDescriptions[port]})" : "";
                                    openPorts.Add($"{port}{description}");
                                }
                            }

                            result.OpenPorts = string.Join(", ", openPorts);
                        }
                        else
                        {
                            result.OpenPorts = "-";
                        }
                    }
                    else
                    {
                        result.Status = "Offline";
                        result.PingTime = "-";
                        result.Hostname = "-";
                        result.OpenPorts = "-";
                    }
                }
            }
            catch
            {
                result.Status = "Chyba";
                result.PingTime = "-";
                result.Hostname = "-";
                result.OpenPorts = "-";
            }

            return result;
        }

        private async Task<bool> IsPortOpen(string ip, int port, int timeout)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    var task = client.ConnectAsync(ip, port);
                    if (await Task.WhenAny(task, Task.Delay(timeout)) == task)
                        return client.Connected;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            foreach (DataGridViewRow row in dataGridViewResults.Rows)
            {
                if (comboBoxFilter.SelectedIndex == 0)
                {
                    row.Visible = true;
                }
                else if (comboBoxFilter.SelectedIndex == 1)
                {
                    row.Visible = row.Cells["status"].Value?.ToString() == "Online";
                }
            }
        }

        private void AutoDetectLocalIPRange()
        {
            string localIP = Dns.GetHostEntry(Dns.GetHostName())
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)
                ?.ToString();

            if (!string.IsNullOrEmpty(localIP))
            {
                string[] parts = localIP.Split('.');
                if (parts.Length == 4)
                {
                    textBoxBaseIP.Text = $"{parts[0]}.{parts[1]}.{parts[2]}.";
                    textBoxStartIP.Text = "1";
                    textBoxEndIP.Text = "254";
                }
            }
        }
    }
}