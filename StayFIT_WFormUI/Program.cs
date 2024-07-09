using StayFIT_DAL.Concrete;
using StayFIT_DAL.Context;
using StayFIT_DAL.Interfaces;
using StayFIT_SERVICE.Services.CategoryService;
using StayFIT_SERVICE.Services.FoodService;
using StayFIT_SERVICE.Services.UserService;

namespace StayFIT_WFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string x = "Deneme";


            int okan = 0;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            StayFITDbContext context = new StayFITDbContext();
            IUserRepo repo = new UserRepo(context);
            IUserService service = new UserService(repo);

            ICategoryRepo categoryRepo = new CategoryRepo(context);
            ICategoryService categoryService = new CategoryService(categoryRepo);

            IFoodRepo foodRepo = new FoodRepo(context);
            IFoodService foodService = new FoodService(foodRepo);

            Application.Run(new frmLogin(service, categoryService, foodService));
        }
    }
}