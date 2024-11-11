﻿// This is free and unencumbered software released into the public domain under The Unlicense.
// You have complete freedom to do anything you want with the software, for any purpose.
// Please refer to <http://unlicense.org/>

namespace Schuub.DesktopAlarmClock
{
  partial class MediaPlayerAlarmingForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerAlarmingForm));
      axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
      ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
      SuspendLayout();
      // 
      // axWindowsMediaPlayer1
      // 
      axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
      axWindowsMediaPlayer1.Enabled = true;
      axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
      axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
      axWindowsMediaPlayer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
      axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 450);
      axWindowsMediaPlayer1.TabIndex = 0;
      // 
      // MediaPlayerAlarmingForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(800, 450);
      Controls.Add(axWindowsMediaPlayer1);
      Name = "MediaPlayerAlarmingForm";
      Text = "MediaPlayerAlarmingForm";
      Load += MediaPlayerAlarmingForm_Load;
      ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
  }
}