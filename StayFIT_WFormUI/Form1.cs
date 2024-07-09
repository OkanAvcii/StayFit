using StayFIT_CORE.Concrete;
using StayFIT_CORE.Services;
using StayFIT_SERVICE.DTOs;
using StayFIT_SERVICE.Services.CategoryService;
using StayFIT_SERVICE.Services.FoodService;
using StayFIT_SERVICE.Services.UserService;

namespace StayFIT_WFormUI
{
    public partial class frmLogin : Form
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly IFoodService _foodService;
        public frmLogin(IUserService userService, ICategoryService categoryService,IFoodService foodService)
        {
            InitializeComponent();
            _userService = userService;
            _categoryService = categoryService;
            _foodService = foodService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginEmail = txtLoginEmail.Text;
            string loginPassword = txtLoginPassword.Text;
            _userService.GetUserByEmailWithPassword(loginEmail, loginPassword);
            MessageBox.Show("Login successful");
            frmMainForm frmMainForm = new frmMainForm(_userService, _categoryService,_foodService, loginEmail);
            frmMainForm.Show();
            this.Hide();
        }

        private void linklblSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserCreate form2 = new frmUserCreate(_userService);
            form2.Show();
        }
    }
}
