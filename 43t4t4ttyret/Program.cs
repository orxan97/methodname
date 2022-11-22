using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace _43t4t4ttyret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
             metod(num);
        }

        static void metod(int num)
        {
            
            if (num % 7 == 0)
            {
                Console.WriteLine("eded 7-e bolunur");
            }
            else
            {
               if (num % 7 <= 3)
                {

                    Console.WriteLine(num -(num%7));
                }

                   else if(num% 7 >= 4)
                {
                    Console.WriteLine((num - (num % 7)+7));
                }
                   
               
                    

                }

            }

            
           
        }
      
    }
   