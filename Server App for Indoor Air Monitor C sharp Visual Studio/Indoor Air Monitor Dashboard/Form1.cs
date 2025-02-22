using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Visual_CS_UDP_2
{
    public partial class Form1 : Form
    {
        private Point mouseOffset;
        private Boolean isMouseDown = false;

        // UDP port
        public const int listenPort = 63000;
        private UdpClient listener;

        private Thread receiveThread;
        private bool isReceiving = false;

        // Placeholder for UDP data
        string[] data2;
        string oldLPG, oldCO, oldSMOKE, oldTEMP, oldHUM;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            TransparencyKey = BackColor;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isReceiving)
            {
                listener = new UdpClient(listenPort); // Bind to port
                receiveThread = new Thread(ReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start();
                isReceiving = true;
                buttonStop.Enabled = true;
                buttonStart.Enabled = false;
                labelERR.Text = " ";
            }
        }

        private void ReceiveData()
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (isReceiving)
                {
                    byte[] receivedBytes = listener.Receive(ref remoteEndPoint);
                    string receivedData = Encoding.ASCII.GetString(receivedBytes);

                    data2 = receivedData.Split(',');

                    this.Invoke((MethodInvoker)delegate
                    {
                        // Simple error handling if the server fail to receive UDP data
                        if (data2[0] == "0" && data2[1] == "0" && data2[2] == "0" && data2[3] == "0" && data2[4] == "0")
                        {
                            textBoxLPG.Text = oldLPG;
                            textBoxCO.Text = oldCO;
                            textBoxSMOKE.Text = oldSMOKE;
                            textBoxTEMP.Text = oldTEMP;
                            textBoxHUM.Text = oldHUM;
                            labelERR.Text = "error";
                        }

                        else
                        {
                            textBoxLPG.Text = data2[0];
                            textBoxCO.Text = data2[1];
                            textBoxSMOKE.Text = data2[2];
                            textBoxTEMP.Text = data2[3];
                            textBoxHUM.Text = data2[4];
                        }

                        oldLPG = textBoxLPG.Text;
                        oldCO = textBoxCO.Text;
                        oldSMOKE = textBoxSMOKE.Text;
                        oldTEMP = textBoxTEMP.Text;
                        oldHUM = textBoxHUM.Text;
                    });
                }
            }
            catch (SocketException)
            {
                // Handle socket exception if needed
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (isReceiving)
            {
                isReceiving = false;
                listener.Close();
                receiveThread.Join();
                buttonStop.Enabled = false;
                buttonStart.Enabled = true;
                textBoxLPG.Text = " ";
                textBoxCO.Text = " ";
                textBoxSMOKE.Text = " ";
                textBoxTEMP.Text = " ";
                textBoxHUM.Text = " ";
                labelERR.Text = " ";
            }
        }

        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPairX_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLOCATE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X-10, -e.Y-10);
                isMouseDown = true; 
            }
        }

        private void buttonLOCATE_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void buttonLOCATE_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
