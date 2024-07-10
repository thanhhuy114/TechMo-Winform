using TechMo.GUI.UserControls;
using TechMo.Models;
using System.Collections.Generic;
using System.Web.UI;
using System.Windows.Forms;

namespace TechMo.GUI.Forms
{
    partial class frmConfigDetail
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lableMess = new System.Windows.Forms.Label();
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSelectMode = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReload = new Guna.UI2.WinForms.Guna2Button();
            this.txtURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelCrawlDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBoxShowAll = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxShowAll = new Guna.UI2.WinForms.Guna2TextBox();
            this.lableShowAll = new System.Windows.Forms.Label();
            this.panelClickWhenApper = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxClickWhenApper = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClickWhenApper = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxActionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxSelectorResultType = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCrawlResultType = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboboxCrawlresultType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xx = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboboxCrawlType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.lableDescription = new System.Windows.Forms.Label();
            this.lableName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.guna2Panel14.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panelBoxShowAll.SuspendLayout();
            this.panelClickWhenApper.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.lbTitle.Location = new System.Drawing.Point(16, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 38);
            this.lbTitle.TabIndex = 7;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1620, 43);
            this.pnlTitle.TabIndex = 8;
            // 
            // lableMess
            // 
            this.lableMess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lableMess.AutoSize = true;
            this.lableMess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.lableMess.Location = new System.Drawing.Point(414, 39);
            this.lableMess.Name = "lableMess";
            this.lableMess.Size = new System.Drawing.Size(212, 25);
            this.lableMess.TabIndex = 8;
            this.lableMess.Text = "Manage Crawl Configs";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.guna2Panel1);
            this.pnlBody.Controls.Add(this.guna2Panel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 43);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1620, 877);
            this.pnlBody.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.splitContainer1);
            this.guna2Panel1.Controls.Add(this.guna2Panel12);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(428, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1192, 877);
            this.guna2Panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 98);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.guna2Panel13);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guna2Panel14);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 779);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 41;
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel13.Controls.Add(this.webView);
            this.guna2Panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel13.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(1192, 515);
            this.guna2Panel13.TabIndex = 0;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1192, 515);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView_WebMessageReceived);
            this.webView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView_SourceChanged);
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.Controls.Add(this.textBoxOutput);
            this.guna2Panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel14.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel14.Size = new System.Drawing.Size(1192, 258);
            this.guna2Panel14.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOutput.DefaultText = "";
            this.textBoxOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textBoxOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOutput.Location = new System.Drawing.Point(10, 10);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.PasswordChar = '\0';
            this.textBoxOutput.PlaceholderText = "";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.SelectedText = "";
            this.textBoxOutput.Size = new System.Drawing.Size(1172, 238);
            this.textBoxOutput.TabIndex = 44;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.Controls.Add(this.buttonSelectMode);
            this.guna2Panel12.Controls.Add(this.guna2Button8);
            this.guna2Panel12.Controls.Add(this.guna2Button3);
            this.guna2Panel12.Controls.Add(this.guna2Button7);
            this.guna2Panel12.Controls.Add(this.buttonReload);
            this.guna2Panel12.Controls.Add(this.txtURL);
            this.guna2Panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel12.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(1192, 98);
            this.guna2Panel12.TabIndex = 40;
            this.guna2Panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel12_Paint);
            // 
            // buttonSelectMode
            // 
            this.buttonSelectMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectMode.BorderRadius = 10;
            this.buttonSelectMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelectMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSelectMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSelectMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSelectMode.FillColor = System.Drawing.Color.Silver;
            this.buttonSelectMode.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectMode.ForeColor = System.Drawing.Color.White;
            this.buttonSelectMode.Location = new System.Drawing.Point(921, 8);
            this.buttonSelectMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectMode.Name = "buttonSelectMode";
            this.buttonSelectMode.Size = new System.Drawing.Size(116, 56);
            this.buttonSelectMode.TabIndex = 54;
            this.buttonSelectMode.Text = "SelectMode";
            // 
            // guna2Button8
            // 
            this.guna2Button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button8.BorderRadius = 10;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Silver;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(1045, 8);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(120, 56);
            this.guna2Button8.TabIndex = 53;
            this.guna2Button8.Text = "Get Data";
            this.guna2Button8.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::TechMo.Properties.Resources.arrow;
            this.guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button3.Location = new System.Drawing.Point(8, 18);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(40, 42);
            this.guna2Button3.TabIndex = 40;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 15;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::TechMo.Properties.Resources.right_arrow__1_;
            this.guna2Button7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button7.Location = new System.Drawing.Point(68, 18);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(40, 42);
            this.guna2Button7.TabIndex = 39;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.Transparent;
            this.buttonReload.BorderRadius = 15;
            this.buttonReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReload.FillColor = System.Drawing.Color.Transparent;
            this.buttonReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonReload.ForeColor = System.Drawing.Color.White;
            this.buttonReload.Image = global::TechMo.Properties.Resources.refresh_arrow;
            this.buttonReload.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonReload.Location = new System.Drawing.Point(128, 18);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(40, 42);
            this.buttonReload.TabIndex = 38;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.BorderRadius = 10;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.DefaultText = "";
            this.txtURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURL.Location = new System.Drawing.Point(201, 5);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.PlaceholderText = "URL";
            this.txtURL.SelectedText = "";
            this.txtURL.Size = new System.Drawing.Size(712, 63);
            this.txtURL.TabIndex = 37;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.panelCrawlDetail);
            this.guna2Panel2.Controls.Add(this.guna2Panel10);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.lableDescription);
            this.guna2Panel2.Controls.Add(this.lableName);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(428, 877);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // panelCrawlDetail
            // 
            this.panelCrawlDetail.AutoSize = true;
            this.panelCrawlDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelCrawlDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrawlDetail.Location = new System.Drawing.Point(0, 1150);
            this.panelCrawlDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCrawlDetail.Name = "panelCrawlDetail";
            this.panelCrawlDetail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 23);
            this.panelCrawlDetail.Size = new System.Drawing.Size(402, 23);
            this.panelCrawlDetail.TabIndex = 9;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel10.Controls.Add(this.label6);
            this.guna2Panel10.Controls.Add(this.guna2Button6);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel10.Location = new System.Drawing.Point(0, 1038);
            this.guna2Panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Padding = new System.Windows.Forms.Padding(0, 38, 0, 14);
            this.guna2Panel10.Size = new System.Drawing.Size(402, 112);
            this.guna2Panel10.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(0, 38);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(268, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button6.FillColor = System.Drawing.Color.Silver;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(268, 38);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(134, 60);
            this.guna2Button6.TabIndex = 52;
            this.guna2Button6.Text = "Add";
            this.guna2Button6.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoSize = true;
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.Controls.Add(this.panelBoxShowAll);
            this.guna2Panel4.Controls.Add(this.lableShowAll);
            this.guna2Panel4.Controls.Add(this.panelClickWhenApper);
            this.guna2Panel4.Controls.Add(this.labelClickWhenApper);
            this.guna2Panel4.Controls.Add(this.guna2Panel7);
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Controls.Add(this.labelCrawlResultType);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.xx);
            this.guna2Panel4.Controls.Add(this.guna2Panel8);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Controls.Add(this.guna2Panel9);
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 247);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(402, 791);
            this.guna2Panel4.TabIndex = 7;
            // 
            // panelBoxShowAll
            // 
            this.panelBoxShowAll.BackColor = System.Drawing.Color.Transparent;
            this.panelBoxShowAll.Controls.Add(this.guna2Button4);
            this.panelBoxShowAll.Controls.Add(this.textBoxShowAll);
            this.panelBoxShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBoxShowAll.Location = new System.Drawing.Point(0, 726);
            this.panelBoxShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBoxShowAll.Name = "panelBoxShowAll";
            this.panelBoxShowAll.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.panelBoxShowAll.Size = new System.Drawing.Size(402, 65);
            this.panelBoxShowAll.TabIndex = 76;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(285, 5);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(105, 42);
            this.guna2Button4.TabIndex = 53;
            this.guna2Button4.Text = "Remove";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // textBoxShowAll
            // 
            this.textBoxShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShowAll.BorderRadius = 10;
            this.textBoxShowAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxShowAll.DefaultText = "";
            this.textBoxShowAll.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxShowAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxShowAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShowAll.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShowAll.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShowAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxShowAll.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShowAll.Location = new System.Drawing.Point(24, 0);
            this.textBoxShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShowAll.Name = "textBoxShowAll";
            this.textBoxShowAll.PasswordChar = '\0';
            this.textBoxShowAll.PlaceholderText = "Selector - Show all";
            this.textBoxShowAll.SelectedText = "";
            this.textBoxShowAll.Size = new System.Drawing.Size(244, 60);
            this.textBoxShowAll.TabIndex = 51;
            this.textBoxShowAll.TextChanged += new System.EventHandler(this.textBoxShowAll_TextChanged);
            // 
            // lableShowAll
            // 
            this.lableShowAll.BackColor = System.Drawing.Color.Transparent;
            this.lableShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableShowAll.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableShowAll.Location = new System.Drawing.Point(0, 678);
            this.lableShowAll.Name = "lableShowAll";
            this.lableShowAll.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lableShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableShowAll.Size = new System.Drawing.Size(402, 48);
            this.lableShowAll.TabIndex = 75;
            this.lableShowAll.Text = "Show all";
            this.lableShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelClickWhenApper
            // 
            this.panelClickWhenApper.BackColor = System.Drawing.Color.Transparent;
            this.panelClickWhenApper.Controls.Add(this.guna2Button2);
            this.panelClickWhenApper.Controls.Add(this.textBoxClickWhenApper);
            this.panelClickWhenApper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClickWhenApper.Location = new System.Drawing.Point(0, 613);
            this.panelClickWhenApper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelClickWhenApper.Name = "panelClickWhenApper";
            this.panelClickWhenApper.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.panelClickWhenApper.Size = new System.Drawing.Size(402, 65);
            this.panelClickWhenApper.TabIndex = 74;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(285, 5);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(105, 42);
            this.guna2Button2.TabIndex = 52;
            this.guna2Button2.Text = "Remove";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // textBoxClickWhenApper
            // 
            this.textBoxClickWhenApper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClickWhenApper.BorderRadius = 10;
            this.textBoxClickWhenApper.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClickWhenApper.DefaultText = "";
            this.textBoxClickWhenApper.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClickWhenApper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClickWhenApper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClickWhenApper.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClickWhenApper.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClickWhenApper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxClickWhenApper.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClickWhenApper.Location = new System.Drawing.Point(24, 0);
            this.textBoxClickWhenApper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClickWhenApper.Name = "textBoxClickWhenApper";
            this.textBoxClickWhenApper.PasswordChar = '\0';
            this.textBoxClickWhenApper.PlaceholderText = "Selector - Click when apper";
            this.textBoxClickWhenApper.SelectedText = "";
            this.textBoxClickWhenApper.Size = new System.Drawing.Size(250, 60);
            this.textBoxClickWhenApper.TabIndex = 51;
            this.textBoxClickWhenApper.TextChanged += new System.EventHandler(this.textBoxClickWhenApper_TextChanged);
            // 
            // labelClickWhenApper
            // 
            this.labelClickWhenApper.BackColor = System.Drawing.Color.Transparent;
            this.labelClickWhenApper.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelClickWhenApper.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickWhenApper.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelClickWhenApper.Location = new System.Drawing.Point(0, 565);
            this.labelClickWhenApper.Name = "labelClickWhenApper";
            this.labelClickWhenApper.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelClickWhenApper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelClickWhenApper.Size = new System.Drawing.Size(402, 48);
            this.labelClickWhenApper.TabIndex = 73;
            this.labelClickWhenApper.Text = "Click when apper";
            this.labelClickWhenApper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.Controls.Add(this.guna2Button1);
            this.guna2Panel7.Controls.Add(this.comboBoxActionType);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 500);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel7.Size = new System.Drawing.Size(402, 65);
            this.guna2Panel7.TabIndex = 72;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(294, 5);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 42);
            this.guna2Button1.TabIndex = 51;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxActionType.BorderRadius = 10;
            this.comboBoxActionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxActionType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxActionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxActionType.ItemHeight = 30;
            this.comboBoxActionType.Location = new System.Drawing.Point(24, 0);
            this.comboBoxActionType.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(259, 36);
            this.comboBoxActionType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(0, 452);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(402, 48);
            this.label5.TabIndex = 71;
            this.label5.Text = "Add option";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.Controls.Add(this.textBoxSelectorResultType);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 387);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel6.Size = new System.Drawing.Size(402, 65);
            this.guna2Panel6.TabIndex = 70;
            // 
            // textBoxSelectorResultType
            // 
            this.textBoxSelectorResultType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectorResultType.BorderRadius = 10;
            this.textBoxSelectorResultType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSelectorResultType.DefaultText = "";
            this.textBoxSelectorResultType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSelectorResultType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSelectorResultType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSelectorResultType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSelectorResultType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSelectorResultType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSelectorResultType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSelectorResultType.Location = new System.Drawing.Point(24, 0);
            this.textBoxSelectorResultType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSelectorResultType.Name = "textBoxSelectorResultType";
            this.textBoxSelectorResultType.PasswordChar = '\0';
            this.textBoxSelectorResultType.PlaceholderText = "Selector - ResultType";
            this.textBoxSelectorResultType.SelectedText = "";
            this.textBoxSelectorResultType.Size = new System.Drawing.Size(366, 60);
            this.textBoxSelectorResultType.TabIndex = 51;
            this.textBoxSelectorResultType.TextChanged += new System.EventHandler(this.textBoxSelectorResultType_TextChanged);
            // 
            // labelCrawlResultType
            // 
            this.labelCrawlResultType.BackColor = System.Drawing.Color.Transparent;
            this.labelCrawlResultType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCrawlResultType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrawlResultType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelCrawlResultType.Location = new System.Drawing.Point(0, 339);
            this.labelCrawlResultType.Name = "labelCrawlResultType";
            this.labelCrawlResultType.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelCrawlResultType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCrawlResultType.Size = new System.Drawing.Size(402, 48);
            this.labelCrawlResultType.TabIndex = 69;
            this.labelCrawlResultType.Text = "Multi Selector";
            this.labelCrawlResultType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.comboboxCrawlresultType);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 274);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel5.Size = new System.Drawing.Size(402, 65);
            this.guna2Panel5.TabIndex = 68;
            // 
            // comboboxCrawlresultType
            // 
            this.comboboxCrawlresultType.BackColor = System.Drawing.Color.Transparent;
            this.comboboxCrawlresultType.BorderRadius = 10;
            this.comboboxCrawlresultType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxCrawlresultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCrawlresultType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCrawlresultType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCrawlresultType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCrawlresultType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxCrawlresultType.ItemHeight = 30;
            this.comboboxCrawlresultType.Location = new System.Drawing.Point(24, 0);
            this.comboboxCrawlresultType.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
            this.comboboxCrawlresultType.Name = "comboboxCrawlresultType";
            this.comboboxCrawlresultType.Size = new System.Drawing.Size(378, 36);
            this.comboboxCrawlresultType.TabIndex = 6;
            this.comboboxCrawlresultType.SelectedIndexChanged += new System.EventHandler(this.comboboxCrawlresultType_SelectedIndexChanged_1);
            // 
            // xx
            // 
            this.xx.BackColor = System.Drawing.Color.Transparent;
            this.xx.Dock = System.Windows.Forms.DockStyle.Top;
            this.xx.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.xx.Location = new System.Drawing.Point(0, 226);
            this.xx.Name = "xx";
            this.xx.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.xx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xx.Size = new System.Drawing.Size(402, 48);
            this.xx.TabIndex = 67;
            this.xx.Text = "Result type";
            this.xx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.Controls.Add(this.textBoxUrl);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(0, 161);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel8.Size = new System.Drawing.Size(402, 65);
            this.guna2Panel8.TabIndex = 66;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.BorderRadius = 10;
            this.textBoxUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUrl.DefaultText = "";
            this.textBoxUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUrl.Location = new System.Drawing.Point(24, 0);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.PasswordChar = '\0';
            this.textBoxUrl.PlaceholderText = "URL";
            this.textBoxUrl.SelectedText = "";
            this.textBoxUrl.Size = new System.Drawing.Size(366, 60);
            this.textBoxUrl.TabIndex = 51;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(0, 113);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(402, 48);
            this.label4.TabIndex = 65;
            this.label4.Text = "URL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.Controls.Add(this.comboboxCrawlType);
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel9.Size = new System.Drawing.Size(402, 65);
            this.guna2Panel9.TabIndex = 64;
            // 
            // comboboxCrawlType
            // 
            this.comboboxCrawlType.BackColor = System.Drawing.Color.Transparent;
            this.comboboxCrawlType.BorderRadius = 10;
            this.comboboxCrawlType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxCrawlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCrawlType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCrawlType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCrawlType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCrawlType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxCrawlType.ItemHeight = 30;
            this.comboboxCrawlType.Location = new System.Drawing.Point(24, 0);
            this.comboboxCrawlType.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
            this.comboboxCrawlType.Name = "comboboxCrawlType";
            this.comboboxCrawlType.Size = new System.Drawing.Size(378, 36);
            this.comboboxCrawlType.TabIndex = 6;
            this.comboboxCrawlType.SelectedIndexChanged += new System.EventHandler(this.comboboxCrawlType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(402, 48);
            this.label3.TabIndex = 63;
            this.label3.Text = "Crawl type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.guna2Button5);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 153);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(0, 38, 0, 0);
            this.guna2Panel3.Size = new System.Drawing.Size(402, 94);
            this.guna2Panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(268, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "Option";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button5.FillColor = System.Drawing.Color.Silver;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(268, 38);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(134, 56);
            this.guna2Button5.TabIndex = 52;
            this.guna2Button5.Text = "Show/Hide";
            this.guna2Button5.Click += new System.EventHandler(this.buttonShowHideOption_Click);
            // 
            // lableDescription
            // 
            this.lableDescription.BackColor = System.Drawing.Color.Transparent;
            this.lableDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableDescription.Location = new System.Drawing.Point(0, 105);
            this.lableDescription.Name = "lableDescription";
            this.lableDescription.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lableDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableDescription.Size = new System.Drawing.Size(402, 48);
            this.lableDescription.TabIndex = 4;
            this.lableDescription.Text = "Config Info";
            this.lableDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableName
            // 
            this.lableName.BackColor = System.Drawing.Color.Transparent;
            this.lableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableName.Location = new System.Drawing.Point(0, 57);
            this.lableName.Name = "lableName";
            this.lableName.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lableName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableName.Size = new System.Drawing.Size(402, 48);
            this.lableName.TabIndex = 3;
            this.lableName.Text = "Config Info";
            this.lableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(402, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Config Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmConfigDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfigDetail";
            this.Text = "frmMail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfigDetail_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfigDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmConfigs_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.guna2Panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.guna2Panel14.ResumeLayout(false);
            this.guna2Panel12.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.panelBoxShowAll.ResumeLayout(false);
            this.panelClickWhenApper.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Label lableMess;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label1;
        private Label lableDescription;
        private Label lableName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel panelBoxShowAll;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox textBoxShowAll;
        private Label lableShowAll;
        private Guna.UI2.WinForms.Guna2Panel panelClickWhenApper;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClickWhenApper;
        private Label labelClickWhenApper;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxActionType;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSelectorResultType;
        private Label labelCrawlResultType;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxCrawlresultType;
        private Label xx;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUrl;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxCrawlType;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Panel panelCrawlDetail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button buttonReload;
        private Guna.UI2.WinForms.Guna2TextBox txtURL;
        private SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2TextBox textBoxOutput;
        private Guna.UI2.WinForms.Guna2Button buttonSelectMode;
    }
}