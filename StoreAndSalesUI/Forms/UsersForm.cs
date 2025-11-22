using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            GetAllUsers();
            GetAllRoles();
            LoadUserRoles();
            RefrechGridDataSource(_users);
        }

        #region Private Members

        private UserData _userData = new UserData();
        private UserModel _user = new UserModel();
        private List<UserModel> _users = new List<UserModel>();
        private List<UserRoleModel> _roles = new List<UserRoleModel>();
        private bool _isUserSelected = false;

        #endregion

        #region Private Methods

        private void ClearForm()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            repeatPasswordTextBox.Clear();
            _user = new UserModel();
            _isUserSelected = false;
            EnableDisableDeleteButton();
            GetAllUsers();
            RefrechGridDataSource(_users);
            rolesComboBox.SelectedIndex = -1;
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (userNameTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            else if (passwordTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            else if (repeatPasswordTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            else if (rolesComboBox.SelectedIndex == -1)
            {
                output = false;
            }
            else if (!IsSamePassword(passwordTextBox.Text, repeatPasswordTextBox.Text))
            {
                output = false;
            }

            return output;

        }

        private void CollectFormData()
        {
            int roleId =
                rolesComboBox.SelectedValue == null ? 0 : int.Parse(rolesComboBox.SelectedValue.ToString());

            if (_isUserSelected)
            {
                _user.UserName = userNameTextBox.Text;
                _user.Password = passwordTextBox.Text;
                _user.RoleId = roleId;
            }
            else
            {
                _user = new UserModel
                {
                    UserName = userNameTextBox.Text,
                    Password = passwordTextBox.Text,
                    RoleId = roleId
                };
            }
        }

        private void EnableDisableDeleteButton()
        {
            deleteButton.Enabled = _isUserSelected;
        }

        private void GetAllUsers()
        {
            try
            {
                _users = _userData.GetAllUsers();
            }
            catch (Exception ex)
            {
                UsefulMethods.LogException(ex);
            }
        }

        private void GetAllRoles()
        {
            try
            {
                _roles = _userData.GetAllRoles();
            }
            catch (Exception ex)
            {
                UsefulMethods.LogException(ex);
            }
        }

        private void LoadUserRoles()
        {
            rolesComboBox.DataSource = _roles;
            rolesComboBox.ValueMember = "Id";
            rolesComboBox.DisplayMember = "RoleName";
            rolesComboBox.SelectedIndex = -1;
        }

        private bool IsSamePassword(string first, string second)
        {
            bool output = true;

            if (first != second)
            {
                output = false;
            }

            return output;
        }

        private void RefrechGridDataSource(List<UserModel> dataSource)
        {
            usersDataGridView.AutoGenerateColumns = false;
            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = dataSource;
        }

        private void SaveUser()
        {
            try
            {
                CollectFormData();
                if (ValidateForm())
                {
                    if (_isUserSelected)
                    {
                        _userData.EditUser(_user);
                    }
                    else
                    {
                        _userData.CreateUser(_user);
                    }
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    if (!IsSamePassword(passwordTextBox.Text, repeatPasswordTextBox.Text))
                        MessageBox.Show("الكلمتان غير متطابقتان", "كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("تأكد من إدخال جميع الحقول", "الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void DeleteUser()
        {
            if (MessageBox.Show("هل أنت متأكد من الحــذف؟", "حــذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                _userData.DeleteUser(_user.Id);
                MessageBox.Show("تم الحــذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void SelectUser(int rowIndex)
        {
            if (rowIndex == -1) return;
            int selectedUserId;
            int.TryParse(usersDataGridView.Rows[rowIndex].Cells[0].Value.ToString(), out selectedUserId);

            _user = _users.Where(user => user.Id == selectedUserId).First();
            _isUserSelected = true;
        }

        private void LoadUserData()
        {
            userNameTextBox.Text = _user.UserName;
            passwordTextBox.Text = _user.Password;
            repeatPasswordTextBox.Clear();
            rolesComboBox.SelectedValue = _user.RoleId;
        }

        private void ShowHidePassword(bool isChecked)
        {
            passwordTextBox.UseSystemPasswordChar = isChecked;
            repeatPasswordTextBox.UseSystemPasswordChar = isChecked;
        }


        #endregion

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowHidePassword(!showPasswordCheckBox.Checked);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_users.Count == 0) return;

            SelectUser(e.RowIndex);
            EnableDisableDeleteButton();
            LoadUserData();
        }
    }
}
