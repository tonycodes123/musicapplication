using musicdal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musiclib
{
    public class musicutils
    {
        public static List<songlist> songlists = new List<songlist>();
        public static int musiccount {  get; set; }
        public static void Log<T>(T[] pvalues)
        {
            string res = "";
            foreach (var item in pvalues)
            {
                res = $"{res}{item}";
            }
            var finalres = $"[ {DateTime.Now.ToString()} ] : {res}";

            Console.WriteLine(finalres) ;
        }
    }
}
