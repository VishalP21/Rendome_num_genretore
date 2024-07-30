using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendome_num_genretore
{
    public class Rendomenum
    {
        public int a = 0;
        public int b = 0;

        public void input()
        {
            Console.WriteLine("Enter value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b make sure is greater to the a");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(a,b));
        }
    }
}
