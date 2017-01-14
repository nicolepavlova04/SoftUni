using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Thea
    {
        static void Main(string[] args)
        {
            double totalPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double filteretPictures = Math.Ceiling(totalPictures * (percentage / 100));
            double totalFilterTime = totalPictures * filterTime;
            double uploadingTime = filteretPictures * uploadTime;
            double totalTime = totalFilterTime + uploadingTime;
            TimeSpan ts = TimeSpan.FromSeconds(totalTime);
            string str = ts.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);



        }
    }
}
