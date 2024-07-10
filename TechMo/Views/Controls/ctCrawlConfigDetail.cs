using System;
using Librarys;

using System.Drawing;
using Newtonsoft.Json.Linq;
using TechMo.GUI.Forms;
using System.Windows.Forms;
using TechMo.Models;
using TechMo.ViewModels;
using System.ComponentModel;
using Guna.UI2.WinForms;

namespace TechMo.GUI.UserControls
{
    public partial class ctCrawlConfigDetail : UserControl
    {

        CrawlDetails CrawlDetails;
        public ctCrawlConfigDetail(CrawlDetails crawlDetails, Action<CrawlDetails> delectDetail, Func<string> getSelector)
        {
            CrawlDetails = crawlDetails;
            InitializeComponent();
            DelectDetail = delectDetail;
            GetSelector = getSelector;
        }

        private  Action<CrawlDetails> DelectDetail;
        private Func<string> GetSelector;


        private void ctCrawlConfig_Click(object sender, EventArgs e)
        {

        }

        private void ctCrawlConfigDetail_Load(object sender, EventArgs e)
        {
            textBoxName.Text = CrawlDetails.Name;
            textBoxSelector.Text = CrawlDetails.Selector;

            // DataType
            var crawlDatatTypeBindingSource = new BindingSource();
            crawlDatatTypeBindingSource.DataSource = CrawlDataTypes.crawlCrawlDataTypesMockup;
            comboBoxDataType.DisplayMember = "Type";
            comboBoxDataType.ValueMember = "Id";
            comboBoxDataType.DataSource = crawlDatatTypeBindingSource;


            // DataType
            var crawlDetaiOtherOptionBindingSource = new BindingSource();
            crawlDetaiOtherOptionBindingSource.DataSource = CrawlDetaiOtherOption.crawlDetaiOtherOptions;
            comboBoxActionType.DisplayMember = "Name";
            comboBoxActionType.ValueMember = "Key";
            comboBoxActionType.DataSource = crawlDetaiOtherOptionBindingSource;

            comboBoxDataType.SelectedValue = CrawlDataTypes.GetCrawlDataType(CrawlDetails.DataTypeID).Id;
        }

        private void this_Click(object sender, EventArgs e)
        {
            pnaelContent.AutoSize = true;
            pnaelContent.Visible = !pnaelContent.Visible;
            //this.AutoSize = !guna2Panel1.Visible;          
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            CrawlDetails.Name = textBoxName.Text;
        }

        private void textBoxSelector_TextChanged(object sender, EventArgs e)
        {
            CrawlDetails.Selector = textBoxSelector.Text;
        }

        private void buttonAutoFind_Click(object sender, EventArgs e)
        {
            GetSelector();
        }

        private void buttonAddOption_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataTypeID = (int)comboBoxDataType.SelectedValue;
            CrawlDetails.DataTypeID = dataTypeID;

            bool isTextField = CrawlDataTypes.GetCrawlDataType(dataTypeID).IsTextField;
            panelAttribute.Visible = isTextField;
            lableAttribute.Visible = isTextField;
            textBoxAttribute.Visible = isTextField;

            if(!isTextField)
            {
                CrawlDetails.Attribute = null;
                textBoxAttribute.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DelectDetail(CrawlDetails);
        }

        private void textBoxAttribute_TextChanged(object sender, EventArgs e)
        {
            CrawlDetails.Attribute = textBoxAttribute.Text == "" ? null : textBoxAttribute.Text;
        }
    }
}
