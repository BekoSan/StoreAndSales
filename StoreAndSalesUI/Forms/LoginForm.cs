using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
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
    public partial class LoginForm : Form ,ILogout
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private UserData _userData = new UserData();
        private UserModel _user = new UserModel();
        private UserLogData _userLogData= new UserLogData();

        #endregion


        #region Private Methods

        private void CollectFormData()
        {
            if (IsUserExsist())
            {
                _user.UserName = userNameTextBox.Text;
                _user.Password = passwordTextBox.Text;
            }
            else
            {
                _user = new UserModel
                {
                    UserName = userNameTextBox.Text,
                    Password = passwordTextBox.Text
                };
            }
        }

        private bool IsUserExsist()
        {
            bool output = true;

            if (_user == null)
            {
                output = false;
            }

            return output;
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

            return output;
        }

        private void ClearForm()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            _user = new UserModel();
        }

        private void Login()
        {
            try
            {
                CollectFormData();
                if (ValidateForm())
                {
                    _user = _userData.UserLogin(_user);

                    if (IsUserExsist())
                    {;
                        Hide();
                        _userLogData.AddLog(_user.Id, "تم تسجيل الدخول للنظام");
                        LoginDataHelper.UserId = _user.Id;
                        LoadSession(_user.RoleId);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في إسم المستخدم أو كلمة المرور", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("تأكد من إدخال جميع الحقول", "الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"خطأ في البرنامج",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void LoadSession(int roleId)
        {
            DashboardForm dashboard = new DashboardForm(roleId,this);
            dashboard.ShowDialog(); 
        }

        #endregion

        public void Logout(Form form)
        {
            form.Hide();
            Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login(); 
        }
    }
}
