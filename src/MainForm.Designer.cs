﻿/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 01/25/2017
 * Time: 4:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NewAshAIO
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ipBox;
		private System.Windows.Forms.Button connectBox;
		private System.Windows.Forms.Button disconnectBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button transparentInklingButton;
		private System.Windows.Forms.Button smallInklingButton;
		private System.Windows.Forms.Button noInklingButton;
		private System.Windows.Forms.Button makeEverythingSmallButton;
		private System.Windows.Forms.Button makeEverythingBigButton;
		private System.Windows.Forms.Button lightInkButton;
		private System.Windows.Forms.Button glowingStageButton;
		private System.Windows.Forms.Button giantInklingButton;
		private System.Windows.Forms.Button darkInkButton;
		private System.Windows.Forms.Button bigInklingButton;
		private System.Windows.Forms.Button invisibilityTwoButton;
		private System.Windows.Forms.Button deleteInklingButton;
		private System.Windows.Forms.Button bombBounceButton;
		private System.Windows.Forms.Button bounceWalkButton;
		private System.Windows.Forms.Button speedButton;
		private System.Windows.Forms.Button sustainedJumpButton;
		private System.Windows.Forms.Button wipFlyButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button faceplantButton;
		private System.Windows.Forms.Button stanceAngleButton;
		private System.Windows.Forms.Button whiteBlindInkButton;
		private System.Windows.Forms.Button fromBeginningButton;
		private System.Windows.Forms.Button smoothTexButton;
		private System.Windows.Forms.Button corruptTexButton;
		private System.Windows.Forms.Button bigInvInklingButton;
		private System.Windows.Forms.Button crazyTankButton;
		private System.Windows.Forms.Button noHeadButton;
		private System.Windows.Forms.Button apelingButton;
		private System.Windows.Forms.Button alphaButton;
		private System.Windows.Forms.Button tentacleModButton;
		private System.Windows.Forms.Button cinemaModeButton;
		private System.Windows.Forms.Button glideButton;
		private System.Windows.Forms.Button revertButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewPovlursSiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewHexexpecksSiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewASHTeamSiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem joinASHTeamDiscordToolStripMenuItem;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAshAIOToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewChangelogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ashAIOLicenseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoAboutHacksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikiHomepageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewSourceCodeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem1;
		private System.Windows.Forms.TabControl hackBrowser;
		private System.Windows.Forms.TabPage safeHacks;
		private System.Windows.Forms.TabPage dangerousHacks;
		private System.Windows.Forms.ToolStripMenuItem relatedProjectsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon ashAioNotifyIcon;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moddedTCPGeckoClientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewMyPCsIPAddressToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.connectBox = new System.Windows.Forms.Button();
            this.disconnectBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fromBeginningButton = new System.Windows.Forms.Button();
            this.smoothTexButton = new System.Windows.Forms.Button();
            this.corruptTexButton = new System.Windows.Forms.Button();
            this.bounceWalkButton = new System.Windows.Forms.Button();
            this.bigInvInklingButton = new System.Windows.Forms.Button();
            this.crazyTankButton = new System.Windows.Forms.Button();
            this.noHeadButton = new System.Windows.Forms.Button();
            this.apelingButton = new System.Windows.Forms.Button();
            this.alphaButton = new System.Windows.Forms.Button();
            this.tentacleModButton = new System.Windows.Forms.Button();
            this.cinemaModeButton = new System.Windows.Forms.Button();
            this.glideButton = new System.Windows.Forms.Button();
            this.faceplantButton = new System.Windows.Forms.Button();
            this.stanceAngleButton = new System.Windows.Forms.Button();
            this.whiteBlindInkButton = new System.Windows.Forms.Button();
            this.transparentInklingButton = new System.Windows.Forms.Button();
            this.smallInklingButton = new System.Windows.Forms.Button();
            this.noInklingButton = new System.Windows.Forms.Button();
            this.makeEverythingSmallButton = new System.Windows.Forms.Button();
            this.makeEverythingBigButton = new System.Windows.Forms.Button();
            this.lightInkButton = new System.Windows.Forms.Button();
            this.glowingStageButton = new System.Windows.Forms.Button();
            this.giantInklingButton = new System.Windows.Forms.Button();
            this.darkInkButton = new System.Windows.Forms.Button();
            this.bigInklingButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.invisibilityTwoButton = new System.Windows.Forms.Button();
            this.deleteInklingButton = new System.Windows.Forms.Button();
            this.bombBounceButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.sustainedJumpButton = new System.Windows.Forms.Button();
            this.wipFlyButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPovlursSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHexexpecksSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewASHTeamSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinASHTeamDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAshAIOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChangelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ashAIOLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAboutHacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatedProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moddedTCPGeckoClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyPCsIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.hackBrowser = new System.Windows.Forms.TabControl();
            this.safeHacks = new System.Windows.Forms.TabPage();
            this.hideGUIButton = new System.Windows.Forms.Button();
            this.dangerousHacks = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ashAioNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.hackBrowser.SuspendLayout();
            this.safeHacks.SuspendLayout();
            this.dangerousHacks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Wii U IP address:";
            // 
            // ipBox
            // 
            this.ipBox.HideSelection = false;
            this.ipBox.Location = new System.Drawing.Point(136, 13);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(117, 20);
            this.ipBox.TabIndex = 1;
            // 
            // connectBox
            // 
            this.connectBox.Location = new System.Drawing.Point(259, 11);
            this.connectBox.Name = "connectBox";
            this.connectBox.Size = new System.Drawing.Size(75, 23);
            this.connectBox.TabIndex = 2;
            this.connectBox.Text = "Connect";
            this.connectBox.UseVisualStyleBackColor = true;
            this.connectBox.Click += new System.EventHandler(this.ConnectBoxClick);
            // 
            // disconnectBox
            // 
            this.disconnectBox.Location = new System.Drawing.Point(340, 11);
            this.disconnectBox.Name = "disconnectBox";
            this.disconnectBox.Size = new System.Drawing.Size(75, 23);
            this.disconnectBox.TabIndex = 3;
            this.disconnectBox.Text = "Disconnect";
            this.disconnectBox.UseVisualStyleBackColor = true;
            this.disconnectBox.Click += new System.EventHandler(this.DisconnectBoxClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(277, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Some hacks in here may crash your Wii U. Use with caution";
            // 
            // fromBeginningButton
            // 
            this.fromBeginningButton.Location = new System.Drawing.Point(316, 150);
            this.fromBeginningButton.Name = "fromBeginningButton";
            this.fromBeginningButton.Size = new System.Drawing.Size(112, 23);
            this.fromBeginningButton.TabIndex = 23;
            this.fromBeginningButton.Text = "From the Start";
            this.fromBeginningButton.UseVisualStyleBackColor = true;
            this.fromBeginningButton.Click += new System.EventHandler(this.FromBeginningButtonClick);
            // 
            // smoothTexButton
            // 
            this.smoothTexButton.Location = new System.Drawing.Point(218, 150);
            this.smoothTexButton.Name = "smoothTexButton";
            this.smoothTexButton.Size = new System.Drawing.Size(92, 23);
            this.smoothTexButton.TabIndex = 22;
            this.smoothTexButton.Text = "Smooth Texture";
            this.smoothTexButton.UseVisualStyleBackColor = true;
            this.smoothTexButton.Click += new System.EventHandler(this.SmoothTexButtonClick);
            // 
            // corruptTexButton
            // 
            this.corruptTexButton.Location = new System.Drawing.Point(100, 150);
            this.corruptTexButton.Name = "corruptTexButton";
            this.corruptTexButton.Size = new System.Drawing.Size(112, 23);
            this.corruptTexButton.TabIndex = 21;
            this.corruptTexButton.Text = "Corrupt Textures";
            this.corruptTexButton.UseVisualStyleBackColor = true;
            this.corruptTexButton.Click += new System.EventHandler(this.CorruptTexButtonClick);
            // 
            // bounceWalkButton
            // 
            this.bounceWalkButton.Location = new System.Drawing.Point(6, 178);
            this.bounceWalkButton.Name = "bounceWalkButton";
            this.bounceWalkButton.Size = new System.Drawing.Size(92, 23);
            this.bounceWalkButton.TabIndex = 3;
            this.bounceWalkButton.Text = "Bouncy Walk";
            this.bounceWalkButton.UseVisualStyleBackColor = true;
            this.bounceWalkButton.Click += new System.EventHandler(this.BounceWalkButtonClick);
            // 
            // bigInvInklingButton
            // 
            this.bigInvInklingButton.Location = new System.Drawing.Point(6, 150);
            this.bigInvInklingButton.Name = "bigInvInklingButton";
            this.bigInvInklingButton.Size = new System.Drawing.Size(92, 23);
            this.bigInvInklingButton.TabIndex = 20;
            this.bigInvInklingButton.Text = "BigInvInkling";
            this.bigInvInklingButton.UseVisualStyleBackColor = true;
            this.bigInvInklingButton.Click += new System.EventHandler(this.BigInvInklingButtonClick);
            // 
            // crazyTankButton
            // 
            this.crazyTankButton.Location = new System.Drawing.Point(316, 122);
            this.crazyTankButton.Name = "crazyTankButton";
            this.crazyTankButton.Size = new System.Drawing.Size(112, 23);
            this.crazyTankButton.TabIndex = 19;
            this.crazyTankButton.Text = "Crazy Ink Tank";
            this.crazyTankButton.UseVisualStyleBackColor = true;
            this.crazyTankButton.Click += new System.EventHandler(this.CrazyTankButtonClick);
            // 
            // noHeadButton
            // 
            this.noHeadButton.Location = new System.Drawing.Point(218, 122);
            this.noHeadButton.Name = "noHeadButton";
            this.noHeadButton.Size = new System.Drawing.Size(92, 23);
            this.noHeadButton.TabIndex = 18;
            this.noHeadButton.Text = "Headless Body";
            this.noHeadButton.UseVisualStyleBackColor = true;
            this.noHeadButton.Click += new System.EventHandler(this.NoHeadButtonClick);
            // 
            // apelingButton
            // 
            this.apelingButton.Location = new System.Drawing.Point(100, 122);
            this.apelingButton.Name = "apelingButton";
            this.apelingButton.Size = new System.Drawing.Size(112, 23);
            this.apelingButton.TabIndex = 17;
            this.apelingButton.Text = "Apeling/Apelong";
            this.apelingButton.UseVisualStyleBackColor = true;
            this.apelingButton.Click += new System.EventHandler(this.ApelingButtonClick);
            // 
            // alphaButton
            // 
            this.alphaButton.Location = new System.Drawing.Point(6, 122);
            this.alphaButton.Name = "alphaButton";
            this.alphaButton.Size = new System.Drawing.Size(92, 23);
            this.alphaButton.TabIndex = 16;
            this.alphaButton.Text = "AlphaHax";
            this.alphaButton.UseVisualStyleBackColor = true;
            this.alphaButton.Click += new System.EventHandler(this.AlphaButtonClick);
            // 
            // tentacleModButton
            // 
            this.tentacleModButton.Location = new System.Drawing.Point(316, 93);
            this.tentacleModButton.Name = "tentacleModButton";
            this.tentacleModButton.Size = new System.Drawing.Size(112, 23);
            this.tentacleModButton.TabIndex = 15;
            this.tentacleModButton.Text = "Tentacle Mod";
            this.tentacleModButton.UseVisualStyleBackColor = true;
            this.tentacleModButton.Click += new System.EventHandler(this.TentacleModButtonClick);
            // 
            // cinemaModeButton
            // 
            this.cinemaModeButton.Location = new System.Drawing.Point(218, 92);
            this.cinemaModeButton.Name = "cinemaModeButton";
            this.cinemaModeButton.Size = new System.Drawing.Size(92, 24);
            this.cinemaModeButton.TabIndex = 14;
            this.cinemaModeButton.Text = "Cinema Mode";
            this.cinemaModeButton.UseVisualStyleBackColor = true;
            this.cinemaModeButton.Click += new System.EventHandler(this.CinemaModeButtonClick);
            // 
            // glideButton
            // 
            this.glideButton.Location = new System.Drawing.Point(100, 93);
            this.glideButton.Name = "glideButton";
            this.glideButton.Size = new System.Drawing.Size(112, 23);
            this.glideButton.TabIndex = 13;
            this.glideButton.Text = "Glide";
            this.glideButton.UseVisualStyleBackColor = true;
            this.glideButton.Click += new System.EventHandler(this.GlideButtonClick);
            // 
            // faceplantButton
            // 
            this.faceplantButton.Location = new System.Drawing.Point(6, 93);
            this.faceplantButton.Name = "faceplantButton";
            this.faceplantButton.Size = new System.Drawing.Size(92, 23);
            this.faceplantButton.TabIndex = 12;
            this.faceplantButton.Text = "Faceplant";
            this.faceplantButton.UseVisualStyleBackColor = true;
            this.faceplantButton.Click += new System.EventHandler(this.FaceplantButtonClick);
            // 
            // stanceAngleButton
            // 
            this.stanceAngleButton.Location = new System.Drawing.Point(316, 64);
            this.stanceAngleButton.Name = "stanceAngleButton";
            this.stanceAngleButton.Size = new System.Drawing.Size(112, 23);
            this.stanceAngleButton.TabIndex = 11;
            this.stanceAngleButton.Text = "Stance Angle";
            this.stanceAngleButton.UseVisualStyleBackColor = true;
            this.stanceAngleButton.Click += new System.EventHandler(this.StanceAngleButtonClick);
            // 
            // whiteBlindInkButton
            // 
            this.whiteBlindInkButton.Location = new System.Drawing.Point(218, 64);
            this.whiteBlindInkButton.Name = "whiteBlindInkButton";
            this.whiteBlindInkButton.Size = new System.Drawing.Size(92, 23);
            this.whiteBlindInkButton.TabIndex = 10;
            this.whiteBlindInkButton.Text = "White/Blind Ink";
            this.whiteBlindInkButton.UseVisualStyleBackColor = true;
            this.whiteBlindInkButton.Click += new System.EventHandler(this.WhiteBlindInkButtonClick);
            // 
            // transparentInklingButton
            // 
            this.transparentInklingButton.Location = new System.Drawing.Point(100, 64);
            this.transparentInklingButton.Name = "transparentInklingButton";
            this.transparentInklingButton.Size = new System.Drawing.Size(112, 23);
            this.transparentInklingButton.TabIndex = 9;
            this.transparentInklingButton.Text = "Transparent Inkling";
            this.transparentInklingButton.UseVisualStyleBackColor = true;
            this.transparentInklingButton.Click += new System.EventHandler(this.TransparentInklingButtonClick);
            // 
            // smallInklingButton
            // 
            this.smallInklingButton.Location = new System.Drawing.Point(6, 64);
            this.smallInklingButton.Name = "smallInklingButton";
            this.smallInklingButton.Size = new System.Drawing.Size(92, 23);
            this.smallInklingButton.TabIndex = 8;
            this.smallInklingButton.Text = "Small Inkling";
            this.smallInklingButton.UseVisualStyleBackColor = true;
            this.smallInklingButton.Click += new System.EventHandler(this.SmallInklingButtonClick);
            // 
            // noInklingButton
            // 
            this.noInklingButton.Location = new System.Drawing.Point(316, 35);
            this.noInklingButton.Name = "noInklingButton";
            this.noInklingButton.Size = new System.Drawing.Size(112, 23);
            this.noInklingButton.TabIndex = 7;
            this.noInklingButton.Text = "No Inkling";
            this.noInklingButton.UseVisualStyleBackColor = true;
            this.noInklingButton.Click += new System.EventHandler(this.NoInklingButtonClick);
            // 
            // makeEverythingSmallButton
            // 
            this.makeEverythingSmallButton.Location = new System.Drawing.Point(218, 35);
            this.makeEverythingSmallButton.Name = "makeEverythingSmallButton";
            this.makeEverythingSmallButton.Size = new System.Drawing.Size(92, 23);
            this.makeEverythingSmallButton.TabIndex = 6;
            this.makeEverythingSmallButton.Text = "Make All Small";
            this.makeEverythingSmallButton.UseVisualStyleBackColor = true;
            this.makeEverythingSmallButton.Click += new System.EventHandler(this.MakeEverythingSmallButtonClick);
            // 
            // makeEverythingBigButton
            // 
            this.makeEverythingBigButton.Location = new System.Drawing.Point(100, 35);
            this.makeEverythingBigButton.Name = "makeEverythingBigButton";
            this.makeEverythingBigButton.Size = new System.Drawing.Size(112, 23);
            this.makeEverythingBigButton.TabIndex = 5;
            this.makeEverythingBigButton.Text = "Make All Things Big";
            this.makeEverythingBigButton.UseVisualStyleBackColor = true;
            this.makeEverythingBigButton.Click += new System.EventHandler(this.MakeEverythingBigButtonClick);
            // 
            // lightInkButton
            // 
            this.lightInkButton.Location = new System.Drawing.Point(6, 35);
            this.lightInkButton.Name = "lightInkButton";
            this.lightInkButton.Size = new System.Drawing.Size(92, 23);
            this.lightInkButton.TabIndex = 4;
            this.lightInkButton.Text = "Lighter Ink";
            this.lightInkButton.UseVisualStyleBackColor = true;
            this.lightInkButton.Click += new System.EventHandler(this.LightInkButtonClick);
            // 
            // glowingStageButton
            // 
            this.glowingStageButton.Location = new System.Drawing.Point(316, 6);
            this.glowingStageButton.Name = "glowingStageButton";
            this.glowingStageButton.Size = new System.Drawing.Size(112, 23);
            this.glowingStageButton.TabIndex = 3;
            this.glowingStageButton.Text = "Glowing Stage";
            this.glowingStageButton.UseVisualStyleBackColor = true;
            this.glowingStageButton.Click += new System.EventHandler(this.GlowingStageButtonClick);
            // 
            // giantInklingButton
            // 
            this.giantInklingButton.Location = new System.Drawing.Point(218, 6);
            this.giantInklingButton.Name = "giantInklingButton";
            this.giantInklingButton.Size = new System.Drawing.Size(92, 23);
            this.giantInklingButton.TabIndex = 2;
            this.giantInklingButton.Text = "Giant Inkling";
            this.giantInklingButton.UseVisualStyleBackColor = true;
            this.giantInklingButton.Click += new System.EventHandler(this.GiantInklingButtonClick);
            // 
            // darkInkButton
            // 
            this.darkInkButton.Location = new System.Drawing.Point(100, 6);
            this.darkInkButton.Name = "darkInkButton";
            this.darkInkButton.Size = new System.Drawing.Size(112, 23);
            this.darkInkButton.TabIndex = 1;
            this.darkInkButton.Text = "Darker Ink";
            this.darkInkButton.UseVisualStyleBackColor = true;
            this.darkInkButton.Click += new System.EventHandler(this.DarkInkButtonClick);
            // 
            // bigInklingButton
            // 
            this.bigInklingButton.Location = new System.Drawing.Point(6, 6);
            this.bigInklingButton.Name = "bigInklingButton";
            this.bigInklingButton.Size = new System.Drawing.Size(92, 23);
            this.bigInklingButton.TabIndex = 0;
            this.bigInklingButton.Text = "Big Inkling";
            this.bigInklingButton.UseVisualStyleBackColor = true;
            this.bigInklingButton.Click += new System.EventHandler(this.BigInklingButtonClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(244, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "ASH Team is not responsible if you get banned while using these dangerous hacks, " +
    "so use them at your own risk.";
            // 
            // invisibilityTwoButton
            // 
            this.invisibilityTwoButton.Location = new System.Drawing.Point(6, 35);
            this.invisibilityTwoButton.Name = "invisibilityTwoButton";
            this.invisibilityTwoButton.Size = new System.Drawing.Size(92, 23);
            this.invisibilityTwoButton.TabIndex = 6;
            this.invisibilityTwoButton.Text = "Invisibility 2.0";
            this.invisibilityTwoButton.UseVisualStyleBackColor = true;
            this.invisibilityTwoButton.Click += new System.EventHandler(this.InvisibilityTwoButtonClick);
            // 
            // deleteInklingButton
            // 
            this.deleteInklingButton.Location = new System.Drawing.Point(100, 35);
            this.deleteInklingButton.Name = "deleteInklingButton";
            this.deleteInklingButton.Size = new System.Drawing.Size(112, 23);
            this.deleteInklingButton.TabIndex = 5;
            this.deleteInklingButton.Text = "?NoInkling";
            this.deleteInklingButton.UseVisualStyleBackColor = true;
            this.deleteInklingButton.Click += new System.EventHandler(this.DeleteInklingButtonClick);
            // 
            // bombBounceButton
            // 
            this.bombBounceButton.Location = new System.Drawing.Point(316, 6);
            this.bombBounceButton.Name = "bombBounceButton";
            this.bombBounceButton.Size = new System.Drawing.Size(112, 23);
            this.bombBounceButton.TabIndex = 4;
            this.bombBounceButton.Text = "Bomb Bounce";
            this.bombBounceButton.UseVisualStyleBackColor = true;
            this.bombBounceButton.Click += new System.EventHandler(this.BombBounceButtonClick);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(218, 6);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(92, 23);
            this.speedButton.TabIndex = 2;
            this.speedButton.Text = "SpeedHax";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.SpeedButtonClick);
            // 
            // sustainedJumpButton
            // 
            this.sustainedJumpButton.Location = new System.Drawing.Point(100, 6);
            this.sustainedJumpButton.Name = "sustainedJumpButton";
            this.sustainedJumpButton.Size = new System.Drawing.Size(112, 23);
            this.sustainedJumpButton.TabIndex = 1;
            this.sustainedJumpButton.Text = "Sustained Jump";
            this.sustainedJumpButton.UseMnemonic = false;
            this.sustainedJumpButton.UseVisualStyleBackColor = true;
            this.sustainedJumpButton.Click += new System.EventHandler(this.SustainedJumpButtonClick);
            // 
            // wipFlyButton
            // 
            this.wipFlyButton.Location = new System.Drawing.Point(6, 6);
            this.wipFlyButton.Name = "wipFlyButton";
            this.wipFlyButton.Size = new System.Drawing.Size(92, 23);
            this.wipFlyButton.TabIndex = 0;
            this.wipFlyButton.Text = "WIP Flyhax";
            this.wipFlyButton.UseVisualStyleBackColor = true;
            this.wipFlyButton.Click += new System.EventHandler(this.WipFlyButtonClick);
            // 
            // revertButton
            // 
            this.revertButton.Location = new System.Drawing.Point(147, 340);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(179, 26);
            this.revertButton.TabIndex = 13;
            this.revertButton.Text = "Revert all hacks applied";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.RevertButtonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miscellaneousToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.wikiToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "‎Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // miscellaneousToolStripMenuItem
            // 
            this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPovlursSiteToolStripMenuItem,
            this.viewHexexpecksSiteToolStripMenuItem,
            this.viewASHTeamSiteToolStripMenuItem,
            this.joinASHTeamDiscordToolStripMenuItem});
            this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.miscellaneousToolStripMenuItem.Text = "Links and sites";
            // 
            // viewPovlursSiteToolStripMenuItem
            // 
            this.viewPovlursSiteToolStripMenuItem.Name = "viewPovlursSiteToolStripMenuItem";
            this.viewPovlursSiteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewPovlursSiteToolStripMenuItem.Text = "View povlur\'s site";
            this.viewPovlursSiteToolStripMenuItem.Click += new System.EventHandler(this.ViewPovlursSiteToolStripMenuItemClick);
            // 
            // viewHexexpecksSiteToolStripMenuItem
            // 
            this.viewHexexpecksSiteToolStripMenuItem.Name = "viewHexexpecksSiteToolStripMenuItem";
            this.viewHexexpecksSiteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewHexexpecksSiteToolStripMenuItem.Text = "View Hexexpeck\'s site";
            this.viewHexexpecksSiteToolStripMenuItem.Click += new System.EventHandler(this.ViewHexexpecksSiteToolStripMenuItemClick);
            // 
            // viewASHTeamSiteToolStripMenuItem
            // 
            this.viewASHTeamSiteToolStripMenuItem.Name = "viewASHTeamSiteToolStripMenuItem";
            this.viewASHTeamSiteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewASHTeamSiteToolStripMenuItem.Text = "View ASH Team site";
            this.viewASHTeamSiteToolStripMenuItem.Click += new System.EventHandler(this.ViewASHTeamSiteToolStripMenuItemClick);
            // 
            // joinASHTeamDiscordToolStripMenuItem
            // 
            this.joinASHTeamDiscordToolStripMenuItem.Name = "joinASHTeamDiscordToolStripMenuItem";
            this.joinASHTeamDiscordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.joinASHTeamDiscordToolStripMenuItem.Text = "Join ASH Team Discord";
            this.joinASHTeamDiscordToolStripMenuItem.Click += new System.EventHandler(this.JoinASHTeamDiscordToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAshAIOToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem,
            this.viewChangelogToolStripMenuItem,
            this.ashAIOLicenseToolStripMenuItem,
            this.viewSourceCodeToolStripMenuItem1,
            this.reportAnIssueToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutAshAIOToolStripMenuItem1
            // 
            this.aboutAshAIOToolStripMenuItem1.Name = "aboutAshAIOToolStripMenuItem1";
            this.aboutAshAIOToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.aboutAshAIOToolStripMenuItem1.Text = "About AshAIO";
            this.aboutAshAIOToolStripMenuItem1.Click += new System.EventHandler(this.AboutAshAIOToolStripMenuItem1Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItemClick);
            // 
            // viewChangelogToolStripMenuItem
            // 
            this.viewChangelogToolStripMenuItem.Name = "viewChangelogToolStripMenuItem";
            this.viewChangelogToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewChangelogToolStripMenuItem.Text = "View changelog";
            this.viewChangelogToolStripMenuItem.Click += new System.EventHandler(this.ViewChangelogToolStripMenuItemClick);
            // 
            // ashAIOLicenseToolStripMenuItem
            // 
            this.ashAIOLicenseToolStripMenuItem.Name = "ashAIOLicenseToolStripMenuItem";
            this.ashAIOLicenseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ashAIOLicenseToolStripMenuItem.Text = "AshAIO License";
            this.ashAIOLicenseToolStripMenuItem.Click += new System.EventHandler(this.AshAIOLicenseToolStripMenuItemClick);
            // 
            // viewSourceCodeToolStripMenuItem1
            // 
            this.viewSourceCodeToolStripMenuItem1.Name = "viewSourceCodeToolStripMenuItem1";
            this.viewSourceCodeToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.viewSourceCodeToolStripMenuItem1.Text = "View Source Code";
            this.viewSourceCodeToolStripMenuItem1.Click += new System.EventHandler(this.ViewSourceCodeToolStripMenuItem1Click);
            // 
            // reportAnIssueToolStripMenuItem1
            // 
            this.reportAnIssueToolStripMenuItem1.Name = "reportAnIssueToolStripMenuItem1";
            this.reportAnIssueToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.reportAnIssueToolStripMenuItem1.Text = "Report an issue";
            this.reportAnIssueToolStripMenuItem1.Click += new System.EventHandler(this.ReportAnIssueToolStripMenuItem1Click);
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoAboutHacksToolStripMenuItem,
            this.wikiHomepageToolStripMenuItem,
            this.relatedProjectsToolStripMenuItem});
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.wikiToolStripMenuItem.Text = "Help";
            // 
            // infoAboutHacksToolStripMenuItem
            // 
            this.infoAboutHacksToolStripMenuItem.Name = "infoAboutHacksToolStripMenuItem";
            this.infoAboutHacksToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.infoAboutHacksToolStripMenuItem.Text = "Info about hacks";
            this.infoAboutHacksToolStripMenuItem.Click += new System.EventHandler(this.InfoAboutHacksToolStripMenuItemClick);
            // 
            // wikiHomepageToolStripMenuItem
            // 
            this.wikiHomepageToolStripMenuItem.Name = "wikiHomepageToolStripMenuItem";
            this.wikiHomepageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wikiHomepageToolStripMenuItem.Text = "Wiki Homepage";
            this.wikiHomepageToolStripMenuItem.Click += new System.EventHandler(this.WikiHomepageToolStripMenuItemClick);
            // 
            // relatedProjectsToolStripMenuItem
            // 
            this.relatedProjectsToolStripMenuItem.Name = "relatedProjectsToolStripMenuItem";
            this.relatedProjectsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.relatedProjectsToolStripMenuItem.Text = "Related projects";
            this.relatedProjectsToolStripMenuItem.Click += new System.EventHandler(this.RelatedProjectsToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moddedTCPGeckoClientToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.viewMyPCsIPAddressToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // moddedTCPGeckoClientToolStripMenuItem
            // 
            this.moddedTCPGeckoClientToolStripMenuItem.Name = "moddedTCPGeckoClientToolStripMenuItem";
            this.moddedTCPGeckoClientToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.moddedTCPGeckoClientToolStripMenuItem.Text = "TCPGecko Client";
            this.moddedTCPGeckoClientToolStripMenuItem.Click += new System.EventHandler(this.ModdedTCPGeckoClientToolStripMenuItemClick);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.NotepadToolStripMenuItemClick);
            // 
            // viewMyPCsIPAddressToolStripMenuItem
            // 
            this.viewMyPCsIPAddressToolStripMenuItem.Name = "viewMyPCsIPAddressToolStripMenuItem";
            this.viewMyPCsIPAddressToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.viewMyPCsIPAddressToolStripMenuItem.Text = "View my PC\'s IP address";
            this.viewMyPCsIPAddressToolStripMenuItem.Click += new System.EventHandler(this.ViewMyPCsIPAddressToolStripMenuItemClick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://github.com/ASHTeam/ash-aio-2/wiki";
            // 
            // hackBrowser
            // 
            this.hackBrowser.Controls.Add(this.safeHacks);
            this.hackBrowser.Controls.Add(this.dangerousHacks);
            this.hackBrowser.Location = new System.Drawing.Point(12, 76);
            this.hackBrowser.Name = "hackBrowser";
            this.hackBrowser.SelectedIndex = 0;
            this.hackBrowser.Size = new System.Drawing.Size(445, 256);
            this.hackBrowser.TabIndex = 15;
            // 
            // safeHacks
            // 
            this.safeHacks.BackColor = System.Drawing.SystemColors.Control;
            this.safeHacks.Controls.Add(this.label2);
            this.safeHacks.Controls.Add(this.bigInklingButton);
            this.safeHacks.Controls.Add(this.bounceWalkButton);
            this.safeHacks.Controls.Add(this.fromBeginningButton);
            this.safeHacks.Controls.Add(this.darkInkButton);
            this.safeHacks.Controls.Add(this.smoothTexButton);
            this.safeHacks.Controls.Add(this.giantInklingButton);
            this.safeHacks.Controls.Add(this.hideGUIButton);
            this.safeHacks.Controls.Add(this.corruptTexButton);
            this.safeHacks.Controls.Add(this.glowingStageButton);
            this.safeHacks.Controls.Add(this.lightInkButton);
            this.safeHacks.Controls.Add(this.bigInvInklingButton);
            this.safeHacks.Controls.Add(this.makeEverythingBigButton);
            this.safeHacks.Controls.Add(this.crazyTankButton);
            this.safeHacks.Controls.Add(this.makeEverythingSmallButton);
            this.safeHacks.Controls.Add(this.noHeadButton);
            this.safeHacks.Controls.Add(this.noInklingButton);
            this.safeHacks.Controls.Add(this.apelingButton);
            this.safeHacks.Controls.Add(this.smallInklingButton);
            this.safeHacks.Controls.Add(this.alphaButton);
            this.safeHacks.Controls.Add(this.transparentInklingButton);
            this.safeHacks.Controls.Add(this.tentacleModButton);
            this.safeHacks.Controls.Add(this.whiteBlindInkButton);
            this.safeHacks.Controls.Add(this.cinemaModeButton);
            this.safeHacks.Controls.Add(this.stanceAngleButton);
            this.safeHacks.Controls.Add(this.glideButton);
            this.safeHacks.Controls.Add(this.faceplantButton);
            this.safeHacks.Location = new System.Drawing.Point(4, 22);
            this.safeHacks.Name = "safeHacks";
            this.safeHacks.Padding = new System.Windows.Forms.Padding(3);
            this.safeHacks.Size = new System.Drawing.Size(437, 230);
            this.safeHacks.TabIndex = 0;
            this.safeHacks.Text = "Safe Hacks";
            // 
            // hideGUIButton
            // 
            this.hideGUIButton.Location = new System.Drawing.Point(100, 178);
            this.hideGUIButton.Name = "hideGUIButton";
            this.hideGUIButton.Size = new System.Drawing.Size(112, 23);
            this.hideGUIButton.TabIndex = 21;
            this.hideGUIButton.Text = "Hide GUI";
            this.hideGUIButton.UseVisualStyleBackColor = true;
            this.hideGUIButton.Click += new System.EventHandler(this.hideGUIButton_Click);
            // 
            // dangerousHacks
            // 
            this.dangerousHacks.BackColor = System.Drawing.SystemColors.Control;
            this.dangerousHacks.Controls.Add(this.label5);
            this.dangerousHacks.Controls.Add(this.wipFlyButton);
            this.dangerousHacks.Controls.Add(this.deleteInklingButton);
            this.dangerousHacks.Controls.Add(this.invisibilityTwoButton);
            this.dangerousHacks.Controls.Add(this.sustainedJumpButton);
            this.dangerousHacks.Controls.Add(this.speedButton);
            this.dangerousHacks.Controls.Add(this.bombBounceButton);
            this.dangerousHacks.Location = new System.Drawing.Point(4, 22);
            this.dangerousHacks.Name = "dangerousHacks";
            this.dangerousHacks.Padding = new System.Windows.Forms.Padding(3);
            this.dangerousHacks.Size = new System.Drawing.Size(437, 230);
            this.dangerousHacks.TabIndex = 1;
            this.dangerousHacks.Text = "Dangerous Hacks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ipBox);
            this.groupBox1.Controls.Add(this.connectBox);
            this.groupBox1.Controls.Add(this.disconnectBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPGecko Connection";
            // 
            // ashAioNotifyIcon
            // 
            this.ashAioNotifyIcon.BalloonTipText = "AshAIO is running";
            this.ashAioNotifyIcon.BalloonTipTitle = "AshAIO";
            this.ashAioNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ashAioNotifyIcon.Icon")));
            this.ashAioNotifyIcon.Text = "AshAIO";
            this.ashAioNotifyIcon.Visible = true;
            this.ashAioNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AshAioNotifyIconMouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 401);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hackBrowser);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AshAIO";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hackBrowser.ResumeLayout(false);
            this.safeHacks.ResumeLayout(false);
            this.dangerousHacks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button hideGUIButton;
    }
}
