using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StayFIT_CORE.Services
{
    public class UserMailPasswordService
    {
        private string _email;
        private string _password;

        public UserMailPasswordService(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        //eMail validation
        public string Email
        {
            get { return _email; }
            set
            {
                if (IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format.");
                }
            }
        }

        // Public property for password with validation
        public string Password
        {
            get { return _password; }
            set
            {
                if (IsValidPassword(value))
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Password does not meet the required criteria.");
                }
            }
        }

        /// <summary>
        /// E Mailin @ işareti içerip içermediğini/ve nokta işaretinin @ ten sonra oldugunu kontrol eder
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        /// <summary>
        /// parolada en az 1 büyük 1 küçük 1 sayısal ifade oldugunu ve en az 8 karakterden olustugunu kontorl eder.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                // If all conditions are OK, return true
                if (hasUpperCase && hasLowerCase && hasDigit)
                    return true;
            }

            return false;



        }
    }
}
