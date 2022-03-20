using System;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] grp = new Group[2];
            string inp;
            int inp2;
            Console.WriteLine("no daxil edin");
            do
            {

         
            Console.WriteLine("DUZ  daxil et sikerem");
             inp= Console.ReadLine();
            } while (!(charstrr(inp) || inp.Length==5 ));


            Console.WriteLine("telebe limitini daxil et");
            do
            {
                Console.WriteLine("duz daxil et sikerem");
                inp2= int.Parse(Console.ReadLine());

            } while (inp2>15);
            for (int i = 0; i < grp.Length; i++)
            {
                grp[i] = new Group(inp, inp2);

            }
            foreach (var item in grp)
            {
                Console.WriteLine($"no{item.Nooo} telebe limiti{item.MyProperty}");

            }
            
            
        }
        static bool charstrr(string a)
        {
            if (string.IsNullOrWhiteSpace(a) && a.Length == 5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsUpper(a[0]) && char.IsUpper(a[1]) && char.IsDigit(a[2]) && char.IsDigit(a[3]))
                    {
                        return true;

                    }

                }

            }
            return false;





        }
        






        
    }
}
