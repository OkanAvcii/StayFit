using StayFIT_CORE.Enums;
using StayFIT_DAL.Concrete;
using StayFIT_SERVICE.DTOs;
using StayFIT_SERVICE.Services.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StayFIT_WFormUI
{
    public partial class frmMyProfileForm : Form
    {
        private readonly IUserService _userService;
        private string _email;
        private UserUpdateDTO user;
        public frmMyProfileForm(IUserService userService, string email)
        {
            InitializeComponent();
            _userService = userService;
            _email = email;
        }

        private void frmMyProfileForm_Load(object sender, EventArgs e)
        {
            try
            {

                // Kullanıcı bilgilerini al
                user = _userService.GetUserByEmail(_email);
                if (user != null)
                {
                    // Form alanlarını doldur
                    txtFirstName.Text = user.FirstName;
                    txtLastName.Text = user.LastName;
                    txtEmail.Text = user.Email;
                    txtPassword.Text = user.Password;
                    txtHeight.Text = user.Height.ToString();
                    txtWeight.Text = user.Weight.ToString();
                    dtpBirthdate.Value = user.BirthDate;
                    if (user.Gender == Gender.Male)
                    {
                        rdbMale.Checked = true;
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.Height = Convert.ToInt32(txtHeight.Text);
                user.Weight = Convert.ToInt32(txtWeight.Text);
                user.BirthDate = dtpBirthdate.Value;
                user.Gender = rdbMale.Checked ? Gender.Male : Gender.Female;
                _userService.Update(user, user.Id);

                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
