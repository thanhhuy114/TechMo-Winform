using TechMo.GUI.UserControls;
using TechMo.Models;
using System.Collections.Generic;
using System.Web.UI;
using System.Windows.Forms;

namespace TechMo.GUI.Forms
{
    partial class frmConfigs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lableMess = new System.Windows.Forms.Label();
            this.pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            this.dataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlResultTypesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlTypesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httpMethodTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyApiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headersApiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlResultTypesIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlTypesIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypesIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.httpMethodTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyApiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headersApiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateATDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlConfigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.lbTitle.Location = new System.Drawing.Point(17, 14);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(212, 25);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Manage Crawl Configs";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(533, 51);
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
            this.pnlBody.Controls.Add(this.dataView);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 51);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(533, 334);
            this.pnlBody.TabIndex = 9;
            // 
            // dataView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.ColumnHeadersHeight = 22;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.urlDataGridViewTextBoxColumn1,
            this.selectorDataGridViewTextBoxColumn1,
            this.crawlResultTypesIDDataGridViewTextBoxColumn1,
            this.crawlTypesIDDataGridViewTextBoxColumn1,
            this.itemTypesIDDataGridViewTextBoxColumn1,
            this.websiteIDDataGridViewTextBoxColumn1,
            this.httpMethodTypeIDDataGridViewTextBoxColumn1,
            this.bodyApiDataGridViewTextBoxColumn1,
            this.headersApiDataGridViewTextBoxColumn1,
            this.updateATDataGridViewTextBoxColumn1});
            this.dataView.DataSource = this.crawlConfigBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersVisible = false;
            this.dataView.RowTemplate.Height = 28;
            this.dataView.Size = new System.Drawing.Size(533, 334);
            this.dataView.TabIndex = 0;
            this.dataView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.ThemeStyle.HeaderStyle.Height = 22;
            this.dataView.ThemeStyle.ReadOnly = false;
            this.dataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataView.ThemeStyle.RowsStyle.Height = 28;
            this.dataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
           
            this.dataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellDoubleClick);
            this.dataView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataView_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Visible = false;
            // 
            // selectorDataGridViewTextBoxColumn
            // 
            this.selectorDataGridViewTextBoxColumn.DataPropertyName = "Selector";
            this.selectorDataGridViewTextBoxColumn.HeaderText = "Selector";
            this.selectorDataGridViewTextBoxColumn.Name = "selectorDataGridViewTextBoxColumn";
            this.selectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.selectorDataGridViewTextBoxColumn.Visible = false;
            // 
            // crawlResultTypesIDDataGridViewTextBoxColumn
            // 
            this.crawlResultTypesIDDataGridViewTextBoxColumn.DataPropertyName = "CrawlResultTypesID";
            this.crawlResultTypesIDDataGridViewTextBoxColumn.HeaderText = "CrawlResultTypesID";
            this.crawlResultTypesIDDataGridViewTextBoxColumn.Name = "crawlResultTypesIDDataGridViewTextBoxColumn";
            this.crawlResultTypesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.crawlResultTypesIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // crawlTypesIDDataGridViewTextBoxColumn
            // 
            this.crawlTypesIDDataGridViewTextBoxColumn.DataPropertyName = "CrawlTypesID";
            this.crawlTypesIDDataGridViewTextBoxColumn.HeaderText = "CrawlTypesID";
            this.crawlTypesIDDataGridViewTextBoxColumn.Name = "crawlTypesIDDataGridViewTextBoxColumn";
            this.crawlTypesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemTypesIDDataGridViewTextBoxColumn
            // 
            this.itemTypesIDDataGridViewTextBoxColumn.DataPropertyName = "ItemTypesID";
            this.itemTypesIDDataGridViewTextBoxColumn.HeaderText = "ItemTypesID";
            this.itemTypesIDDataGridViewTextBoxColumn.Name = "itemTypesIDDataGridViewTextBoxColumn";
            this.itemTypesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypesIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // websiteIDDataGridViewTextBoxColumn
            // 
            this.websiteIDDataGridViewTextBoxColumn.DataPropertyName = "WebsiteID";
            this.websiteIDDataGridViewTextBoxColumn.HeaderText = "WebsiteID";
            this.websiteIDDataGridViewTextBoxColumn.Name = "websiteIDDataGridViewTextBoxColumn";
            this.websiteIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.websiteIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // httpMethodTypeIDDataGridViewTextBoxColumn
            // 
            this.httpMethodTypeIDDataGridViewTextBoxColumn.DataPropertyName = "HttpMethodTypeID";
            this.httpMethodTypeIDDataGridViewTextBoxColumn.HeaderText = "HttpMethodTypeID";
            this.httpMethodTypeIDDataGridViewTextBoxColumn.Name = "httpMethodTypeIDDataGridViewTextBoxColumn";
            this.httpMethodTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.httpMethodTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bodyApiDataGridViewTextBoxColumn
            // 
            this.bodyApiDataGridViewTextBoxColumn.DataPropertyName = "BodyApi";
            this.bodyApiDataGridViewTextBoxColumn.HeaderText = "BodyApi";
            this.bodyApiDataGridViewTextBoxColumn.Name = "bodyApiDataGridViewTextBoxColumn";
            this.bodyApiDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyApiDataGridViewTextBoxColumn.Visible = false;
            // 
            // headersApiDataGridViewTextBoxColumn
            // 
            this.headersApiDataGridViewTextBoxColumn.DataPropertyName = "HeadersApi";
            this.headersApiDataGridViewTextBoxColumn.HeaderText = "HeadersApi";
            this.headersApiDataGridViewTextBoxColumn.Name = "headersApiDataGridViewTextBoxColumn";
            this.headersApiDataGridViewTextBoxColumn.ReadOnly = true;
            this.headersApiDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateATDataGridViewTextBoxColumn
            // 
            this.updateATDataGridViewTextBoxColumn.DataPropertyName = "UpdateAT";
            this.updateATDataGridViewTextBoxColumn.HeaderText = "UpdateAT";
            this.updateATDataGridViewTextBoxColumn.Name = "updateATDataGridViewTextBoxColumn";
            this.updateATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn1.Visible = false;
            // 
            // selectorDataGridViewTextBoxColumn1
            // 
            this.selectorDataGridViewTextBoxColumn1.DataPropertyName = "Selector";
            this.selectorDataGridViewTextBoxColumn1.HeaderText = "Selector";
            this.selectorDataGridViewTextBoxColumn1.Name = "selectorDataGridViewTextBoxColumn1";
            this.selectorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.selectorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // crawlResultTypesIDDataGridViewTextBoxColumn1
            // 
            this.crawlResultTypesIDDataGridViewTextBoxColumn1.DataPropertyName = "CrawlResultTypesID";
            this.crawlResultTypesIDDataGridViewTextBoxColumn1.HeaderText = "CrawlResultTypesID";
            this.crawlResultTypesIDDataGridViewTextBoxColumn1.Name = "crawlResultTypesIDDataGridViewTextBoxColumn1";
            this.crawlResultTypesIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.crawlResultTypesIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // crawlTypesIDDataGridViewTextBoxColumn1
            // 
            this.crawlTypesIDDataGridViewTextBoxColumn1.DataPropertyName = "CrawlTypesID";
            this.crawlTypesIDDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.crawlTypesIDDataGridViewTextBoxColumn1.Name = "crawlTypesIDDataGridViewTextBoxColumn1";
            this.crawlTypesIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemTypesIDDataGridViewTextBoxColumn1
            // 
            this.itemTypesIDDataGridViewTextBoxColumn1.DataPropertyName = "ItemTypesID";
            this.itemTypesIDDataGridViewTextBoxColumn1.HeaderText = "ItemTypesID";
            this.itemTypesIDDataGridViewTextBoxColumn1.Name = "itemTypesIDDataGridViewTextBoxColumn1";
            this.itemTypesIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemTypesIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // websiteIDDataGridViewTextBoxColumn1
            // 
            this.websiteIDDataGridViewTextBoxColumn1.DataPropertyName = "WebsiteID";
            this.websiteIDDataGridViewTextBoxColumn1.HeaderText = "WebsiteID";
            this.websiteIDDataGridViewTextBoxColumn1.Name = "websiteIDDataGridViewTextBoxColumn1";
            this.websiteIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.websiteIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // httpMethodTypeIDDataGridViewTextBoxColumn1
            // 
            this.httpMethodTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "HttpMethodTypeID";
            this.httpMethodTypeIDDataGridViewTextBoxColumn1.HeaderText = "HttpMethodTypeID";
            this.httpMethodTypeIDDataGridViewTextBoxColumn1.Name = "httpMethodTypeIDDataGridViewTextBoxColumn1";
            this.httpMethodTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.httpMethodTypeIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bodyApiDataGridViewTextBoxColumn1
            // 
            this.bodyApiDataGridViewTextBoxColumn1.DataPropertyName = "BodyApi";
            this.bodyApiDataGridViewTextBoxColumn1.HeaderText = "BodyApi";
            this.bodyApiDataGridViewTextBoxColumn1.Name = "bodyApiDataGridViewTextBoxColumn1";
            this.bodyApiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bodyApiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // headersApiDataGridViewTextBoxColumn1
            // 
            this.headersApiDataGridViewTextBoxColumn1.DataPropertyName = "HeadersApi";
            this.headersApiDataGridViewTextBoxColumn1.HeaderText = "HeadersApi";
            this.headersApiDataGridViewTextBoxColumn1.Name = "headersApiDataGridViewTextBoxColumn1";
            this.headersApiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.headersApiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // updateATDataGridViewTextBoxColumn1
            // 
            this.updateATDataGridViewTextBoxColumn1.DataPropertyName = "UpdateAT";
            this.updateATDataGridViewTextBoxColumn1.HeaderText = "UpdateAT";
            this.updateATDataGridViewTextBoxColumn1.Name = "updateATDataGridViewTextBoxColumn1";
            this.updateATDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // crawlConfigBindingSource
            // 
            this.crawlConfigBindingSource.DataSource = typeof(TechMo.Models.CrawlConfig);
            // 
            // frmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(533, 385);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConfigs";
            this.Text = "frmMail";
            this.Load += new System.EventHandler(this.frmConfigs_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlConfigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Label lableMess;
    
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn selectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn crawlResultTypesIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn crawlTypesIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemTypesIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn websiteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn httpMethodTypeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodyApiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headersApiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateATDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView dataView;
        private BindingSource crawlConfigBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn selectorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn crawlResultTypesIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn crawlTypesIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn itemTypesIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn websiteIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn httpMethodTypeIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bodyApiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn headersApiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn updateATDataGridViewTextBoxColumn1;
    }
}