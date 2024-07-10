using Guna.UI2.WinForms;
using System;
using Librarys;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace TechMo.GUI.Forms
{
    public partial class frmMain : Form
    {
        const object NON_ACCTIVE_FORM = null;


        private bool autoHideMenu = false;
        private Form activeForm;
        private Guna2Button currentButton;


        public frmMain()
        {
            InitializeComponent();
            pnlMenu.Width = Constants.MENU_WIDTH;
            btnHome_Click(null, EventArgs.Empty);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            //activeForm.Close();

            //Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClosemenu_Click(object sender, EventArgs e)
        {
            pnlDesktop.Visible = false;
            if (pnlMenu.Width >= Constants.MENU_WIDTH)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
            pnlDesktop.Visible = true;
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConfigDetail(57), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConfigs((id) =>
            {
                OpenChildForm(new frmConfigDetail(id), sender, true);
            }), sender);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            /* OpenChildForm(new frmStatistical(), sender);
             AutoHideMenu();*/
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            /* OpenChildForm(new frmSetting(), sender);
             AutoHideMenu();*/
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (activeForm.GetType() == typeof(frmWallet))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    frmWallet wallet = (frmWallet)activeForm;
                    wallet.loadPayAccount(txtSearch.Text.Trim());
                }
            }
            else
            {
                lbLogo1.Focus();
            }*/

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I) { btnSetting.PerformClick(); }
            if (e.Control && e.KeyCode == Keys.W) { btnWallet.PerformClick(); }
            if (e.Control && e.KeyCode == Keys.H) { btnHome.PerformClick(); }
            if (e.Control && e.KeyCode == Keys.S) { btnStatistical.PerformClick(); }
        }




        // mở form con
        private void OpenChildForm(Form childForm, object btnSender, bool newFrm = false)
        {
            if (activeForm != NON_ACCTIVE_FORM)
            {
                if (activeForm.GetType() == childForm.GetType())
                    return;
           
                activeForm.Close();
            }
            if(!newFrm)
                ActivateButton(btnSender);

            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Clear();
            pnlDesktop.Controls.Add(activeForm);
            pnlDesktop.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        // hiệu ứng khi chọn các nút trong menu
        private void ActivateButton(object btnSender)
        {
            if (currentButton != (Guna2Button)btnSender)
            {
                DisableButton();
                currentButton = (Guna2Button)btnSender;
                currentButton.FillColor = Color.FromArgb(95, 105, 187);
                currentButton.ForeColor = Color.FromArgb(204, 204, 204);
                currentButton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                currentButton.ImageSize = new Size(35, 35);
            }
        }

        // hiệu ứng khi hủy chọn các nút trong menu
        private void DisableButton()
        {
            if (currentButton != null)
            {
                foreach (Guna2Button btn in pnlMenu.Controls.OfType<Guna2Button>())
                {
                    btn.FillColor = Color.FromArgb(131, 142, 253);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    btn.ImageSize = new Size(30, 30);
                }
            }
        }

        public Guna2TextBox gettxtSearch
        {
            get { return txtSearch; }
            set { txtSearch = value; }
        }


        void HideMenu()
        {
            pnlLogo.Visible = false;
            btnHidemenu.Image = Properties.Resources.openMenu;
            lbDisplayName.Visible = false;

            ptbAvata.Location = new Point(12, 50);
            ptbAvata.Size = new Size(55, 55);

            foreach (Guna2Button menuButton in pnlMenu.Controls.OfType<Guna2Button>())
            {
                menuButton.Text = string.Empty;
                menuButton.ImageAlign = HorizontalAlignment.Center;
                menuButton.ImageOffset = new Point(0, 0);
            }
            //
            pnlMenu.Width = 76;
        }
        void ShowMenu()
        {
            ptbAvata.Location = new Point(74, 29);
            ptbAvata.Size = new Size(64, 64);
            pnlLogo.Visible = true;
            lbDisplayName.Visible = true;
            btnHidemenu.Image = Properties.Resources.closeMenu;
            //
            pnlMenu.Width = Constants.MENU_WIDTH;
            //
            foreach (Guna2Button menuButton in pnlMenu.Controls.OfType<Guna2Button>())
            {
                menuButton.Text = menuButton.Tag.ToString();
                menuButton.ImageAlign = HorizontalAlignment.Left;
                menuButton.ImageOffset = new Point(10, 0);
            }
        }

        public static frmMain form;



        public Guna2CirclePictureBox Avata
        {
            get { return ptbAvata; }
            set { ptbAvata = value; }
        }

        private void lbDisplayName_Click(object sender, EventArgs e)
        {

        }
    }
}
