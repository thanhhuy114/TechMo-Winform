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

namespace TechMo.GUI.Forms
{
    public partial class frmConfigs : Form
    {
        private ConfigsViewModels configsViewModels;

        private event Action<int> OnConfigClickEvent;
        public frmConfigs(Action<int> onConfigClickEvent)
        {
            InitializeComponent();
            configsViewModels = new ConfigsViewModels();
            OnConfigClickEvent= onConfigClickEvent;
        }



        private async void frmConfigs_Load(object sender, EventArgs e)
        {
            await LoadCrawlConfig();
        }

        private async Task LoadCrawlConfig()
        {
            // Hanlde UI
            var loadingForm = new frmLoading();
            loadingForm.TopLevel = false;
            loadingForm.FormBorderStyle = FormBorderStyle.None;
            loadingForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(loadingForm);
            pnlBody.Tag = loadingForm;
            loadingForm.BringToFront();
            loadingForm.Show();

            // Handle get Data
            var crawlConfigs = await Task.Run(() => configsViewModels.GetCrawlConfigsFromApiAsync());


            // Hanlde UI
            pnlBody.Controls.Clear();
            loadingForm.Hide();
            loadingForm.Close();

            if (crawlConfigs == null)
            {
                lableMess.Text = "Lỗi Server, hoặc không tìm thấy dữ liệu";
                pnlBody.Controls.Add(lableMess);
            }
            else
            {
                lableMess.Text = "Thành công";
                dataView.DataSource = crawlConfigs.Select((e) => e.CrawlConfig).ToList();
                pnlBody.Controls.Add(dataView);
            }
        }

        private void dataView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataView.Columns[e.ColumnIndex].DataPropertyName == "CrawlTypesID")
            {
                if (e.Value == null) return;
                e.Value = CrawlTypes.GetCrawlType((int)e.Value).Type;
                e.FormattingApplied = true;
            }
            else if (dataView.Columns[e.ColumnIndex].DataPropertyName == "UpdateAT")
            {
                DateTime dateTime;
                bool success = DateTime.TryParse((string)e.Value, out dateTime);

                if (success)
                {
                    e.Value = DateTime.Parse((string)e.Value).ToString();
                    e.FormattingApplied = true;
                }
               
            }
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            OnConfigClickEvent?.Invoke((int)dataView.Rows[e.RowIndex].Cells["id"].Value);
        }
    }
}






