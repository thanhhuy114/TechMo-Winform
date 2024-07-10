using System.Windows.Forms;

namespace TechMo.GUI.UserControls
{
    partial class ctCrawlConfigDetail
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
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonDel = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnaelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonAddOption = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxActionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxDataType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xx = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSelector = new Guna.UI2.WinForms.Guna2TextBox();
            this.lableShowAll = new System.Windows.Forms.Label();
            this.lableAttribute = new System.Windows.Forms.Label();
            this.panelAttribute = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxAttribute = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel11.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.pnaelContent.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel11.Controls.Add(this.guna2Panel12);
            this.guna2Panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel11.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(410, 75);
            this.guna2Panel11.TabIndex = 11;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel12.BorderRadius = 10;
            this.guna2Panel12.Controls.Add(this.buttonDel);
            this.guna2Panel12.Controls.Add(this.textBoxName);
            this.guna2Panel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Panel12.Location = new System.Drawing.Point(4, 5);
            this.guna2Panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(400, 58);
            this.guna2Panel12.TabIndex = 0;
            this.guna2Panel12.Click += new System.EventHandler(this.this_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BorderRadius = 10;
            this.buttonDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDel.FillColor = System.Drawing.Color.Red;
            this.buttonDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(326, 9);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(69, 42);
            this.buttonDel.TabIndex = 53;
            this.buttonDel.Text = "Del";
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(16, 9);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(184, 40);
            this.textBoxName.TabIndex = 52;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // guna2Panel1
            // 
            this.pnaelContent.AutoSize = true;
            this.pnaelContent.BackColor = System.Drawing.Color.White;
            this.pnaelContent.Controls.Add(this.panelAttribute);
            this.pnaelContent.Controls.Add(this.lableAttribute);
            this.pnaelContent.Controls.Add(this.guna2Panel7);
            this.pnaelContent.Controls.Add(this.label5);
            this.pnaelContent.Controls.Add(this.guna2Panel5);
            this.pnaelContent.Controls.Add(this.xx);
            this.pnaelContent.Controls.Add(this.guna2Panel2);
            this.pnaelContent.Controls.Add(this.lableShowAll);
            this.pnaelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnaelContent.Location = new System.Drawing.Point(0, 75);
            this.pnaelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnaelContent.Name = "guna2Panel1";
            this.pnaelContent.Size = new System.Drawing.Size(410, 451);
            this.pnaelContent.TabIndex = 12;
            this.pnaelContent.Visible = false;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.Controls.Add(this.buttonAddOption);
            this.guna2Panel7.Controls.Add(this.comboBoxActionType);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 263);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel7.Size = new System.Drawing.Size(410, 65);
            this.guna2Panel7.TabIndex = 81;
            // 
            // buttonAddOption
            // 
            this.buttonAddOption.BorderRadius = 10;
            this.buttonAddOption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddOption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddOption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddOption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddOption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOption.ForeColor = System.Drawing.Color.White;
            this.buttonAddOption.Location = new System.Drawing.Point(294, 5);
            this.buttonAddOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddOption.Name = "buttonAddOption";
            this.buttonAddOption.Size = new System.Drawing.Size(105, 42);
            this.buttonAddOption.TabIndex = 51;
            this.buttonAddOption.Text = "Add";
            this.buttonAddOption.Click += new System.EventHandler(this.buttonAddOption_Click);
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
            this.label5.Location = new System.Drawing.Point(0, 215);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(410, 48);
            this.label5.TabIndex = 80;
            this.label5.Text = "Add option";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.comboBoxDataType);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 150);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.guna2Panel5.Size = new System.Drawing.Size(410, 65);
            this.guna2Panel5.TabIndex = 79;
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDataType.BorderRadius = 10;
            this.comboBoxDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDataType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDataType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxDataType.ItemHeight = 30;
            this.comboBoxDataType.Location = new System.Drawing.Point(24, 0);
            this.comboBoxDataType.Margin = new System.Windows.Forms.Padding(45, 5, 4, 5);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(235, 36);
            this.comboBoxDataType.TabIndex = 6;
            this.comboBoxDataType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataType_SelectedIndexChanged);
            // 
            // xx
            // 
            this.xx.BackColor = System.Drawing.Color.Transparent;
            this.xx.Dock = System.Windows.Forms.DockStyle.Top;
            this.xx.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.xx.Location = new System.Drawing.Point(0, 102);
            this.xx.Name = "xx";
            this.xx.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.xx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xx.Size = new System.Drawing.Size(410, 48);
            this.xx.TabIndex = 78;
            this.xx.Text = "Data type";
            this.xx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Button3);
            this.guna2Panel2.Controls.Add(this.textBoxSelector);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(410, 54);
            this.guna2Panel2.TabIndex = 77;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(270, 8);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(129, 42);
            this.guna2Button3.TabIndex = 54;
            this.guna2Button3.Text = "Auto Find";
            this.guna2Button3.Click += new System.EventHandler(this.buttonAutoFind_Click);
            // 
            // textBoxSelector
            // 
            this.textBoxSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelector.BorderRadius = 10;
            this.textBoxSelector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSelector.DefaultText = "";
            this.textBoxSelector.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSelector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSelector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSelector.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSelector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSelector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSelector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSelector.Location = new System.Drawing.Point(24, 9);
            this.textBoxSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSelector.Name = "textBoxSelector";
            this.textBoxSelector.PasswordChar = '\0';
            this.textBoxSelector.PlaceholderText = "Selector";
            this.textBoxSelector.SelectedText = "";
            this.textBoxSelector.Size = new System.Drawing.Size(237, 40);
            this.textBoxSelector.TabIndex = 53;
            this.textBoxSelector.TextChanged += new System.EventHandler(this.textBoxSelector_TextChanged);
            // 
            // lableShowAll
            // 
            this.lableShowAll.BackColor = System.Drawing.Color.Transparent;
            this.lableShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableShowAll.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableShowAll.Location = new System.Drawing.Point(0, 0);
            this.lableShowAll.Name = "lableShowAll";
            this.lableShowAll.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lableShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableShowAll.Size = new System.Drawing.Size(410, 48);
            this.lableShowAll.TabIndex = 76;
            this.lableShowAll.Text = "Selector";
            this.lableShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lableAttribute
            // 
            this.lableAttribute.BackColor = System.Drawing.Color.Transparent;
            this.lableAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableAttribute.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableAttribute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableAttribute.Location = new System.Drawing.Point(0, 328);
            this.lableAttribute.Name = "lableAttribute";
            this.lableAttribute.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lableAttribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableAttribute.Size = new System.Drawing.Size(410, 48);
            this.lableAttribute.TabIndex = 82;
            this.lableAttribute.Text = "Attribute";
            this.lableAttribute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAttribute
            // 
            this.panelAttribute.Controls.Add(this.textBoxAttribute);
            this.panelAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAttribute.Location = new System.Drawing.Point(0, 376);
            this.panelAttribute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAttribute.Name = "panelAttribute";
            this.panelAttribute.Size = new System.Drawing.Size(410, 54);
            this.panelAttribute.TabIndex = 84;
            // 
            // textBoxAttribute
            // 
            this.textBoxAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAttribute.BorderRadius = 10;
            this.textBoxAttribute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAttribute.DefaultText = "";
            this.textBoxAttribute.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAttribute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAttribute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAttribute.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAttribute.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAttribute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxAttribute.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAttribute.Location = new System.Drawing.Point(24, 9);
            this.textBoxAttribute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAttribute.Name = "textBoxAttribute";
            this.textBoxAttribute.PasswordChar = '\0';
            this.textBoxAttribute.PlaceholderText = "Attribute";
            this.textBoxAttribute.SelectedText = "";
            this.textBoxAttribute.Size = new System.Drawing.Size(361, 40);
            this.textBoxAttribute.TabIndex = 53;
            this.textBoxAttribute.TextChanged += new System.EventHandler(this.textBoxAttribute_TextChanged);
            // 
            // ctCrawlConfigDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnaelContent);
            this.Controls.Add(this.guna2Panel11);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(15, 6, 10, 6);
            this.Name = "ctCrawlConfigDetail";
            this.Size = new System.Drawing.Size(410, 526);
            this.Load += new System.EventHandler(this.ctCrawlConfigDetail_Load);
            this.Click += new System.EventHandler(this.ctCrawlConfig_Click);
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel12.ResumeLayout(false);
            this.pnaelContent.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panelAttribute.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2Panel pnaelContent;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSelector;
        private Label lableShowAll;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxDataType;
        private Label xx;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Button buttonAddOption;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxActionType;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button buttonDel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Label lableAttribute;
        private Guna.UI2.WinForms.Guna2Panel panelAttribute;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAttribute;
    }
}
