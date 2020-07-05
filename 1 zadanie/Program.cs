using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            string[] s = text.Split('!','.','?');

            for (int i = 0; i < s.Length; ++i)
            {
                string[] words = text.Split(new char[] { ' ' });

                foreach (string word in words)
                {
                    var result = words.GroupBy(x => x.ToLower()).ToList()
                   .Where(x => x.Count() > 1)
                   .Select(x => new { Word = x.Key });
                    foreach (var item in result)

                        Console.WriteLine($"Повтор- {item.Word} в {++i} предложении");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}



            

            
        
   

                    
                    

            
