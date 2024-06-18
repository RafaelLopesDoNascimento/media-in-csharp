using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<double> list = new List<double>();
            double value = double.Parse(Console.ReadLine());
       
            void ReturnValue(double valueParam)
            {
                if (valueParam >= 0)
                {
                    list.Add(valueParam);
                } else if (list.Count <= 0 && valueParam < 0)
                {
                    Console.WriteLine("Impossible to calculate");
                }
            }

            double Media(List<double> listParam) {
                double total = 0;
                if (listParam.Count > 0)
                {
                    
                foreach (var item in listParam)
                {
                    total += item;
                }
                return total/listParam.Count;
                } else
                {
                    Console.WriteLine("Impossible to calculate media");
                    return total;
                }
            }

            while (value > 0)
            {
                ReturnValue(value);
                value = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(Media(list).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
