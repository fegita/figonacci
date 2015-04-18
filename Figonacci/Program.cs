using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            int b=1;
            int c;
            Console.WriteLine("ingrese un numero");
            string snum = Console.ReadLine();
            int d = Convert.ToInt16(snum );
      
            //Console.WriteLine(f1);
            //Console.WriteLine(f2);
            ///

            for (int i = 1; d > b; i++)
            {
                c = b;
                b = a + b;
                a = c;

                if (d == b)
                {
                    Console.WriteLine(d + "  es un numero figonacci");
                } else  if (d < b)
                    {
                        Console.WriteLine(" no es un numero figonacci");
                        if (d - a > b - d)
                        {
                            Console.WriteLine("el numero mas cercano es " + b);
                        }
                        else if (d - a == b - d)
                        {
                            Console.WriteLine(d + " esta entre " + a + " y " + b + "en la secuencia figonacci");
                        }
                        else
                        {
                            Console.WriteLine("el numero mas cercano es  " + a);
                        }
                    }
                }
               


            Console.ReadLine();
             
        }
    }
}
