using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;
using AzureConnection;
using Domain;
using System.Collections.ObjectModel;

namespace TempControl
{
    public partial class Settings : UserControl
    {
        private Broker _broker;
        private User _user;
        private Collection<User> _usersDDL;
        private Collection<User> _usersLC;

        public Settings()
        {
            string dataSource = Properties.Settings.Default.SqlServer;
            string userID = Properties.Settings.Default.UserId;
            string password = Properties.Settings.Default.Password;
            string initialCatalog = Properties.Settings.Default.Table;

            _user = new User();

            _broker = new Broker();
            _broker.ConnectionCredential(dataSource, userID, password, initialCatalog);

            InitializeComponent();

            LedOnOff();

            UpdateListControl();
            UpdateDropDownList();
            UpdateEditBox();
        }

        //=========================================Buttons========================================//

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (_user.Name == null) return;

            _broker.DeleteUser(_user);

            UpdateListControl();
            UpdateDropDownList();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (_user.Name == null) return;

            EditUserFrm editUser = new EditUserFrm(_user);
            editUser.ShowDialog();

            if (editUser.GetUsername() == null) return;

            _user = (editUser.GetUsername());
            _broker.UpdateUser(_user);

            UpdateListControl();
            UpdateDropDownList();
            UserDrpDwn.SelectedItem.Text = _user.Name;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (AddUserTxt.Text == "") return;

            _user = new User();
            _user.SetName(AddUserTxt.Text);
            _user.SetOptimTemp(Int32.Parse(OptimTempTxt.Text));

            AddUserTxt.Text = "";

            _broker.AddUser(_user);

            UpdateListControl();
            UpdateDropDownList();
            UserDrpDwn.SelectedItem.Text = _user.Name;
        }

        private void AddUserTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                AddUserBtn.PerformClick();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (ChangeListControl.SelectedIndex == 0 || ChangeListControl.SelectedIndex == -1) return;

            int userIndex = ChangeListControl.SelectedIndex;
            User firstUser = new User();
            firstUser.SetName(ChangeListControl.Items[userIndex - 1].Text);
            User secondUser = new User();
            secondUser.SetName(ChangeListControl.SelectedItem.Text);

            ChangeOrder(firstUser, secondUser);
            ChangeListControl.SelectedIndex = userIndex - 1;
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (ChangeListControl.SelectedIndex == _usersDDL.Count - 1 || ChangeListControl.SelectedIndex == -1) return;

            int userIndex = ChangeListControl.SelectedIndex;
            User firstUser = new User();
            firstUser.SetName(ChangeListControl.SelectedItem.Text);
            User secondUser = new User();
            secondUser.SetName(ChangeListControl.Items[userIndex + 1].Text);

            ChangeOrder(firstUser, secondUser);
            ChangeListControl.SelectedIndex = userIndex + 1;
        }
        private void DataBaseSaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SqlServer = ServerAddressTxt.Text;
            Properties.Settings.Default.UserId = UserIDTxt.Text;
            Properties.Settings.Default.Password = PasswordTxt.Text;
            Properties.Settings.Default.Table = DataBaseTxt.Text;
            Properties.Settings.Default.Save();
            _broker.ConnectionCredential(ServerAddressTxt.Text, UserIDTxt.Text, PasswordTxt.Text, DataBaseTxt.Text);

            LedOnOff();
            UpdateListControl();
            UpdateDropDownList();
        }

        //=====================================DropDownlist=======================================//

        private void UserDrpDwn_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            if (UserDrpDwn.SelectedItem == null) return;

            _user.SetName(UserDrpDwn.SelectedItem.Text);
            _user = _broker.GetUser(_user);
            OptimTempBr.Value = _user.OptimTemp;
            OptimTempBr.Text = _user.OptimTemp.ToString();
        }

        //=======================================TrackBar=========================================//

        private void OptimTempBr_ValueChanged(object sender, EventArgs e)
        {
            OptimTempTxt.Text = OptimTempBr.Value.ToString();
            UpdateTemp();
        }

        //========================================TextBox=========================================//

        private void OptimTempTxt_Click(object sender, EventArgs e)
        {
            OptimTempTxt.SelectionStart = 0;
            OptimTempTxt.SelectionLength = OptimTempTxt.Text.Length;
        }

        private void OptimTempTxt_Leave(object sender, EventArgs e)
        {
            OptimTempBr.Value = Int32.Parse(OptimTempTxt.Text);
            UpdateTemp();
        }

        private void OptimTempTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;

            OptimTempBr.Value = Int32.Parse(OptimTempTxt.Text);
            UpdateTemp();;
        }

        private void ServerAddressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                DataBaseSaveBtn.PerformClick();
        }

        private void UserIDTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                DataBaseSaveBtn.PerformClick();
        }

        private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                DataBaseSaveBtn.PerformClick();
        }

        private void DataBaseTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                DataBaseSaveBtn.PerformClick();
        }

        //=======================================Functions========================================//

        private void UpdateTemp()
        {
            if (UserDrpDwn.SelectedItem == null) return;

            _user.SetOptimTemp(Convert.ToInt32(OptimTempBr.Value));
            _broker.UpdateUser(_user);
            
        }
        private void UpdateDropDownList()
        {
            _usersDDL = _broker.GetUsersList();
            FillDropDownList(UserDrpDwn, _usersDDL);
            UserDrpDwn.SelectedIndex = 0;
        }

        private void FillDropDownList(RadDropDownList dpl, Collection<User> users)
        {
            dpl.Items.Clear();
            foreach (User user in users)
            {
                dpl.Items.Add(user.Name);
            }
            dpl.DisplayMember = "User";
            dpl.ValueMember = "Username";
        }

        private void UpdateListControl()
        {
            _usersLC = _broker.GetUsersList();
            FillListControl(ChangeListControl, _usersLC);
        }

        private void Collection<T>()
        {
            throw new NotImplementedException();
        }

        private void FillListControl(RadListControl lc, Collection<User> users)
        {
            lc.Items.Clear();
            foreach (User user in users)
            {
                lc.Items.Add(user.Name);
            }
            lc.DisplayMember = "User";
            lc.ValueMember = "Username";
        }

        private void UpdateEditBox()
        {
            ServerAddressTxt.Text = Properties.Settings.Default.SqlServer;
            UserIDTxt.Text = Properties.Settings.Default.UserId;
            PasswordTxt.Text = Properties.Settings.Default.Password;
            DataBaseTxt.Text = Properties.Settings.Default.Table;
        }

        private void ChangeOrder(User firstUser, User secondUser)
        {
            _broker.GetUser(firstUser);
            _broker.GetUser(secondUser);

            int tempPriority = firstUser.Priority;
            firstUser.SetPriority(secondUser.Priority);
            secondUser.SetPriority(tempPriority);

            _broker.UpdateUser(firstUser);
            _broker.UpdateUser(secondUser);

            UpdateListControl();
            UpdateDropDownList();
        }

        private void LedOnOff()
        {
            if (!_broker.ConnectDB())
            {
                LedImg.Image = Properties.Resources.LedOff;
                return;
            }

            LedImg.Image = Properties.Resources.LedOn;
        }
    }
}
