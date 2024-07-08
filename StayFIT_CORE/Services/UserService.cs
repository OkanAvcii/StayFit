using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Services
{
    public static class UserService
    {
        /// <summary>
        /// Girilen isim ve soyisimin kontrolünü yapar
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
        }
        public static bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
