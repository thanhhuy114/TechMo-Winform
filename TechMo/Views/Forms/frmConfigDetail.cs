using TechMo;
using Newtonsoft.Json.Linq;
using System;
using Librarys;
using System.IO;
using System.Windows.Forms;
using TechMo.GUI.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMo.ViewModels;
using System.Data;
using TechMo.Models;
using System.Text.RegularExpressions;
using Microsoft.Web.WebView2.Core;
using TechMo.Models.RequestModel;
using System.Drawing;

namespace TechMo.GUI.Forms
{
    public partial class frmConfigDetail : Form
    {
        private ConfigsDetailViewModels configsDetailViewModels = null;
        private int configID;

        public frmConfigDetail(int configID)
        {
            InitializeComponent();
            configsDetailViewModels = new ConfigsDetailViewModels();
            this.configID = configID;
        }



        private async void frmConfigs_Load(object sender, EventArgs e)
        {
            // CrawlType
            var crawlTypeBindingSource = new BindingSource();
            crawlTypeBindingSource.DataSource = CrawlTypes.crawlTypesMockup;
            comboboxCrawlType.DisplayMember = "Type";
            comboboxCrawlType.ValueMember = "Id";
            comboboxCrawlType.DataSource = crawlTypeBindingSource;

            // DataType
            var crawlReultTypeBindingSource = new BindingSource();
            crawlReultTypeBindingSource.DataSource = CrawlResultTypes.crawlResultTypesMockup;
            comboboxCrawlresultType.DisplayMember = "Type";
            comboboxCrawlresultType.ValueMember = "Id";
            comboboxCrawlresultType.DataSource = crawlReultTypeBindingSource;

            // ActionType
            var crawlActionTypeBindingSource = new BindingSource();
            crawlActionTypeBindingSource.DataSource = CrawlActionTypes.crawlCrawlActionTypesMockup;
            comboBoxActionType.DisplayMember = "Type";
            comboBoxActionType.ValueMember = "Id";
            comboBoxActionType.DataSource = crawlActionTypeBindingSource;

            // OptionActionDetails
            lableShowAll.Visible = false;
            labelClickWhenApper.Visible = false;
            panelClickWhenApper.Visible = false;
            panelBoxShowAll.Visible = false;

            await LoadCrawlConfigDetail();
        }

        private async Task LoadCrawlConfigDetail()
        {
            //Hanlde UI
            //var loadingForm = new frmLoading();
            //loadingForm.TopLevel = false;
            //loadingForm.FormBorderStyle = FormBorderStyle.None;
            //loadingForm.Dock = DockStyle.Fill;
            //pnlBody.Controls.Clear();
            //pnlBody.Controls.Add(loadingForm);
            //pnlBody.Tag = loadingForm;
            //loadingForm.BringToFront();
            //loadingForm.Show();

            //// Handle get Data
            await Task.Run(() => configsDetailViewModels.GetCrawlConfigDetailFromApiAsync(configID));

            if (configsDetailViewModels.GetCrawlConfig == null)
            {
                return;
            }

            lableName.Text = $"Name: {configsDetailViewModels.GetCrawlConfig.Name}";
            lableDescription.Text = $"Description: {configsDetailViewModels.GetCrawlConfig.Description}";
            comboboxCrawlType.SelectedValue = CrawlTypes.GetCrawlType(configsDetailViewModels.GetCrawlConfig.CrawlTypesID ?? 1).Id;

            comboboxCrawlresultType.SelectedValue = CrawlResultTypes.GetResultType(configsDetailViewModels.GetCrawlConfig.CrawlResultTypesID ?? 1).Id;

            textBoxUrl.Text = configsDetailViewModels.GetCrawlConfig.Url;

            textBoxSelectorResultType.Text = configsDetailViewModels.GetCrawlConfig.Selector;

            // Add option
            configsDetailViewModels.GetCrawlActionDetails.ForEach(e =>
            {
                if (CrawlActionTypes.GetCrawlActionType(e.ActionTypeID).Key == "click_when_appear")
                {
                    labelClickWhenApper.Visible = true;
                    panelClickWhenApper.Visible = true;
                    textBoxClickWhenApper.Text = e.Selector;
                }
                else if (CrawlActionTypes.GetCrawlActionType(e.ActionTypeID).Key == "show_all")
                {
                    lableShowAll.Visible = true;
                    panelBoxShowAll.Visible = true;
                    textBoxShowAll.Text = e.Selector;
                }
            });

            // Load detail
            for (int i = 0; i < configsDetailViewModels.GetCrawlDetails.Count; i++)
            {
                var index = panelCrawlDetail.Controls.Count;
                var crawlDetail = configsDetailViewModels.GetCrawlDetails[i];
                var ct = new ctCrawlConfigDetail(configsDetailViewModels.GetCrawlDetails[i], (_) =>
                {
                    panelCrawlDetail.Controls.RemoveAt(index);
                    SetOutput("Remove Detail");
                    configsDetailViewModels.GetCrawlDetails.Remove(crawlDetail);
                }, () =>
                {
                    webView.CoreWebView2.ExecuteScriptAsync("SelectorGadget.toggle();");
                    buttonSelectMode.FillColor = Color.Lime;
                    return "";
                });
                ct.Dock = DockStyle.Top;
                panelCrawlDetail.Controls.Add(ct);
            }


            // Load web
            try
            {
                if (Uri.IsWellFormedUriString(configsDetailViewModels.GetCrawlConfig.Url, UriKind.Absolute))
                    this.webView.Source = GetValidUri(configsDetailViewModels.GetCrawlConfig.Url);
                else this.webView.Source = new Uri($"https://www.google.com");
            }
            catch
            {
                //this.webView.Source = new Uri($"https://www.google.com");
            }

            // Apply JS
            //ApplyJavaScript();


            //// Hanlde UI
            //pnlBody.Controls.Clear();
            //loadingForm.Hide();
            //loadingForm.Close();

            //if (crawlConfigs == null)
            //{
            //    lableMess.Text = "Lỗi Server, hoặc không tìm thấy dữ liệu";
            //    pnlBody.Controls.Add(lableMess);
            //}
            //else
            //{
            //    lableMess.Text = "Thành công";
            //    dataView.DataSource = crawlConfigs.Select((e) => e.CrawlConfig).ToList();
            //    pnlBody.Controls.Add(dataView);
            //}
        }

