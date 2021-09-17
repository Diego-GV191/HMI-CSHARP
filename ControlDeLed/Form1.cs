using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ControlDeLed
{
    public partial class Form1 : Form
    {
        Thread hilo1 = new Thread(leerSenal);
        static bool conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private static void leerSenal()
        {
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint midir = new IPEndPoint(IPAddress.Any, 1234);

            try
            {
                socket1.Bind(midir);
                socket1.Listen(1);
                conectado = false;

                Socket escuchar = socket1.Accept();
                conectado = true;
                socket1.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void desactivarComponentes()
        {
            button_E_A.Enabled = false;
        }

        private void activarComponentes()
        {
            button_E_A.Enabled = true;
        }

        private void apagar()
        {
            try
            {
                serialPort1.WriteLine("$Off");
                labelLed.BackColor = Color.Red;
                labelLed.Text = "OFF";
                button_E_A.Text = "Encender";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void encender()
        {
            try
            {
                serialPort1.WriteLine("$On");
                labelLed.BackColor = Color.Lime;
                labelLed.Text = "ON";
                button_E_A.Text = "Apagar";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_E_A_Click(object sender, EventArgs e)
        {
            if (button_E_A.Text.Equals("Encender"))
            {
                encender();
            }
            else
            {
                apagar();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                desactivarComponentes();
                // comportamiento
                if (serialPort1.IsOpen)
                {
                    hilo1.Start();
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
            if (serialPort1.IsOpen)
            {
                try
                {
                    hilo1.Abort();
                    // cerrar el puerto
                    serialPort1.WriteLine("$Off");
                    serialPort1.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void conect_Click(object sender, EventArgs e)
        {
            if (conect.Text.Equals("Refrescar"))
            {
                estado_coneccion.Text = "OFFLINE";
                // limpieza de port_serial
                port_serial.Items.Clear();
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
                    serialPort1.Open();
                    estado_coneccion.Text = "ONLINE";
                    conect.Text = "Desconectar";
                    activarComponentes();
                }
                catch (Exception error)
                {
                    desactivarComponentes();
                    MessageBox.Show(error.Message);
                    port_serial.Items.Clear();
                    conect.Text = "Refrescar";
                }
            }
            else
            {
                try
                {
                    apagar();
                    desactivarComponentes();
                    serialPort1.Close();
                    port_serial.Items.Clear();
                    port_serial.Text = "Serial";
                    conect.Text = "Refrescar";
                    estado_coneccion.Text = "OFFLINE";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void conn_escuchando()
        {
            labelConn.Text = "Escuchando...";
            labelConn.BackColor = Color.Red;
        }

        private void conn_aceptado()
        {
            labelConn.Text = "Conectado";
            labelConn.BackColor = Color.Lime;
        }

        private void labelConn_Click_1(object sender, EventArgs e)
        {
            if (conectado)
            {
                conn_aceptado();
            }
            else
            {
                conn_escuchando();
            }
        }
    }
}
