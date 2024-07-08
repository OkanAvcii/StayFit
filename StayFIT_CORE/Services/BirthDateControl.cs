using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Services
{
    public static class BirthDateControl
    {
        public static bool isValidBirthDate(DateTime date)
        {
            if (date < DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
