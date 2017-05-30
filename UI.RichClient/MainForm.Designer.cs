namespace UI.RichClient
{
    partial class DelayBarQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelayBarQ));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.StringBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.DelayBar = new System.Windows.Forms.TrackBar();
            this.ModeBar = new System.Windows.Forms.TrackBar();
            this.BrightBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BrightBarQ = new System.Windows.Forms.TrackBar();
            this.ModeBarQ = new System.Windows.Forms.TrackBar();
            this.Delayq = new System.Windows.Forms.TrackBar();
            this.StringBoxQ = new System.Windows.Forms.TextBox();
            this.SendStringQ = new System.Windows.Forms.Button();
            this.UpdateStringQ = new System.Windows.Forms.Button();
            this.ModeBoxQ = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1q = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBarQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeBarQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayq)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(12, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 140);
            this.button3.TabIndex = 4;
            this.button3.Text = "Make Connection";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.MakeConnection);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(12, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 140);
            this.button4.TabIndex = 5;
            this.button4.Text = "Close Connection";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CloseConnection);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Location = new System.Drawing.Point(12, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 73);
            this.button5.TabIndex = 6;
            this.button5.Text = "Color Wheel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ColorWheel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Com Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mode:";
            // 
            // ModeBox
            // 
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Flash",
            "Sweep",
            "Twinkle",
            "Random Twinkle",
            "Random Flash",
            "Theater Chase",
            "Fade In",
            "Fade Out",
            "Breath",
            "Random Breath",
            "Sudden Flash",
            "Chroma",
            "Random Cloudy"});
            this.ModeBox.Location = new System.Drawing.Point(252, 55);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(121, 21);
            this.ModeBox.TabIndex = 10;
            this.ModeBox.Text = "Off";
            this.ModeBox.SelectedIndexChanged += new System.EventHandler(this.ModeBox_SelectedIndexChanged);
            this.ModeBox.Click += new System.EventHandler(this.Dropdown);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(198, 300);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 59);
            this.button6.TabIndex = 11;
            this.button6.Text = "Update String";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.UpdateString);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Location = new System.Drawing.Point(199, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 73);
            this.button7.TabIndex = 12;
            this.button7.Text = "Send String";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SendString);
            // 
            // StringBox
            // 
            this.StringBox.Location = new System.Drawing.Point(198, 274);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(240, 20);
            this.StringBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "String:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Items.AddRange(new object[] {
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.PortBox.Location = new System.Drawing.Point(67, 44);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 21);
            this.PortBox.TabIndex = 15;
            this.PortBox.Text = "COM4";
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // DelayBar
            // 
            this.DelayBar.BackColor = System.Drawing.Color.DarkGray;
            this.DelayBar.Location = new System.Drawing.Point(212, 146);
            this.DelayBar.Maximum = 50;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.Size = new System.Drawing.Size(226, 45);
            this.DelayBar.TabIndex = 16;
            // 
            // ModeBar
            // 
            this.ModeBar.BackColor = System.Drawing.Color.DarkGray;
            this.ModeBar.LargeChange = 1;
            this.ModeBar.Location = new System.Drawing.Point(211, 82);
            this.ModeBar.Maximum = 14;
            this.ModeBar.Name = "ModeBar";
            this.ModeBar.Size = new System.Drawing.Size(226, 45);
            this.ModeBar.TabIndex = 28;
            this.ModeBar.Scroll += new System.EventHandler(this.ModeBar_Scroll);
            // 
            // BrightBar
            // 
            this.BrightBar.BackColor = System.Drawing.Color.DarkGray;
            this.BrightBar.Location = new System.Drawing.Point(212, 210);
            this.BrightBar.Maximum = 255;
            this.BrightBar.Name = "BrightBar";
            this.BrightBar.Size = new System.Drawing.Size(226, 45);
            this.BrightBar.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Brightness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Delay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Delay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(957, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Brightness";
            // 
            // BrightBarQ
            // 
            this.BrightBarQ.BackColor = System.Drawing.Color.DarkGray;
            this.BrightBarQ.Location = new System.Drawing.Point(957, 176);
            this.BrightBarQ.Maximum = 255;
            this.BrightBarQ.Name = "BrightBarQ";
            this.BrightBarQ.Size = new System.Drawing.Size(240, 45);
            this.BrightBarQ.TabIndex = 29;
            // 
            // ModeBarQ
            // 
            this.ModeBarQ.BackColor = System.Drawing.Color.DarkGray;
            this.ModeBarQ.LargeChange = 1;
            this.ModeBarQ.Location = new System.Drawing.Point(957, 48);
            this.ModeBarQ.Maximum = 14;
            this.ModeBarQ.Name = "ModeBarQ";
            this.ModeBarQ.Size = new System.Drawing.Size(239, 45);
            this.ModeBarQ.TabIndex = 28;
            this.ModeBarQ.Scroll += new System.EventHandler(this.ModeBarQ_Scroll);
            // 
            // Delayq
            // 
            this.Delayq.BackColor = System.Drawing.Color.DarkGray;
            this.Delayq.Location = new System.Drawing.Point(957, 112);
            this.Delayq.Maximum = 50;
            this.Delayq.Name = "Delayq";
            this.Delayq.Size = new System.Drawing.Size(240, 45);
            this.Delayq.TabIndex = 27;
            // 
            // StringBoxQ
            // 
            this.StringBoxQ.Location = new System.Drawing.Point(957, 227);
            this.StringBoxQ.Name = "StringBoxQ";
            this.StringBoxQ.Size = new System.Drawing.Size(240, 20);
            this.StringBoxQ.TabIndex = 25;
            // 
            // SendStringQ
            // 
            this.SendStringQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendStringQ.BackgroundImage")));
            this.SendStringQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendStringQ.Location = new System.Drawing.Point(957, 318);
            this.SendStringQ.Name = "SendStringQ";
            this.SendStringQ.Size = new System.Drawing.Size(239, 59);
            this.SendStringQ.TabIndex = 24;
            this.SendStringQ.Text = "Send String";
            this.SendStringQ.UseVisualStyleBackColor = true;
            // 
            // UpdateStringQ
            // 
            this.UpdateStringQ.Location = new System.Drawing.Point(957, 253);
            this.UpdateStringQ.Name = "UpdateStringQ";
            this.UpdateStringQ.Size = new System.Drawing.Size(239, 59);
            this.UpdateStringQ.TabIndex = 23;
            this.UpdateStringQ.Text = "Update String";
            this.UpdateStringQ.UseVisualStyleBackColor = true;
            this.UpdateStringQ.Click += new System.EventHandler(this.UpdateStringQ_Click);
            // 
            // ModeBoxQ
            // 
            this.ModeBoxQ.FormattingEnabled = true;
            this.ModeBoxQ.Items.AddRange(new object[] {
            "Off",
            "Solid",
            "Flash",
            "Sweep",
            "Twinkle",
            "Random Twinkle",
            "Random Flash",
            "Theater Chase",
            "Fade In",
            "Fade Out",
            "Breath",
            "Random Breath",
            "Sudden Flash",
            "Chroma",
            "Random Cloudy"});
            this.ModeBoxQ.Location = new System.Drawing.Point(1000, 21);
            this.ModeBoxQ.Name = "ModeBoxQ";
            this.ModeBoxQ.Size = new System.Drawing.Size(121, 21);
            this.ModeBoxQ.TabIndex = 22;
            this.ModeBoxQ.Text = "Off";
            this.ModeBoxQ.SelectedIndexChanged += new System.EventHandler(this.ModeBoxQ_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(957, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mode:";
            // 
            // button1q
            // 
            this.button1q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1q.BackgroundImage")));
            this.button1q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1q.Location = new System.Drawing.Point(957, 383);
            this.button1q.Name = "button1q";
            this.button1q.Size = new System.Drawing.Size(240, 55);
            this.button1q.TabIndex = 34;
            this.button1q.Text = "Color Wheel";
            this.button1q.UseVisualStyleBackColor = true;
            this.button1q.Click += new System.EventHandler(this.button1q_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(444, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 277);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(704, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 277);
            this.panel2.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label8.Location = new System.Drawing.Point(631, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 37;
            this.label8.Text = "Queuing:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Color Now:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Color Later:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 73);
            this.button1.TabIndex = 40;
            this.button1.Text = "Queue Up Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelayBarQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BrightBarQ);
            this.Controls.Add(this.ModeBarQ);
            this.Controls.Add(this.Delayq);
            this.Controls.Add(this.StringBoxQ);
            this.Controls.Add(this.SendStringQ);
            this.Controls.Add(this.UpdateStringQ);
            this.Controls.Add(this.ModeBoxQ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrightBar);
            this.Controls.Add(this.ModeBar);
            this.Controls.Add(this.DelayBar);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DelayBarQ";
            this.Text = "Box";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBarQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeBarQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox StringBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.TrackBar DelayBar;
        private System.Windows.Forms.TrackBar ModeBar;
        private System.Windows.Forms.TrackBar BrightBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar BrightBarQ;
        private System.Windows.Forms.TrackBar ModeBarQ;
        private System.Windows.Forms.TrackBar Delayq;
        private System.Windows.Forms.TextBox StringBoxQ;
        private System.Windows.Forms.Button SendStringQ;
        private System.Windows.Forms.Button UpdateStringQ;
        private System.Windows.Forms.ComboBox ModeBoxQ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1q;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

