using System;
using System.Windows.Forms;

namespace TempControl
{
    public partial class MainFrm : Form
    {
        private const string READ_APIKEY = "AHVAOB5BO0DYLP90";
        private const string CHANNEL_NUM = "376531";
        private const int READ_FIELD = 1;

        public MainFrm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            SelectedTabImg.Left = 0;
        }

        //=========================================Buttons========================================//

        private void XBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SetTab(sender, SettingUseControl);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            SetTab(sender, DashboardUseControl);
        }

        //=========================================Switch=========================================//

        private void Switch_ValueChanged(object sender, EventArgs e)
        {
            if (Switch.Value)
            {
                SwitchLbl.Text = "On";
                return;
            }

            SwitchLbl.Text = "Off";
        }

        //=======================================Functions========================================//

        private void SetTab(object sender, UserControl selectedTab)
        {
            SelectedTabImg.Top = ((Control)sender).Top;
            SelectedTabImg.Height = ((Control)sender).Height;

            selectedTab.BringToFront();
        }
    }
}

    