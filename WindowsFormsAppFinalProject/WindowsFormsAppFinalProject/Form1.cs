using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarrenLee.Bluetooth;
using System.Windows.Forms;

namespace WindowsFormsAppFinalProject
{
    public partial class Form1 : Form
    {
        Bluetooth_Client client = new Bluetooth_Client("Ali");
        Bluetooth_Server server = new Bluetooth_Server();
        int countServer, countClient;
        public Form1()
        {
            InitializeComponent();
            textBoxStatus.ReadOnly = true;
            richTextBoxServer.ReadOnly = true;
            richTextBoxServer.BackColor = Color.White;
            richTextBoxClient.ReadOnly = true;
            richTextBoxClient.BackColor = Color.White;
            textBoxStatus.Text = "\tNot Connected";
            textBoxStatus.BackColor = Color.White;
            buttonSend.Enabled = false;
            buttonConnect.Enabled = false;
            buttonAccept.Enabled = false;
            countServer = countClient = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
            buttonConnect.Enabled = true;
            textBoxStatus.Text = "\tWaiting for Connection";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonSend.Enabled = true;
            richTextBoxClient.ReadOnly = false;
            buttonAccept.Enabled = false;
            client.Start();
            client.IsConnected += Client_IsConnected;
        }

        private void Client_IsConnected(object sender, EventArgs e)
        {
            if(InvokeRequired)
            {
                if (countClient == 0)
                {
                    MessageBox.Show("Connection Established");
                    countClient++;
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        textBoxStatus.Text = "\tConnected";
                    }));
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
            client.SyncMessage(richTextBoxClient.Text);
            richTextBoxClient.Text = null;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            server.Start();
            server.IsConnected += Server_IsConnected;
            server.DataReceived += Server_DataReceived1;
        }

        private void Server_DataReceived1(object sender, BluetoothServerEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    richTextBoxServer.AppendText("\n" + e.Message + "\n");
                }));
            }
        }

        private void Server_IsConnected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                if (countServer == 0)
                {
                    MessageBox.Show("Connection Established");
                    countServer++;
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        textBoxStatus.Text = "\tConnected";
                    }));
                }
            }
        }
    }
}
