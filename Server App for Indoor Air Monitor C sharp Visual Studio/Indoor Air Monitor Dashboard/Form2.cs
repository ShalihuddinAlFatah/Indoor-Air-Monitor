using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_CS_UDP_2
{
    public partial class Form2 : Form
    {
        private Point mouseOffset;
        private Boolean isMouseDown = false;

        // Serial port to send UDP server's local IP address
        private SerialPort mySerialPort;

        public Form2()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            TransparencyKey = BackColor;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize serial port
            mySerialPort = new SerialPort();
            txtIpAddress.Text = "Enter IP here...";
        }

        private void buttonLOCATE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X - 10, -e.Y - 10);
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

        private void buttonMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPairSerial_Click(object sender, EventArgs e)
        {
            // Ensure a COM port is selected
            if (comboBoxSerialList.SelectedItem == null)
            {
                labelERR.Text = "Please select a COM port.";
                return;
            }

            // Set the selected COM port
            mySerialPort.PortName = comboBoxSerialList.SelectedItem.ToString();
            mySerialPort.BaudRate = 115200; // Set baud rate as per your device requirements
            mySerialPort.ReadTimeout = 5000; // Set read timeout to handle no response case

            try
            {
                // Open the serial port
                if (!mySerialPort.IsOpen)
                {
                    mySerialPort.Open();
                }

                // Get the IP address to send
                string ipAddress = txtIpAddress.Text + "\n";

                // Send the IP address as a string
                mySerialPort.WriteLine(ipAddress);

                labelERR.Text = "IP address sent successfully!";

                // Wait and read reply from the device
                string reply = mySerialPort.ReadLine();
                labelERR.Text = reply;
            }
            catch (TimeoutException)
            {
                labelERR.Text = "No response received from the device.";
            }
            catch (Exception ex)
            {
                labelERR.Text = $"Error: {ex.Message}";
            }
            finally
            {
                // Close the serial port
                if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                }
            }
        }

        private void buttonScanSerial_Click(object sender, EventArgs e)
        {
            // Clear ComboBox before scanning
            comboBoxSerialList.Items.Clear();

            // Get available COM ports and add them to the ComboBox
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxSerialList.Items.Add(port);
            }

            if (comboBoxSerialList.Items.Count > 0)
            {
                comboBoxSerialList.SelectedIndex = 0; // Select the first available port
            }
            else
            {
                labelERR.Text = "No COM ports found.";
            }
        }
    }
}
