using StayFIT_CORE.Enums;
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
        public frmMyProfileForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı girişlerini UserCreateDTO nesnesine aktar
                UserCreateDTO user = new UserCreateDTO
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Height = Convert.ToInt32(txtHeight.Text), // Yükseklik alanını sayıya dönüştür
                    Weight = Convert.ToInt32(txtWeight.Text), // Ağırlık alanını sayıya dönüştür
                    BirthDate = dtpBirthdate.Value,
                    Gender = rdbMale.Checked ? Gender.Male : Gender.Female // Cinsiyet seçimi
                };

                // UserService üzerinden kullanıcı güncelleme işlemini çağır
                _userService.Update(user);

                // Başarılı güncelleme mesajı göster
                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kullanıcı arayüzünü sıfırla veya güncelle
                ClearForm(); // Formu temizleme veya yenileme işlevi, örneğin, kullanıcı bilgilerini temizler.

            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Form elemanlarını temizle
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            dtpBirthdate.Value = DateTime.Now; // Varsayılan olarak bugünün tarihini ayarla
            rdbMale.Checked = true; // Varsayılan olarak erkek seçeneğini işaretle
            rdbFemale.Checked = false; // Diğer cinsiyet seçeneklerini temizle (isteğe bağlı)
        }
    }
}
