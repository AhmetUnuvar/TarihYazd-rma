using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarihodevlab
{
    class Program
    {
        static void Main(string[] args)
        {
            TarihFormat();
            Console.ReadLine();
        }
        public static void TarihFormat()
        {

            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi.ToLongDateString());
            Console.ReadKey();
            
        }
    }
}
