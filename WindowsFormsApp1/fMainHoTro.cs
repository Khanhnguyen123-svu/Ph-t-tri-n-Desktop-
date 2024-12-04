using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Schema;

namespace WindowsFormsApp1
{
    public partial class fMainHoTro : Form
    {
        public fMainHoTro()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Connect();
        }

        private void fMainHoTro_Load(object sender, EventArgs e)
        {

        }
        IPEndPoint IP;
        Socket Server;
        List<Socket> clientList;
        private void fMainHoTro_FormClose(object sender, FormClosingEventArgs e)
        {
            Close();
        }
        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Parse("128.0.0.1"), 0908);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
           Server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Server.Listen(100);
                        Socket client = Server.Accept();
                        clientList.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Parse("128.0.0.1"), 0908);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket socket in clientList)
            {
                Send(socket);
            }
            txtMessage.Clear();
        }
        void Close()
        {
            Server.Close();
        }
        void Send(Socket client)
        {
            if (txtMessage.Text != String.Empty)
                client.Send(Serialize(txtMessage.Text));
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    String message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void lsvMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
