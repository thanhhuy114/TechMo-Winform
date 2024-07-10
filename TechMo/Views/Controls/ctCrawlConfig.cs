using System;
using Librarys;

using System.Drawing;
using Newtonsoft.Json.Linq;
using TechMo.GUI.Forms;
using System.Windows.Forms;

namespace TechMo.GUI.UserControls
{
    public partial class ctCrawlConfig : UserControl
    {
        public ctCrawlConfig()
        {
            InitializeComponent();
            RegisterClickEvent(this);
        }

     
        private void ctCrawlConfig_Click(object sender, EventArgs e)
        {
            frmTestWeb from = new frmTestWeb();
            from.Show();
        }


        private void RegisterClickEvent(Control control)
        {
            control.Click += new EventHandler(ctCrawlConfig_Click);
            foreach (Control childControl in control.Controls)
            {
                RegisterClickEvent(childControl);
            }
        }
    }
}
