using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        enum sex { 男生,女生};
        static void Main(string[] args)
       {
            UserInfo userInfo = new UserInfo();



            Console.WriteLine("請輸入1or0(1=男生0=女生)");
            string inputSex_string = Console.ReadLine();
            int inputSex_int = Convert.ToInt32(inputSex_string);
            userInfo.sex = Convert.ToBoolean(inputSex_int);


            Console.WriteLine("請輸入體重(KG)");
            string temp = Console.ReadLine();
            userInfo.weight = Convert.ToInt32(temp);


            Console.WriteLine("請輸入身高(CM)");
            string temp1 = Console.ReadLine();
            userInfo.tall = Convert.ToInt32(temp1);

            bmihelper.calculatebmi(userInfo);
            //switch (sex1)
            //{
            //    case sex.男生:
            //        if(bmi<18.5)
            //        {
            //            Console.WriteLine("");
            //        }
            //    else if(18.5 <= bmi && bmi < 24)
            //     {
            //         Console.WriteLine("正常");
            //      }
            //      else if (性別 == true && bmi > 24)
            //      {
            //        Console.WriteLine("過胖");
            //      }
            //        break;
            //    case sex.女生:
            //    default:
            //        break;

                    
            //}

           

            Console.ReadLine();
        }

    }
}

