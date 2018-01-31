using System;
using System.Windows.Forms;
using Domain;

namespace TempControl
{
    public partial class EditUserFrm : Form
    {
        private User _user;

        public EditUserFrm(User user)
        {
            CenterToParent();
            InitializeComponent();
            _user = user;
            UsernameText.Text = _user.Name;
        }

        //=========================================Buttons========================================//

        private void XBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            _user.SetName(UsernameText.Text);
            Close();
        }

        //=====================================DropDownlist=======================================//

        public User GetUsername()
        {
            return _user;
        }
    }
}
