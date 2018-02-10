using System;
using System.Collections.Generic;

namespace UI.RichClient
{
    partial class Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.RunLoopCheck = new System.Windows.Forms.CheckBox();
            this.TimeQueBtn = new System.Windows.Forms.Button();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.TimedSend = new System.Windows.Forms.Label();
            this.QueCommands = new System.Windows.Forms.Button();
            this.CurCommands = new System.Windows.Forms.Button();
            this.QingLabel = new System.Windows.Forms.Label();
            this.EndConnectionsBtn = new System.Windows.Forms.Button();
            this.StartConnectionBtn = new System.Windows.Forms.Button();
            this.GenerateAssetsBtn = new System.Windows.Forms.Button();
            this.GroupList = new System.Windows.Forms.CheckedListBox();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.AllPanel = new System.Windows.Forms.Panel();
            this.AllSend = new System.Windows.Forms.Button();
            this.AllMode = new System.Windows.Forms.ComboBox();
            this.AllDelay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AllDelay);
            this.panel1.Controls.Add(this.AllMode);
            this.panel1.Controls.Add(this.AllSend);
            this.panel1.Controls.Add(this.AllPanel);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.UpdateLabel);
            this.panel1.Controls.Add(this.RunLoopCheck);
            this.panel1.Controls.Add(this.TimeQueBtn);
            this.panel1.Controls.Add(this.TimeBar);
            this.panel1.Controls.Add(this.TimeBox);
            this.panel1.Controls.Add(this.TimedSend);
            this.panel1.Controls.Add(this.QueCommands);
            this.panel1.Controls.Add(this.CurCommands);
            this.panel1.Controls.Add(this.QingLabel);
            this.panel1.Controls.Add(this.EndConnectionsBtn);
            this.panel1.Controls.Add(this.StartConnectionBtn);
            this.panel1.Controls.Add(this.GenerateAssetsBtn);
            this.panel1.Controls.Add(this.GroupList);
            this.panel1.Controls.Add(this.ChooseLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 476);
            this.panel1.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(6, 313);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(190, 23);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "Update All Commands";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateCommands);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(3, 297);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(100, 13);
            this.UpdateLabel.TabIndex = 13;
            this.UpdateLabel.Text = "Update Commands:";
            // 
            // RunLoopCheck
            // 
            this.RunLoopCheck.AutoSize = true;
            this.RunLoopCheck.Location = new System.Drawing.Point(6, 246);
            this.RunLoopCheck.Name = "RunLoopCheck";
            this.RunLoopCheck.Size = new System.Drawing.Size(123, 17);
            this.RunLoopCheck.TabIndex = 12;
            this.RunLoopCheck.Text = "Run Queuing in loop";
            this.RunLoopCheck.UseVisualStyleBackColor = true;
            // 
            // TimeQueBtn
            // 
            this.TimeQueBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.TimeQueBtn.Location = new System.Drawing.Point(4, 269);
            this.TimeQueBtn.Name = "TimeQueBtn";
            this.TimeQueBtn.Size = new System.Drawing.Size(192, 25);
            this.TimeQueBtn.TabIndex = 11;
            this.TimeQueBtn.Text = "Run Timed Queuing";
            this.TimeQueBtn.UseVisualStyleBackColor = false;
            this.TimeQueBtn.Click += new System.EventHandler(this.RunTimedQ);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(68, 220);
            this.TimeBar.Maximum = 5000;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(125, 45);
            this.TimeBar.TabIndex = 10;
            this.TimeBar.Scroll += new System.EventHandler(this.TimeBarChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(6, 220);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(56, 20);
            this.TimeBox.TabIndex = 9;
            this.TimeBox.Text = "0";
            this.TimeBox.TextChanged += new System.EventHandler(this.TimeBoxChanged);
            // 
            // TimedSend
            // 
            this.TimedSend.AutoSize = true;
            this.TimedSend.Location = new System.Drawing.Point(3, 203);
            this.TimedSend.Name = "TimedSend";
            this.TimedSend.Size = new System.Drawing.Size(131, 13);
            this.TimedSend.TabIndex = 8;
            this.TimedSend.Text = "Timed Command Sending:";
            // 
            // QueCommands
            // 
            this.QueCommands.Location = new System.Drawing.Point(6, 177);
            this.QueCommands.Name = "QueCommands";
            this.QueCommands.Size = new System.Drawing.Size(190, 23);
            this.QueCommands.TabIndex = 7;
            this.QueCommands.Text = "Send Queuing Commands";
            this.QueCommands.UseVisualStyleBackColor = true;
            this.QueCommands.Click += new System.EventHandler(this.SendAllQue);
            // 
            // CurCommands
            // 
            this.CurCommands.Location = new System.Drawing.Point(6, 147);
            this.CurCommands.Name = "CurCommands";
            this.CurCommands.Size = new System.Drawing.Size(190, 23);
            this.CurCommands.TabIndex = 6;
            this.CurCommands.Text = "Send Current Commands";
            this.CurCommands.UseVisualStyleBackColor = true;
            this.CurCommands.Click += new System.EventHandler(this.SendAllCurrent);
            // 
            // QingLabel
            // 
            this.QingLabel.AutoSize = true;
            this.QingLabel.Location = new System.Drawing.Point(3, 130);
            this.QingLabel.Name = "QingLabel";
            this.QingLabel.Size = new System.Drawing.Size(90, 13);
            this.QingLabel.TabIndex = 5;
            this.QingLabel.Text = "Send Commands:";
            // 
            // EndConnectionsBtn
            // 
            this.EndConnectionsBtn.BackColor = System.Drawing.Color.Salmon;
            this.EndConnectionsBtn.FlatAppearance.BorderSize = 0;
            this.EndConnectionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndConnectionsBtn.Location = new System.Drawing.Point(101, 90);
            this.EndConnectionsBtn.Name = "EndConnectionsBtn";
            this.EndConnectionsBtn.Size = new System.Drawing.Size(95, 37);
            this.EndConnectionsBtn.TabIndex = 4;
            this.EndConnectionsBtn.Text = "End Connections";
            this.EndConnectionsBtn.UseVisualStyleBackColor = false;
            this.EndConnectionsBtn.Click += new System.EventHandler(this.EndAssets);
            // 
            // StartConnectionBtn
            // 
            this.StartConnectionBtn.BackColor = System.Drawing.Color.LightGreen;
            this.StartConnectionBtn.FlatAppearance.BorderSize = 0;
            this.StartConnectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartConnectionBtn.Location = new System.Drawing.Point(4, 90);
            this.StartConnectionBtn.Name = "StartConnectionBtn";
            this.StartConnectionBtn.Size = new System.Drawing.Size(98, 37);
            this.StartConnectionBtn.TabIndex = 3;
            this.StartConnectionBtn.Text = "Start Connections";
            this.StartConnectionBtn.UseVisualStyleBackColor = false;
            this.StartConnectionBtn.Click += new System.EventHandler(this.StartAssets);
            // 
            // GenerateAssetsBtn
            // 
            this.GenerateAssetsBtn.BackColor = System.Drawing.Color.LightGreen;
            this.GenerateAssetsBtn.FlatAppearance.BorderSize = 0;
            this.GenerateAssetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateAssetsBtn.Location = new System.Drawing.Point(4, 26);
            this.GenerateAssetsBtn.Name = "GenerateAssetsBtn";
            this.GenerateAssetsBtn.Size = new System.Drawing.Size(79, 58);
            this.GenerateAssetsBtn.TabIndex = 2;
            this.GenerateAssetsBtn.Text = "Genrate Asset Panels";
            this.GenerateAssetsBtn.UseVisualStyleBackColor = false;
            this.GenerateAssetsBtn.Click += new System.EventHandler(this.GenerateAssetControls);
            // 
            // GroupList
            // 
            this.GroupList.BackColor = System.Drawing.SystemColors.Control;
            this.GroupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(89, 9);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(107, 75);
            this.GroupList.TabIndex = 1;
            this.GroupList.MouseHover += new System.EventHandler(this.Grouplist_Update_List);
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Location = new System.Drawing.Point(3, 9);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(80, 13);
            this.ChooseLabel.TabIndex = 0;
            this.ChooseLabel.Text = "Choose Assets:";
            // 
            // AllPanel
            // 
            this.AllPanel.Location = new System.Drawing.Point(6, 343);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.Size = new System.Drawing.Size(77, 77);
            this.AllPanel.TabIndex = 15;
            // 
            // AllSend
            // 
            this.AllSend.BackColor = System.Drawing.Color.LightGreen;
            this.AllSend.Location = new System.Drawing.Point(6, 426);
            this.AllSend.Name = "AllSend";
            this.AllSend.Size = new System.Drawing.Size(77, 23);
            this.AllSend.TabIndex = 16;
            this.AllSend.Text = "Send";
            this.AllSend.UseVisualStyleBackColor = false;
            this.AllSend.Click += new System.EventHandler(this.AllGenerateAndSend);
            // 
            // AllMode
            // 
            this.AllMode.FormattingEnabled = true;
            this.AllMode.Location = new System.Drawing.Point(90, 343);
            this.AllMode.Name = "AllMode";
            this.AllMode.Size = new System.Drawing.Size(103, 21);
            this.AllMode.TabIndex = 17;
            this.AllMode.MouseHover += new System.EventHandler(this.AllModeChanged);
            // 
            // AllDelay
            // 
            this.AllDelay.Location = new System.Drawing.Point(90, 371);
            this.AllDelay.Name = "AllDelay";
            this.AllDelay.Size = new System.Drawing.Size(103, 20);
            this.AllDelay.TabIndex = 18;
            this.AllDelay.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(90, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AllColorChanged);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 503);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Group";
            this.Text = "Group Asset Control";
            this.Load += new System.EventHandler(this.Group_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.CheckedListBox GroupList;
        private System.Windows.Forms.Button GenerateAssetsBtn;
        private System.Windows.Forms.Button StartConnectionBtn;
        private System.Windows.Forms.Button EndConnectionsBtn;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label TimedSend;
        private System.Windows.Forms.Button QueCommands;
        private System.Windows.Forms.Button CurCommands;
        private System.Windows.Forms.Label QingLabel;
        private System.Windows.Forms.CheckBox RunLoopCheck;
        private System.Windows.Forms.Button TimeQueBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.TextBox AllDelay;
        private System.Windows.Forms.ComboBox AllMode;
        private System.Windows.Forms.Button AllSend;
        private System.Windows.Forms.Panel AllPanel;
        private System.Windows.Forms.Button button1;
    }
}