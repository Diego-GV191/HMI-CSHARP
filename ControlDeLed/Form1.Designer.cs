
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_E_A = new System.Windows.Forms.Button();
            this.labelLed = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estado_coneccion = new System.Windows.Forms.Label();
            this.baud_rate = new System.Windows.Forms.ComboBox();
            this.port_serial = new System.Windows.Forms.ComboBox();
            this.conect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelConn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_E_A);
            this.groupBox1.Controls.Add(this.labelLed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(165, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contro de Led";
            // 
            // button_E_A
            // 
            this.button_E_A.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_E_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_E_A.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_E_A.FlatAppearance.BorderSize = 0;
            this.button_E_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_E_A.Location = new System.Drawing.Point(10, 149);
            this.button_E_A.Margin = new System.Windows.Forms.Padding(20);
            this.button_E_A.Name = "button_E_A";
            this.button_E_A.Size = new System.Drawing.Size(145, 51);
            this.button_E_A.TabIndex = 3;
            this.button_E_A.Text = "Encender";
            this.button_E_A.UseVisualStyleBackColor = false;
            this.button_E_A.Click += new System.EventHandler(this.button_E_A_Click);
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
            this.baud_rate.Text = "9600";
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
            this.conect.Click += new System.EventHandler(this.conect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelConn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 244);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(345, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TCP/IP";
            // 
            // labelConn
            // 
            this.labelConn.BackColor = System.Drawing.Color.Red;
            this.labelConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConn.Location = new System.Drawing.Point(42, 32);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(261, 37);
            this.labelConn.TabIndex = 0;
            this.labelConn.Text = "PRESS";
            this.labelConn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConn.Click += new System.EventHandler(this.labelConn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(661, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 240);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contro de Led";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelConn;
    }
}

