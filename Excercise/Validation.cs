using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class Validation
    {
        public static int GetInteger(int min, int max, string mess)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Vuot qua pham vi cho phep");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai format.Nhap lai");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("So nhap vao vuot qua pham vi. Nhap lai.");
                }
            }
            
        }

        public static string GetString(int minLength, int maxLength, string mess)
        {
            string value;
            while(true)
            {
                Console.WriteLine(mess);
                value = Console.ReadLine().Trim();
                if (value.Length >= minLength || value.Length <= maxLength) return value;
                Console.WriteLine("Do dai xau chua phu hop. Nhap lai");
            }    
        }
        public static DateTime GetDateTime(DateTime minDate, DateTime maxDate,string pattern, string mess)
        {
            DateTime value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    if (value < minDate || value > maxDate) throw new OverflowException("Vuot qua pham vi cho phep");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai format.Nhap lai");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("So nhap vao vuot qua pham vi. Nhap lai.");
                }
            }
        }
    }
}
