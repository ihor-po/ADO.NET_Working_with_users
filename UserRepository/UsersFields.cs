using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRepository.Classes;

namespace UserRepository
{
    public partial class UsersFields : Form
    {
        private string rLog;
        private string rPas;
        private string rPhone;
        private string rAddress;

        User _user;
        bool _isNew;

        public UsersFields(User user, bool isNew)
        {
            InitializeComponent();

            _user = user;
            _isNew = isNew;

            if (_isNew)
            {
                this.Text = "Создание пользователя";
                bCreate_Edit.Text = "Создать";
                chb_isAdmin.Checked = false;
            }
            else
            {
                this.Text = "Редактирование пользователя";
                bCreate_Edit.Text = "Изменить";

                if (_user.IsAdmin == 1)
                {
                    chb_isAdmin.Checked = true;
                }
                else
                {
                    chb_isAdmin.Checked = false;
                }
            }

            tb_login.Text = user?.Login;
            tb_password.Text = "";
            tb_address.Text = user?.Address;
            mtb_phone.Text = user?.Phone;

            rLog = @"^[a-zA-Zа-яА-ЯіІїЇ -_]{2,25}$";
            rPas = @"(?=.*\d).{6,}";
            rPhone = @"\d{12}";
            rAddress = @"^[a-zA-Zа-яА-ЯіІїЇ0-9/ -]{2,50}$";

        }

        /// <summary>
        /// Отмена создания/изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Создание / изменение пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string phone = mtb_phone.Text.Replace("(", "").Replace(")", "").Replace("-", "");

            if (!Regex.Match(tb_login.Text, rLog).Success)
            {
                ShowMessage( "Поле \"Логин\" заполнено неверно!\rМинимальная длина 2 символа.\rМаксимальная - 25");
                return;
            }

            if (!Regex.Match(tb_password.Text, rPas).Success)
            {
                if (_isNew)
                {
                    ShowMessage("Поле \"Пароль\" заполнено неверно!\rМинимальная длина 6 символов.\rДолжна присутсвовать одна цифра");
                    return;
                }
                else if (tb_password.Text != "")
                {
                    if (tb_password.Text.GetHashCode() != _user.Password)
                    {
                        if (MessageBox.Show("Вы уверены, что хотите изменить пароль?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            ShowMessage("Отмена изменений!\rОчистите поле \"Пароль\" ");
                            return;
                        }
                        else
                        {
                            if (!Regex.Match(tb_password.Text, rPas).Success)
                            {
                                ShowMessage("Поле \"Пароль\" заполнено неверно!\rМинимальная длина 6 символов.\rДолжна присутсвовать одна цифра");
                                return;
                            }
                        }
                    }
                }
                
            }

            if (!Regex.Match(tb_address.Text, rAddress).Success)
            {
                ShowMessage("Поле \"Адресс\" заполнено неверно!\rМинимальная длина 2 символов.\rМаксимальная - 50");
                return;
            }

            if (!Regex.Match(phone, rPhone).Success)
            {
                ShowMessage("Поле \"Телефон\" заполнено неверно!");
                return;
            }

            _user.Login = tb_login.Text;
            if (tb_password.Text != "")
            {
                _user.Password = tb_password.GetHashCode();
            }
            _user.Address = tb_address.Text;
            _user.Phone = phone;

            if (chb_isAdmin.Checked == true)
            {
                _user.IsAdmin = 1;
            }
            else
            {
                _user.IsAdmin = 0;
            }
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        /// <summary>
        /// Отображение сообщения
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
