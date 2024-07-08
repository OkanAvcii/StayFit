using StayFIT_CORE.Enums;
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
    public partial class frmUserCreate : Form
    {
        private readonly IUserService _userService;
        public frmUserCreate(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _userService.Create(new StayFIT_SERVICE.DTOs.UserCreateDTO
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Height = Convert.ToInt32(txtHeight.Text),
                Weight = Convert.ToInt32(txtWeight.Text),
                BirthDate = dtpBirthdate.Value,
                Gender = rdbMale.Checked ? Gender.Male : Gender.Female
            });
        }
    }
}
