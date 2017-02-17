namespace UI.RichClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ArduinoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StringBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arduino I/O";
            // 
            // ArduinoBox
            // 
            this.ArduinoBox.Location = new System.Drawing.Point(13, 30);
            this.ArduinoBox.Multiline = true;
            this.ArduinoBox.Name = "ArduinoBox";
            this.ArduinoBox.Size = new System.Drawing.Size(241, 319);
            this.ArduinoBox.TabIndex = 1;
            this.ArduinoBox.TextChanged += new System.EventHandler(this.ArduinoBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Start);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Stop);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Make Connection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeConnection);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 59);
            this.button4.TabIndex = 5;
            this.button4.Text = "Close Connection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CloseConnection);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(396, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "Color Wheel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ColorWheel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Com Port:";
            // 
            // ComPort
            // 
            this.ComPort.Location = new System.Drawing.Point(536, 30);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 20);
            this.ComPort.TabIndex = 8;
            this.ComPort.Text = "COM4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mode:";
            // 
            // ModeBox
            // 
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Items.AddRange(new object[] {
            "Solid",
            "Breath",
            "Chase",
            "Wheels",
            "Slow Beath",
            "Custom.."});
            this.ModeBox.Location = new System.Drawing.Point(536, 68);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(121, 21);
            this.ModeBox.TabIndex = 10;
            this.ModeBox.Text = "Choose Mode...";
            this.ModeBox.SelectedIndexChanged += new System.EventHandler(this.ModeBox_SelectedIndexChanged);
            this.ModeBox.Click += new System.EventHandler(this.Dropdown);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(417, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 59);
            this.button6.TabIndex = 11;
            this.button6.Text = "Update String";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.UpdateString);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(417, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 59);
            this.button7.TabIndex = 12;
            this.button7.Text = "Send String";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SendString);
            // 
            // StringBox
            // 
            this.StringBox.Location = new System.Drawing.Point(417, 134);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(240, 20);
            this.StringBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "String:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArduinoBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Liquid Pixels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArduinoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox StringBox;
        private System.Windows.Forms.Label label4;
    }
}

