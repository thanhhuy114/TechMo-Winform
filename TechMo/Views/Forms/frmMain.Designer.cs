using Librarys;
using System.Windows.Forms;

namespace TechMo.GUI.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlAvata = new System.Windows.Forms.Panel();
            this.ptbAvata = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.btnHidemenu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.btnWallet = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAvata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvata)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitlebar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAvata
            // 
            this.pnlAvata.Controls.Add(this.ptbAvata);
            this.pnlAvata.Controls.Add(this.lbDisplayName);
            this.pnlAvata.Controls.Add(this.btnHidemenu);
            this.pnlAvata.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvata.Location = new System.Drawing.Point(0, 0);
            this.pnlAvata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAvata.Name = "pnlAvata";
            this.pnlAvata.Size = new System.Drawing.Size(220, 243);
            this.pnlAvata.TabIndex = 0;
            // 
            // ptbAvata
            // 
            this.ptbAvata.BackColor = System.Drawing.Color.Transparent;
            this.ptbAvata.Image = global::TechMo.Properties.Resources.noavata;
            this.ptbAvata.ImageRotate = 0F;
            this.ptbAvata.Location = new System.Drawing.Point(58, 43);
            this.ptbAvata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbAvata.Name = "ptbAvata";
            this.ptbAvata.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAvata.Size = new System.Drawing.Size(80, 82);
            this.ptbAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvata.TabIndex = 0;
            this.ptbAvata.TabStop = false;
            this.ptbAvata.UseTransparentBackground = true;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.ForeColor = System.Drawing.Color.White;
            this.lbDisplayName.Location = new System.Drawing.Point(30, 162);
            this.lbDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(147, 42);
            this.lbDisplayName.TabIndex = 0;
            this.lbDisplayName.Text = "Thành Huy";
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDisplayName.Click += new System.EventHandler(this.lbDisplayName_Click);
            // 
            // btnHidemenu
            // 
            this.btnHidemenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHidemenu.BorderRadius = 15;
            this.btnHidemenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHidemenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHidemenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHidemenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHidemenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnHidemenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHidemenu.ForeColor = System.Drawing.Color.White;
            this.btnHidemenu.Image = global::TechMo.Properties.Resources.closeMenu;
            this.btnHidemenu.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHidemenu.Location = new System.Drawing.Point(189, 8);
            this.btnHidemenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHidemenu.Name = "btnHidemenu";
            this.btnHidemenu.Size = new System.Drawing.Size(27, 28);
            this.btnHidemenu.TabIndex = 0;
            this.btnHidemenu.Click += new System.EventHandler(this.btnClosemenu_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnStatistical);
            this.pnlMenu.Controls.Add(this.btnWallet);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlAvata);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 881);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lbVersion);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogo.Location = new System.Drawing.Point(0, 758);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 88);
            this.pnlLogo.TabIndex = 9;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.lbVersion.Location = new System.Drawing.Point(10, 66);
            this.lbVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(43, 11);
            this.lbVersion.TabIndex = 10;
            this.lbVersion.Text = "Version 1.0";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::TechMo.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.ImageSize = new System.Drawing.Size(23, 23);
            this.btnLogout.Location = new System.Drawing.Point(0, 846);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Tag = "Đăng xuất";
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 15;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::TechMo.Properties.Resources.setting;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSetting.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetting.Location = new System.Drawing.Point(0, 456);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(220, 71);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Tag = "Cài đặt";
            this.btnSetting.Text = "x";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.BorderRadius = 15;
            this.btnStatistical.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.Image = global::TechMo.Properties.Resources.statistical;
            this.btnStatistical.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStatistical.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStatistical.Location = new System.Drawing.Point(0, 385);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnStatistical.Size = new System.Drawing.Size(220, 71);
            this.btnStatistical.TabIndex = 3;
            this.btnStatistical.Tag = "Phân tích";
            this.btnStatistical.Text = "x";
            this.btnStatistical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BorderRadius = 15;
            this.btnWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWallet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnWallet.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.Image = global::TechMo.Properties.Resources.wallet;
            this.btnWallet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWallet.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnWallet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnWallet.Location = new System.Drawing.Point(0, 314);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnWallet.Size = new System.Drawing.Size(220, 71);
            this.btnWallet.TabIndex = 2;
            this.btnWallet.Tag = "Ví tiền";
            this.btnWallet.Text = "Test Config id57";
            this.btnWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 15;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::TechMo.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(0, 243);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 71);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Trang chủ";
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlTitlebar.Controls.Add(this.pnlSearch);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitlebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(1450, 43);
            this.pnlTitlebar.TabIndex = 1;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.pnlSearch.BorderRadius = 10;
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(33, 9);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pnlSearch.Size = new System.Drawing.Size(226, 25);
            this.pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(10, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "\r\nTìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 43);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1450, 838);
            this.pnlDesktop.TabIndex = 2;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlForm.Controls.Add(this.pnlDesktop);
            this.pnlForm.Controls.Add(this.pnlTitlebar);
            this.pnlForm.Controls.Add(this.pnlMenu);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1670, 881);
            this.pnlForm.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1670, 881);
            this.Controls.Add(this.pnlForm);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlAvata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvata)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitlebar.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAvata;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnWallet;
        private Guna.UI2.WinForms.Guna2Button btnStatistical;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private System.Windows.Forms.Label lbDisplayName;
        private Guna.UI2.WinForms.Guna2Button btnHidemenu;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Panel pnlTitlebar;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbAvata;
    }
}