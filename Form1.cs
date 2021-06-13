using System;
using System.Drawing;
using System.Windows.Forms;
using MCQuery;
using Newtonsoft.Json;
using System.IO;

namespace MinecraftServerStatus2
{
    public partial class Form1 : Form
    {
        static Timer myTimer = new Timer();
        static bool exitFlag = false;
        static string settingsJson;
        static dynamic settings;
        public Form1()
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 5000;
            myTimer.Start();

            settingsJson = File.ReadAllText("ipaddress.json");
            settings = JsonConvert.DeserializeObject(settingsJson);
            InitializeComponent();
        }

        public void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            /*var myClient = new WebClient();
            string jsonData = myClient.DownloadString("https://mcapi.us/server/status?ip=ger-h01.vibegames.net&port=31270");
            dynamic serverStats = JsonConvert.DeserializeObject(jsonData);
            string online;*/

            string ip = settings.ip;
            int port = settings.port;
            var server = new MCServer(ip, port);
            ServerStatus data = null;
            double ping = 0;
            try
            {
                data = server.Status();
                ping = server.Ping();
            } catch
            {

            }

            ipValue.Text = settings.ip;
            if (!(data == null))
            {
                statusValue.Text = "Online";
                statusValue.ForeColor = Color.LimeGreen;
                playersOnlineValue.Text = (data.Players.Online).ToString() + " / " + (data.Players.Max).ToString();
                serverSoftwareValue.Text = data.Version.Name;
                pingValue.Text = Math.Round(ping).ToString() + "ms";
            } else
            {
                statusValue.Text = "Offline";
                statusValue.ForeColor = Color.Red;
                playersOnlineValue.Text = "?? / ??";
                serverSoftwareValue.Text = "?";
                pingValue.Text = "?";
            }

            myTimer.Start();
        }

        private void aboutBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by MrSpy42 for fun.","About");
        }
    }
}
