using StayFIT_DAL.Concrete;
using StayFIT_DAL.Context;
using StayFIT_DAL.Interfaces;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            StayFITDbContext context = new StayFITDbContext();
            IUserRepo repo = new UserRepo(context);
            IUserService service = new UserService(repo);

            Application.Run(new frmLogin(service));
        }
    }
}