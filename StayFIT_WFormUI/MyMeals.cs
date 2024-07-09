using StayFIT_CORE.Concrete;
using StayFIT_CORE.Enums;
using StayFIT_SERVICE.DTOs;
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
    public partial class frmMyMeals : Form
    {
        private MealCreateDTO _meal;
        private readonly ICategoryService _categoryService;
        private readonly IFoodService _foodService;
        public frmMyMeals(ICategoryService categoryService, IFoodService foodService)
        {
            InitializeComponent();
            cmbMeals.Items.Add("Breakfast");
            cmbMeals.Items.Add("Lunch");
            cmbMeals.Items.Add("Dinner");
            cmbMeals.Items.Add("Other");

            _meal = new MealCreateDTO();
            _categoryService = categoryService;
            _foodService = foodService;
        }

        private void MyMeals_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    // Kategori isimlerini al ve combobox'a ekle
            //    var categories = _categoryService.GetAll();
            //    cmbCategories.Items.Clear();
            //    foreach (var category in categories)
            //    {
            //        cmbCategories.DataSource = categories;
            //        //cmbCategories.Items.Add(category.Name);
            //        //cmbCategories.Items.Add(category.Id); combobox item ve value nasıl yüklenir.
            //    }
            //    cmbCategories.DisplayMember = "Name";
            //    cmbCategories.ValueMember = "Id";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Kategori isimlerini al ve combobox'a ekle
                var categories = _categoryService.GetAll();
                cmbCategories.Items.Clear();
                foreach (var category in categories)
                {
                    cmbCategories.DataSource = categories;
                    //cmbCategories.Items.Add(category.Name);
                    //cmbCategories.Items.Add(category.Id); combobox item ve value nasıl yüklenir.
                }
                cmbCategories.DisplayMember = "Name";
                cmbCategories.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //try
            //{
            //     ComboBox'tan seçilen öğeyi Meal sınıfındaki Name özelliğine ata
            //    _meal.Name = cmbMeals.SelectedItem.ToString();
            //    MessageBox.Show("Selected meal: " + _meal.Name);
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnMealCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'de seçilen yiyecekleri al
                var selectedFoods = new List<FoodGetDTO>();
                foreach (DataGridViewRow row in dgvFoods.SelectedRows)
                {
                    var food = row.DataBoundItem as FoodGetDTO;
                    if (food != null)
                    {
                        selectedFoods.Add(food);
                    }
                }

                if (selectedFoods.Any())
                {
                    _meal.Foods = selectedFoods;
                    MessageBox.Show("Meal created successfully: " + _meal.Name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select at least one food item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred..." + ex.Message);
            }


        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategories.SelectedItem != null)
                {
                    dynamic selectedCategory = cmbCategories.SelectedItem;
                    if (selectedCategory != null)
                    {
                        var foods = _foodService.GetFoodsByCategoryId(selectedCategory.Id);
                        dgvFoods.DataSource = foods;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yiyecekler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
