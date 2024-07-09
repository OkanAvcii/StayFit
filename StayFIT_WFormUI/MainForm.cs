using StayFIT_SERVICE.Services.CategoryService;
using StayFIT_SERVICE.Services.FoodService;
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
    public partial class frmMainForm : Form
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly IFoodService _foodService;
        string _email;
        public frmMainForm(IUserService userService, ICategoryService categoryService, IFoodService foodService, string email)
        {
            InitializeComponent();
            _userService = userService;
            _categoryService = categoryService;
            _foodService = foodService;
            _email = email;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyProfileForm frmMyProfileForm = new frmMyProfileForm(_userService, _email);
            frmMyProfileForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void createMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyMeals frmMyMeals = new frmMyMeals(_categoryService, _foodService);
            frmMyMeals.Show();
        }
    }
}
