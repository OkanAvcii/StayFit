using StayFIT_CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_WFormUI
{
    public static class Metotlar
    {
        public static int fatRateCalculate(Gender gender, int height, int weight, int age, Activity activityLevel)
        {
            if (gender == Gender.Male)
            {
                int fateRateForMen = (int)(66.5 + (13.75 * weight) + (5 * height) - (6.77 * age));
                if (activityLevel == Activity.None)
                {
                    fateRateForMen = (int)(fateRateForMen * 1.2);
                }
                else if (activityLevel == Activity.Little)
                {
                    fateRateForMen = (int)(fateRateForMen * 1.3);
                }
                else if (activityLevel == Activity.Normal)
                {
                    fateRateForMen = (int)(fateRateForMen * 1.4);
                }
                else if (activityLevel == Activity.More)
                {
                    fateRateForMen = (int)(fateRateForMen * 1.5);
                }
                return fateRateForMen;
            }
            else
            {
                int fataRateForWomen = (int)(655.1 + (9.56 * weight) + (1.85 * height) - (4.67 * age));
                if (activityLevel == Activity.None)
                {
                    fataRateForWomen = (int)(fataRateForWomen * 1.2);
                }
                else if (activityLevel == Activity.Little)
                {
                    fataRateForWomen = (int)(fataRateForWomen * 1.3);
                }
                else if (activityLevel == Activity.Normal)
                {
                    fataRateForWomen = (int)(fataRateForWomen * 1.4);
                }
                else if (activityLevel == Activity.More)
                {
                    fataRateForWomen = (int)(fataRateForWomen * 1.5);
                }
                return fataRateForWomen;
            }
        }
    }
}
