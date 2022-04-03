
namespace ControlDeLed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_E_A = new System.Windows.Forms.Button();
            this.labelLed = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estado_coneccion = new System.Windows.Forms.Label();
            this.baud_rate = new System.Windows.Forms.ComboBox();
            this.port_serial = new System.Windows.Forms.ComboBox();
            this.conect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBLU = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRecibir = new System.Windows.Forms.RichTextBox();
            this.lblRecibir = new System.Windows.Forms.Label();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button_E_A);
            this.groupBox1.Controls.Add(this.labelLed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(165, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contro de Led";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(160, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button_E_A
            // 
            this.button_E_A.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_E_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_E_A.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_E_A.FlatAppearance.BorderSize = 0;
            this.button_E_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_E_A.Location = new System.Drawing.Point(10, 154);
            this.button_E_A.Margin = new System.Windows.Forms.Padding(20);
            this.button_E_A.Name = "button_E_A";
            this.button_E_A.Size = new System.Drawing.Size(145, 51);
            this.button_E_A.TabIndex = 3;
            this.button_E_A.Text = "Encender";
            this.button_E_A.UseVisualStyleBackColor = false;
            this.button_E_A.Click += new System.EventHandler(this.Button_E_A_Click);
            // 
            // labelLed
            // 
            this.labelLed.BackColor = System.Drawing.Color.Red;
            this.labelLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed.Location = new System.Drawing.Point(28, 46);
            this.labelLed.Name = "labelLed";
            this.labelLed.Size = new System.Drawing.Size(110, 51);
            this.labelLed.TabIndex = 0;
            this.labelLed.Text = "OFF";
            this.labelLed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estado_coneccion);
            this.groupBox2.Controls.Add(this.baud_rate);
            this.groupBox2.Controls.Add(this.port_serial);
            this.groupBox2.Controls.Add(this.conect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(165, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // estado_coneccion
            // 
            this.estado_coneccion.Location = new System.Drawing.Point(10, 24);
            this.estado_coneccion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.estado_coneccion.Name = "estado_coneccion";
            this.estado_coneccion.Size = new System.Drawing.Size(145, 45);
            this.estado_coneccion.TabIndex = 6;
            this.estado_coneccion.Text = "OFFLINE";
            this.estado_coneccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baud_rate
            // 
            this.baud_rate.BackColor = System.Drawing.SystemColors.Window;
            this.baud_rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baud_rate.FormattingEnabled = true;
            this.baud_rate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.baud_rate.Location = new System.Drawing.Point(10, 117);
            this.baud_rate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.baud_rate.Name = "baud_rate";
            this.baud_rate.Size = new System.Drawing.Size(145, 32);
            this.baud_rate.TabIndex = 5;
            this.baud_rate.Text = "115200";
            // 
            // port_serial
            // 
            this.port_serial.BackColor = System.Drawing.SystemColors.Window;
            this.port_serial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.port_serial.FormattingEnabled = true;
            this.port_serial.Location = new System.Drawing.Point(10, 77);
            this.port_serial.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.port_serial.Name = "port_serial";
            this.port_serial.Size = new System.Drawing.Size(145, 32);
            this.port_serial.TabIndex = 4;
            this.port_serial.Text = "Serial";
            // 
            // conect
            // 
            this.conect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.conect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.conect.FlatAppearance.BorderSize = 0;
            this.conect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conect.Location = new System.Drawing.Point(10, 160);
            this.conect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.conect.Name = "conect";
            this.conect.Size = new System.Drawing.Size(145, 45);
            this.conect.TabIndex = 2;
            this.conect.Text = "Refrescar";
            this.conect.UseVisualStyleBackColor = false;
            this.conect.Click += new System.EventHandler(this.Conect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBLU);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnEnviar);
            this.groupBox3.Controls.Add(this.txtRecibir);
            this.groupBox3.Controls.Add(this.lblRecibir);
            this.groupBox3.Controls.Add(this.txtEnviar);
            this.groupBox3.Controls.Add(this.lblEnviar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(367, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(520, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal";
            // 
            // btnBLU
            // 
            this.btnBLU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBLU.BackColor = System.Drawing.Color.Red;
            this.btnBLU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBLU.FlatAppearance.BorderSize = 0;
            this.btnBLU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBLU.Location = new System.Drawing.Point(0, 154);
            this.btnBLU.Margin = new System.Windows.Forms.Padding(10);
            this.btnBLU.Name = "btnBLU";
            this.btnBLU.Size = new System.Drawing.Size(125, 36);
            this.btnBLU.TabIndex = 6;
            this.btnBLU.Text = "Bluetooth";
            this.btnBLU.UseVisualStyleBackColor = false;
            this.btnBLU.Click += new System.EventHandler(this.btn_BLU_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(0, 113);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 36);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(428, 27);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 36);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRecibir
            // 
            this.txtRecibir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecibir.Location = new System.Drawing.Point(127, 79);
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.ReadOnly = true;
            this.txtRecibir.Size = new System.Drawing.Size(379, 123);
            this.txtRecibir.TabIndex = 3;
            this.txtRecibir.Text = "";
            this.txtRecibir.TextChanged += new System.EventHandler(this.txtRecibir_TextChanged);
            // 
            // lblRecibir
            // 
            this.lblRecibir.AutoSize = true;
            this.lblRecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibir.Location = new System.Drawing.Point(36, 79);
            this.lblRecibir.Name = "lblRecibir";
            this.lblRecibir.Size = new System.Drawing.Size(85, 25);
            this.lblRecibir.TabIndex = 2;
            this.lblRecibir.Text = "Recibir:";
            // 
            // txtEnviar
            // 
            this.txtEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.Location = new System.Drawing.Point(99, 31);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(316, 29);
            this.txtEnviar.TabIndex = 1;
            this.txtEnviar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnviar_KeyDown);
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.Location = new System.Drawing.Point(13, 31);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(80, 25);
            this.lblEnviar.TabIndex = 0;
            this.lblEnviar.Text = "Enviar:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 238);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Analog1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Analog2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(873, 171);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Lectura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versión 1.1.0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(126, 417);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Diego García Vega";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 484);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 240);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contro de Led";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLed;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button conect;
        private System.Windows.Forms.ComboBox port_serial;
        private System.Windows.Forms.Button button_E_A;
        private System.Windows.Forms.ComboBox baud_rate;
        private System.Windows.Forms.Label estado_coneccion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.RichTextBox txtRecibir;
        private System.Windows.Forms.Label lblRecibir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBLU;
    }
}

