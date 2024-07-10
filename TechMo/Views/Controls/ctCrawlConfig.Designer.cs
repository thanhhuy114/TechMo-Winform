using System.Windows.Forms;

namespace TechMo.GUI.UserControls
{
    partial class ctCrawlConfig
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgType = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 25;
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.imgType);
            this.pnlMain.Controls.Add(this.lbName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(243, 99);
            this.pnlMain.TabIndex = 2;
           
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "10/10/2024 10:10:10";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Discription";
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 10;
            this.imgType.Image = global::TechMo.Properties.Resources.html;
            this.imgType.ImageRotate = 0F;
            this.imgType.Location = new System.Drawing.Point(10, 9);
            this.imgType.Margin = new System.Windows.Forms.Padding(2);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(41, 36);
            this.imgType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgType.TabIndex = 6;
            this.imgType.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbName.Location = new System.Drawing.Point(55, 16);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(131, 18);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ctCrawlConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10, 4, 7, 4);
            this.Name = "ctCrawlConfig";
            this.Size = new System.Drawing.Size(243, 99);
            this.Click += new System.EventHandler(this.ctCrawlConfig_Click);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgType)).EndInit();
            this.ResumeLayout(false);
       
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2PictureBox imgType;
        private Label label2;
        private Label label1;
    }
}
