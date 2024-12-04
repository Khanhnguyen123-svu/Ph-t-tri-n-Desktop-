using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class fEmailHoTro : Form
    {
        public fEmailHoTro()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void fEmailHoTro_Load(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMessage.Text);
        }
        IPEndPoint IP;
        Socket clinet;
        
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("128.0.0.1"), 0908);
            clinet = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.IP);
            try
            {
                clinet.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
           clinet.Close();
        }
        void Send()
        {
            if(txtMessage.Text != String.Empty)
                clinet.Send(Serialize(txtMessage.Text));
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    clinet.Receive(data);
                    String message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }
        void AddMessage (string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
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
        private void fEmailHoTro_FormClose(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
