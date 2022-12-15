using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EnglishProgramConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("szavak.txt");
            List<hungarianenglish> words = new List<hungarianenglish>();
           
            while (!sr.EndOfStream)
            {
                string line= sr.ReadLine();
                string[] pieces = line.Split(';');
                hungarianenglish he = new hungarianenglish();
                he.hungarian = pieces[0];
                he.english= pieces[1];
                words.Add(he);
            }

            foreach (var item in words)
            {

                Console.WriteLine("-------------------------------");
                Console.WriteLine("("+item.hungarian+")" + " " + "Kérlek írd be angolul:");
                string szo = Console.ReadLine();


                if (szo == item.english)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Helyes megoldás!");


                }
                else if (szo != item.english)
                {
                    
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.WriteLine("Elrontottad,kérlek próbáld újra ! a szó: " +"("+ item.hungarian + ")"+" Próbálkozások száma: "+i+"/2");
                            szo = Console.ReadLine();
                        
                     

                            }
                        if (szo==item.english)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Helyes megoldás!");
                        }
                        else
                        {
                            Console.WriteLine("A helyes megoldás ez lett volna: " + item.english);
                            sr.ReadLine();
                        }
                   

                    

                    
                }
                
               
            }

            Console.WriteLine("Sikeresen megoldottad,ügyes vagy ! :) ");
            Console.ReadKey();
        }
    }
}
