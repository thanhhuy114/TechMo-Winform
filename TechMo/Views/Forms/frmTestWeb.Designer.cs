using System;

namespace TechMo.GUI.Forms
{
    partial class frmTestWeb
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonLoadJS = new Guna.UI2.WinForms.Guna2Button();
            this.checkBoxSelectMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.buttonUnNoClick = new Guna.UI2.WinForms.Guna2Button();
            this.buttonNoClick = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxFilterBytagName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonFindElement = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxTextElement = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReload = new Guna.UI2.WinForms.Guna2Button();
            this.txtURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.buttonLogin);
            this.guna2Panel1.Controls.Add(this.buttonLoadJS);
            this.guna2Panel1.Controls.Add(this.checkBoxSelectMode);
            this.guna2Panel1.Controls.Add(this.buttonUnNoClick);
            this.guna2Panel1.Controls.Add(this.buttonNoClick);
            this.guna2Panel1.Controls.Add(this.textBoxFilterBytagName);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.textBoxResult);
            this.guna2Panel1.Controls.Add(this.guna2ButtonFindElement);
            this.guna2Panel1.Controls.Add(this.textBoxTextElement);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(591, 952);
            this.guna2Panel1.TabIndex = 0;
            // 
            // buttonLoadJS
            // 
            this.buttonLoadJS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoadJS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoadJS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLoadJS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLoadJS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadJS.ForeColor = System.Drawing.Color.White;
            this.buttonLoadJS.Location = new System.Drawing.Point(290, 165);
            this.buttonLoadJS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadJS.Name = "buttonLoadJS";
            this.buttonLoadJS.Size = new System.Drawing.Size(153, 42);
            this.buttonLoadJS.TabIndex = 50;
            this.buttonLoadJS.Text = "Open Gadget";
            this.buttonLoadJS.Click += new System.EventHandler(this.buttonLoadJS_Click);
            // 
            // checkBoxSelectMode
            // 
            this.checkBoxSelectMode.AutoSize = true;
            this.checkBoxSelectMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSelectMode.CheckedState.BorderRadius = 0;
            this.checkBoxSelectMode.CheckedState.BorderThickness = 0;
            this.checkBoxSelectMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSelectMode.Location = new System.Drawing.Point(390, 114);
            this.checkBoxSelectMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSelectMode.Name = "checkBoxSelectMode";
            this.checkBoxSelectMode.Size = new System.Drawing.Size(124, 24);
            this.checkBoxSelectMode.TabIndex = 49;
            this.checkBoxSelectMode.Text = "Select Mode";
            this.checkBoxSelectMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSelectMode.UncheckedState.BorderRadius = 0;
            this.checkBoxSelectMode.UncheckedState.BorderThickness = 0;
            this.checkBoxSelectMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSelectMode.CheckedChanged += new System.EventHandler(this.checkBoxSelectMode_CheckedChanged);
            // 
            // buttonUnNoClick
            // 
            this.buttonUnNoClick.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUnNoClick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUnNoClick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUnNoClick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUnNoClick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUnNoClick.ForeColor = System.Drawing.Color.White;
            this.buttonUnNoClick.Location = new System.Drawing.Point(144, 165);
            this.buttonUnNoClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUnNoClick.Name = "buttonUnNoClick";
            this.buttonUnNoClick.Size = new System.Drawing.Size(136, 42);
            this.buttonUnNoClick.TabIndex = 47;
            this.buttonUnNoClick.Text = "Un No Click";
            this.buttonUnNoClick.Click += new System.EventHandler(this.buttonUnNoClick_Click);
            // 
            // buttonNoClick
            // 
            this.buttonNoClick.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNoClick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNoClick.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNoClick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNoClick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNoClick.ForeColor = System.Drawing.Color.White;
            this.buttonNoClick.Location = new System.Drawing.Point(18, 165);
            this.buttonNoClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNoClick.Name = "buttonNoClick";
            this.buttonNoClick.Size = new System.Drawing.Size(108, 42);
            this.buttonNoClick.TabIndex = 46;
            this.buttonNoClick.Text = "No Click";
            this.buttonNoClick.Click += new System.EventHandler(this.buttonNoClick_Click);
            // 
            // textBoxFilterBytagName
            // 
            this.textBoxFilterBytagName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterBytagName.BorderRadius = 10;
            this.textBoxFilterBytagName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFilterBytagName.DefaultText = "";
            this.textBoxFilterBytagName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFilterBytagName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFilterBytagName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFilterBytagName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFilterBytagName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFilterBytagName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFilterBytagName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFilterBytagName.Location = new System.Drawing.Point(278, 23);
            this.textBoxFilterBytagName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxFilterBytagName.Name = "textBoxFilterBytagName";
            this.textBoxFilterBytagName.PasswordChar = '\0';
            this.textBoxFilterBytagName.PlaceholderText = "Filter by tag name";
            this.textBoxFilterBytagName.SelectedText = "";
            this.textBoxFilterBytagName.Size = new System.Drawing.Size(183, 63);
            this.textBoxFilterBytagName.TabIndex = 45;
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(18, 114);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(117, 42);
            this.guna2Button3.TabIndex = 44;
            this.guna2Button3.Text = "Get Html";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResult.DefaultText = "";
            this.textBoxResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxResult.Location = new System.Drawing.Point(18, 228);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.PasswordChar = '\0';
            this.textBoxResult.PlaceholderText = "";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.SelectedText = "";
            this.textBoxResult.Size = new System.Drawing.Size(548, 706);
            this.textBoxResult.TabIndex = 43;
            // 
            // guna2ButtonFindElement
            // 
            this.guna2ButtonFindElement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonFindElement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonFindElement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonFindElement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonFindElement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonFindElement.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonFindElement.Location = new System.Drawing.Point(278, 114);
            this.guna2ButtonFindElement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonFindElement.Name = "guna2ButtonFindElement";
            this.guna2ButtonFindElement.Size = new System.Drawing.Size(94, 42);
            this.guna2ButtonFindElement.TabIndex = 42;
            this.guna2ButtonFindElement.Text = "Search";
            this.guna2ButtonFindElement.Click += new System.EventHandler(this.buttonFindElement_Click);
            // 
            // textBoxTextElement
            // 
            this.textBoxTextElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextElement.BorderRadius = 10;
            this.textBoxTextElement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTextElement.DefaultText = "";
            this.textBoxTextElement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTextElement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTextElement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTextElement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTextElement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTextElement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTextElement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTextElement.Location = new System.Drawing.Point(18, 23);
            this.textBoxTextElement.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxTextElement.Name = "textBoxTextElement";
            this.textBoxTextElement.PasswordChar = '\0';
            this.textBoxTextElement.PlaceholderText = "Search Text Element";
            this.textBoxTextElement.SelectedText = "";
            this.textBoxTextElement.Size = new System.Drawing.Size(225, 63);
            this.textBoxTextElement.TabIndex = 41;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel2.Location = new System.Drawing.Point(591, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1038, 98);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Button2);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.buttonReload);
            this.guna2Panel3.Controls.Add(this.txtURL);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1038, 98);
            this.guna2Panel3.TabIndex = 39;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = Properties.Resources.arrow;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(8, 18);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(40, 42);
            this.guna2Button2.TabIndex = 40;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::TechMo.Properties.Resources.right_arrow__1_;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(68, 18);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 42);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.txtURL.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.PlaceholderText = "URL";
            this.txtURL.SelectedText = "";
            this.txtURL.Size = new System.Drawing.Size(820, 63);
            this.txtURL.TabIndex = 37;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(591, 98);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guna2Panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 854);
            this.splitContainer1.SplitterDistance = 620;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
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
            this.webView.Size = new System.Drawing.Size(1038, 620);
            this.webView.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView_WebMessageReceived);
            this.webView.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.webView_SourceChanged);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.Controls.Add(this.labelState);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1038, 228);
            this.guna2Panel4.TabIndex = 0;
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelState.Location = new System.Drawing.Point(0, 17);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(1038, 142);
            this.labelState.TabIndex = 67;
            this.labelState.Text = "Html";
            // 
            // buttonLogin
            // 
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(159, 114);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 42);
            this.buttonLogin.TabIndex = 51;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // frmTestWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1629, 952);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTestWeb";
            this.Text = "frmTestWeb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2TextBox txtURL;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button buttonReload;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTextElement;
        private System.Windows.Forms.Label labelState;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonFindElement;
        private Guna.UI2.WinForms.Guna2TextBox textBoxResult;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFilterBytagName;
        private Guna.UI2.WinForms.Guna2Button buttonNoClick;
        private Guna.UI2.WinForms.Guna2Button buttonUnNoClick;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSelectMode;
        private Guna.UI2.WinForms.Guna2Button buttonLoadJS;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
    }
}