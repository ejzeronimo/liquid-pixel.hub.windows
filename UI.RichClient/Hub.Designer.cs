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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ModeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeChart)).BeginInit();
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
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshHubToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupOBoxesToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.portsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // groupOBoxesToolStripMenuItem
            // 
            this.groupOBoxesToolStripMenuItem.Name = "groupOBoxesToolStripMenuItem";
            this.groupOBoxesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.groupOBoxesToolStripMenuItem.Text = "Group of Assets Control Panel";
            this.groupOBoxesToolStripMenuItem.Click += new System.EventHandler(this.groupOBoxesToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.boxToolStripMenuItem.Text = "Single Asset Control";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBoxToolStripMenuItem});
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.portsToolStripMenuItem.Text = "Assets List";
            this.portsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AssetListClicked);
            this.portsToolStripMenuItem.MouseHover += new System.EventHandler(this.AssetListUpdate);
            // 
            // newBoxToolStripMenuItem
            // 
            this.newBoxToolStripMenuItem.Name = "newBoxToolStripMenuItem";
            this.newBoxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newBoxToolStripMenuItem.Text = "New Lpc Asset";
            this.newBoxToolStripMenuItem.Click += new System.EventHandler(this.NewLpcAssetCreate);
            // 
            // refreshHubToolStripMenuItem
            // 
            this.refreshHubToolStripMenuItem.Name = "refreshHubToolStripMenuItem";
            this.refreshHubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshHubToolStripMenuItem.Text = "Refresh Hub";
            this.refreshHubToolStripMenuItem.Click += new System.EventHandler(this.RefreshHubClick);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.WarningLabel.Location = new System.Drawing.Point(46, 257);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(908, 51);
            this.WarningLabel.TabIndex = 1;
            this.WarningLabel.Text = "Nothing will appear until you select Lpc Assets";
            // 
            // ModeChart
            // 
            this.ModeChart.BackColor = System.Drawing.Color.Gray;
            this.ModeChart.BackImageTransparentColor = System.Drawing.Color.Gray;
            this.ModeChart.BackSecondaryColor = System.Drawing.Color.Gray;
            this.ModeChart.BorderlineColor = System.Drawing.Color.Gray;
            this.ModeChart.BorderSkin.BorderColor = System.Drawing.Color.Gray;
            this.ModeChart.BorderSkin.PageColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.ModeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ModeChart.Legends.Add(legend1);
            this.ModeChart.Location = new System.Drawing.Point(13, 28);
            this.ModeChart.Name = "ModeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ModeChart.Series.Add(series1);
            this.ModeChart.Size = new System.Drawing.Size(525, 486);
            this.ModeChart.TabIndex = 2;
            this.ModeChart.Text = "ModeChart";
            this.ModeChart.Visible = false;
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.ModeChart);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hub";
            this.Text = "Hub";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupOBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshHubToolStripMenuItem;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ModeChart;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}