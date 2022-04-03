using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace ControlDeLed
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void SendData(String data)
        {
            try
            {
                serialPort1.WriteLine(data);
                if (data.Equals("$On"))
                {
                    Encender();
                }
                else if (data.Equals("$Off"))
                {
                    Apagar();
                }
                txtEnviar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DesactivarComponentes()
        {
            Apagar();
            ApagarBluetooth();
            button_E_A.Enabled = false;
            txtEnviar.Enabled = false;
            btnEnviar.Enabled = false;
        }

        private void ActivarComponentes()
        {
            SendData("=RD");
            button_E_A.Enabled = true;
            txtEnviar.Enabled = true;
            btnEnviar.Enabled = true;
        }

        private void EncenderBluetooth()
        {
            btnBLU.BackColor = Color.Lime;
        }

        private void ApagarBluetooth()
        {
            btnBLU.BackColor = Color.Red;
        }

        private void Apagar()
        {
            try
            {
                labelLed.BackColor = Color.Red;
                labelLed.Text = "OFF";
                button_E_A.Text = "Encender";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Encender()
        {
            try
            {
                labelLed.BackColor = Color.Lime;
                labelLed.Text = "ON";
                button_E_A.Text = "Apagar";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Button_E_A_Click(object sender, EventArgs e)
        {
            Switch_btn_E_A();
        }

        private void Switch_btn_E_A()
        {
            if (button_E_A.Text.Equals("Encender"))
            {
                SendData("$On");
            }
            else
            {
                SendData("$Off");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DesactivarComponentes();
                // comportamiento
                if (serialPort1.IsOpen)
                {
                    conect.Text = "Conectar";
                }
                else
                {
                    conect.Text = "Refrescar";
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram();
        }

        private void CloseProgram()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // cerrar el puerto
                    serialPort1.Close();
                    Application.Exit();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Conect_Click(object sender, EventArgs e)
        {
            if (conect.Text.Equals("Refrescar"))
            {
                estado_coneccion.Text = "OFFLINE";
                // limpieza de port_serial
                port_serial.Items.Clear();
                baud_rate.Enabled = true;
                port_serial.Enabled = true;
                try
                {
                    // revision de puertos
                    string[] ports = SerialPort.GetPortNames();
                    foreach (string port in ports)
                    {
                        port_serial.Items.Add(port);
                    }

                    // seleccion automatica
                    if (port_serial.Items.Count >= 0)
                    {
                        port_serial.SelectedIndex = 0;
                        conect.Text = "Conectar";
                    }
                    else
                    {
                        port_serial.Text = "No Serial";
                        conect.Text = "Refrescar";
                    }
                }
                catch
                {
                    port_serial.Text = "No Serial";
                    port_serial.Items.Clear();
                    conect.Text = "Refrescar";
                }
            }
            else if (conect.Text.Equals("Conectar"))
            {
                try
                {
                    // comportamiento
                    serialPort1.PortName = port_serial.Text;
                    serialPort1.BaudRate = Int32.Parse(baud_rate.Text);
                    serialPort1.ReadTimeout = 1000;
                    serialPort1.Open();
                    baud_rate.Enabled = false;
                    port_serial.Enabled = false;
                    estado_coneccion.Text = "ONLINE";
                    conect.Text = "Desconectar";
                    ActivarComponentes();
                }
                catch (Exception error)
                {
                    baud_rate.Enabled = true;
                    port_serial.Enabled = true;
                    DesactivarComponentes();
                    MessageBox.Show(error.Message);
                    port_serial.Items.Clear();
                    conect.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    DesactivarComponentes();
                    serialPort1.Close();
                    port_serial.Items.Clear();
                    port_serial.Text = "Serial";
                    conect.Text = "Refrescar";
                    estado_coneccion.Text = "OFFLINE";
                    baud_rate.Enabled = true;
                    port_serial.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                SendData(txtEnviar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRecibir_TextChanged(object sender, EventArgs e)
        {
            txtRecibir.SelectionStart = txtRecibir.Text.Length;
            txtRecibir.ScrollToCaret();
        }

        private void txtEnviar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendData(txtEnviar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.W)
                {
                    CloseProgram();
                }
                if (e.KeyCode == Keys.F9)
                {
                    txtEnviar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                {
                    String serialData = serialPort1.ReadLine();
                    txtRecibir.Text += serialData.Trim() + '\n';
                    if (serialData.Trim().Equals("$On")) Encender();
                    if (serialData.Trim().Equals("$Off")) Apagar();
                    if (serialData.Trim().Equals("Bluetooth On")) EncenderBluetooth();
                    if (serialData.Trim().Equals("Bluetooth Off")) ApagarBluetooth();
                    if (serialData.Trim().StartsWith("#A"))
                    {
                        int posicion = serialData.IndexOf("A");
                        serialData = serialData.Substring(posicion + 1);
                        int value = Convert.ToInt32(serialData);
                        chart1.Invoke((MethodInvoker)(() => chart1.Series["Analog1"].Points.AddY(value)));
                    }
                    if (serialData.Trim().StartsWith("#B"))
                    {
                        int posicion = serialData.IndexOf("B");
                        serialData = serialData.Substring(posicion + 1);
                        int value = Convert.ToInt32(serialData);
                        chart1.Invoke((MethodInvoker)(() => chart1.Series["Analog2"].Points.AddY(value)));
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.StackTrace);
                throw;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRecibir.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Diego-GV191/HMI-CSHARP");
        }

        private void btn_BLU_Click(object sender, EventArgs e)
        {
            try
            {
                SendData("!Blu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
