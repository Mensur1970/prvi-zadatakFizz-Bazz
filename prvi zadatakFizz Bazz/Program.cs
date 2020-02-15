using System;

namespace prvi_zadatakFizz_Bazz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi bro:>");
            string unos;
            unos = Console.ReadLine();
            int broj;
            broj = int.Parse(unos);
            // int a = int.Parse(Console.ReadLine())

            int broj1 = 1;
            while (broj1 < broj)
            {
                ++broj1;




                if (broj1 % 3 == 0 && broj1 % 5 == 0)
                { 
                    Console.WriteLine(broj1 + "Fizz i buzz");
                }
                else if (broj1 % 3 == 0)
                {
                    Console.WriteLine(broj1 + "buzz");
                }

                else if (broj1 % 5 == 0)
                {
                    Console.WriteLine(broj1 + "Fizz");
                }
                
            
                else
                {
                    Console.WriteLine(broj1); 
                }
                    
                
                
                   



            }
        } 
    }
}