        private void dataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dataView.Columns[e.ColumnIndex].DataPropertyName == "CrawlTypesID")
            //{
            //    if (e.Value == null) return;
            //    e.Value = CrawlTypes.GetCrawlType((int)e.Value).Type;
            //    e.FormattingApplied = true;
            //}
            //else if (dataView.Columns[e.ColumnIndex].DataPropertyName == "UpdateAT")
            //{
            //    DateTime dateTime;
            //    bool success = DateTime.TryParse((string)e.Value, out dateTime);

            //    if (success)
            //    {
            //        e.Value = DateTime.Parse((string)e.Value).ToString();
            //        e.FormattingApplied = true;
            //    }

            //}
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            //OnConfigClickEvent?.Invoke((int)dataView.Rows[e.RowIndex].Cells["id"].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            SetOutput("Web: Loaded");
            if (webView.Source.ToString() != textBoxUrl.Text)
            {
                MessageBox.Show("url khác nhau");
            }

            ApplyJavaScript();
        }


        private void buttonShowHideOption_Click(object sender, EventArgs e)
        {
            guna2Panel4.Visible = !guna2Panel4.Visible;
        }

        private void comboboxCrawlresultType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboboxCrawlresultType.DataSource != null)
            {
                bool isSelectorMulti = (CrawlResultTypes.GetResultType((int)comboboxCrawlresultType.SelectedValue).Key == "multi");
                labelCrawlResultType.Visible = isSelectorMulti;
                guna2Panel6.Visible = isSelectorMulti;

                if (configsDetailViewModels.GetCrawlConfig == null) return;

                configsDetailViewModels.GetCrawlConfig.CrawlResultTypesID = (int)comboboxCrawlresultType.SelectedValue;
            }
        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private Uri GetValidUri(string url)
        {
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            return new Uri(url);
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound


                try
                {
                    if (Uri.IsWellFormedUriString(this.txtURL.Text, UriKind.Absolute))
                        this.webView.Source = GetValidUri(this.txtURL.Text);
                    else this.webView.Source = new Uri($"https://www.google.com/search?q={this.txtURL.Text}");
                }
                catch
                {
                    this.webView.Source = new Uri($"https://www.google.com");
                }

            }
        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            this.txtURL.Text = this.webView.Source.ToString();
        }

 

        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            SetOutput("Web: Loading");
            this.txtURL.Text = this.webView.Source.ToString();
        }

        private void SetOutput(string mess)
        {
            this.textBoxOutput.Text = mess;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.webView.Reload();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.webView.GoBack();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.webView.GoForward();
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            configsDetailViewModels.GetCrawlDetails.Add(new CrawlDetails(configsDetailViewModels.GetCrawlDetails.Count, "", configsDetailViewModels.GetCrawlConfig.Id ?? 1, "", "", 1));

            var index = panelCrawlDetail.Controls.Count;
            var crawlDetail = configsDetailViewModels.GetCrawlDetails.Last();
            var ct = new ctCrawlConfigDetail(crawlDetail,
                (_) =>
            {
                panelCrawlDetail.Controls.RemoveAt(index);

                configsDetailViewModels.GetCrawlDetails.Remove(crawlDetail);
            },
            () =>
            {
                webView.CoreWebView2.ExecuteScriptAsync("SelectorGadget.toggle();");
                return "";
            });

            SetOutput("Add Detail");
            ct.Dock = DockStyle.Top;
            panelCrawlDetail.Controls.Add(ct);
        }

        private async void buttonGetData_Click(object sender, EventArgs e)
        {
            await configsDetailViewModels.FetchDataByConfigFromApiAsync();
        }

        private void comboboxCrawlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configsDetailViewModels.GetCrawlConfig == null) return;

            configsDetailViewModels.GetCrawlConfig.CrawlTypesID = (int)comboboxCrawlType.SelectedValue;
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            if (configsDetailViewModels.GetCrawlConfig == null) return;

            configsDetailViewModels.GetCrawlConfig.Url = textBoxUrl.Text;
        }

        private void webView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                SetOutput(e.TryGetWebMessageAsString() + Environment.NewLine + Environment.NewLine);
                webView.CoreWebView2.ExecuteScriptAsync("SelectorGadget.toggle();");
                buttonSelectMode.FillColor = Color.Silver;
            }
            catch { }
        }

        private void ApplyJavaScript()
        {
            string jsContent1 = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/build/selectorgadget_combined.js");
            string cssContent = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/build/selectorgadget_combined.css");

            jsContent1 = jsContent1.Replace("\\", "\\\\")
                                    .Replace("`", "\\`")
                                    .Replace("\"", "\\\"");

           

            string mainScript = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/selectorgadget.js");
            mainScript = mainScript.Replace("{style}", cssContent);
            mainScript = mainScript.Replace("{script1}", jsContent1);

            webView.CoreWebView2.ExecuteScriptAsync(mainScript);
        }


        private string ReadFile(string path)
        {
            try
            {
                // Kiểm tra xem file có tồn tại không
                if (!File.Exists(path)) return "";

                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd(); // Đọc toàn bộ nội dung của file
                    return content;
                }
            }
            catch (Exception)
            {
                return "";
            }
        }


        private void textBoxSelectorResultType_TextChanged(object sender, EventArgs e)
        {
            if (configsDetailViewModels.GetCrawlConfig == null) return;

            configsDetailViewModels.GetCrawlConfig.Selector = textBoxSelectorResultType.Text == "" ? null : textBoxSelectorResultType.Text;
        }

        private void textBoxClickWhenApper_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxShowAll_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            configsDetailViewModels.GetCrawlActionDetails = configsDetailViewModels.GetCrawlActionDetails.Where(element => { return element.ActionTypeID != CrawlActionTypes.crawlCrawlActionTypesMockup.First(e2 => { return e2.Key == "click_when_appear"; }).Id; }).ToList();

            labelClickWhenApper.Visible = false;
            panelClickWhenApper.Visible = false;
            textBoxClickWhenApper.Text = "";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            configsDetailViewModels.GetCrawlActionDetails = configsDetailViewModels.GetCrawlActionDetails.Where(element => { return element.ActionTypeID != CrawlActionTypes.crawlCrawlActionTypesMockup.First(e2 => { return e2.Key == "show_all"; }).Id; }).ToList();

            lableShowAll.Visible = false;
            panelBoxShowAll.Visible = false;
            textBoxShowAll.Text = "";
        }

        private void frmConfigDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmConfigDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            //webView.Dispose();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            int actionID = (int)comboBoxActionType.SelectedValue;

            //if (configsDetailViewModels.GetCrawlActionDetails.Any(element => element.ActionTypeID == actionID))
            //    return;

            configsDetailViewModels.GetCrawlActionDetails.Add(new CrawlActionDetails(configsDetailViewModels.GetCrawlActionDetails.Count, configsDetailViewModels.GetCrawlConfig.Id ?? 1, actionID, ""));

            configsDetailViewModels.GetCrawlActionDetails.ForEach(element =>
            {
                if (CrawlActionTypes.GetCrawlActionType(element.ActionTypeID).Key == "click_when_appear")
                {
                    labelClickWhenApper.Visible = true;
                    panelClickWhenApper.Visible = true;
                    textBoxClickWhenApper.Text = element.Selector;
                }
                else if (CrawlActionTypes.GetCrawlActionType(element.ActionTypeID).Key == "show_all")
                {
                    lableShowAll.Visible = true;
                    panelBoxShowAll.Visible = true;
                    textBoxShowAll.Text = element.Selector;
                }
            });

        }
    }
}






