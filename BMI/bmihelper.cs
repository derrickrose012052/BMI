using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class bmihelper
    {
        public static string calculatebmi(UserInfo userInfo)
        {
            int weight = userInfo.weight;
            int tall = userInfo.tall;

            bool 性別 = userInfo.sex;


            double bmi = 10000.0 * weight / tall / tall;
            Console.WriteLine(bmi);
            if (性別 == true && bmi < 18.5)
            {
                return ("過輕");
            }
            else if (性別 == true && 18.5 <= bmi && bmi < 24)
            {
                return ("正常??");
            }
            else if (性別 == true && bmi > 24)
            {
                return ("過胖");
            }



            if (性別 == false && bmi< 18.5)
            {
                return ("過輕嗎");
            }
            else if (性別 == false && 18.5 <= bmi && bmi< 24)
            {
                return ("正常嗎");
            }
            else  if(性別 == false &&  bmi>24)
            {
                return ("過胖嗎");
            }
            else
            {
                throw new Exception("亂填");
            }
        }
    }
}
