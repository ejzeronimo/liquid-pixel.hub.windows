namespace UI.RichClient
{
    partial class Hub
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HBox1 = new System.Windows.Forms.TextBox();
            this.HBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupOBoxesToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.portsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // groupOBoxesToolStripMenuItem
            // 
            this.groupOBoxesToolStripMenuItem.Name = "groupOBoxesToolStripMenuItem";
            this.groupOBoxesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.groupOBoxesToolStripMenuItem.Text = "Group o\' Boxes";
            this.groupOBoxesToolStripMenuItem.Click += new System.EventHandler(this.groupOBoxesToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBoxToolStripMenuItem});
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.portsToolStripMenuItem.Text = "Assets";
            // 
            // newBoxToolStripMenuItem
            // 
            this.newBoxToolStripMenuItem.Name = "newBoxToolStripMenuItem";
            this.newBoxToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newBoxToolStripMenuItem.Text = "New Lpc Asset";
            this.newBoxToolStripMenuItem.Click += new System.EventHandler(this.NewLpcAssetCreate);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // DataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(12, 27);
            this.DataChart.Name = "DataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DataChart.Series.Add(series1);
            this.DataChart.Size = new System.Drawing.Size(423, 241);
            this.DataChart.TabIndex = 1;
            this.DataChart.Text = "chart1";
            // 
            // DataChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.DataChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DataChart2.Legends.Add(legend2);
            this.DataChart2.Location = new System.Drawing.Point(12, 274);
            this.DataChart2.Name = "DataChart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DataChart2.Series.Add(series2);
            this.DataChart2.Size = new System.Drawing.Size(423, 241);
            this.DataChart2.TabIndex = 2;
            this.DataChart2.Text = "chart1";
            // 
            // HBox1
            // 
            this.HBox1.Location = new System.Drawing.Point(442, 27);
            this.HBox1.Name = "HBox1";
            this.HBox1.Size = new System.Drawing.Size(100, 20);
            this.HBox1.TabIndex = 3;
            this.HBox1.Text = "Box1";
            this.HBox1.MouseHover += new System.EventHandler(this.UpdateGlobalHBox1);
            // 
            // HBox2
            // 
            this.HBox2.Location = new System.Drawing.Point(442, 63);
            this.HBox2.Name = "HBox2";
            this.HBox2.Size = new System.Drawing.Size(100, 20);
            this.HBox2.TabIndex = 4;
            this.HBox2.Text = "Box2";
            this.HBox2.MouseHover += new System.EventHandler(this.UpdateGlobalHBox2);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.HBox2);
            this.Controls.Add(this.HBox1);
            this.Controls.Add(this.DataChart2);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hub";
            this.Text = "Hub";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupOBoxesToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart2;
        private System.Windows.Forms.ToolStripMenuItem newBoxToolStripMenuItem;
        private System.Windows.Forms.TextBox HBox1;
        private System.Windows.Forms.TextBox HBox2;
    }
}