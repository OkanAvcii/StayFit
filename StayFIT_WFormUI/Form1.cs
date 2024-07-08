using StayFIT_CORE.Services;
using StayFIT_SERVICE.Services.UserService;

namespace StayFIT_WFormUI
{
    public partial class frmLogin : Form
    {
        private readonly IUserService _userService;
        public frmLogin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginEmail = txtLoginEmail.Text;
            string loginPassword = txtLoginPassword.Text;
            _userService.GetUserByEmailWithPassword(loginEmail, loginPassword);
            MessageBox.Show("Login successful");
            frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.Show();
        }

        private void linklblSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserCreate form2 = new frmUserCreate(_userService);
            form2.Show();
        }
    }
}
