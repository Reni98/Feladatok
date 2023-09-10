using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készíts egy olyan konzol alkalmazást ami bekéri a felhasználótól,
            //hogy melyik filmet válassza: Akció, Vigjáték, Animációs film.
            //Diák vagy felnőt, ezt is kérje be az alkalmazás.
            //Ha diák, akkor jelenjen meg a consolon, hogy 1500Ft a diák jegy ára
            //Ha felnőt, akkor jelenjen meg a consolon, hogy 2000Ft a jegy ára.
            //Addig kérjen be a felhasználótól a filmet, ameddig nem a feltételnek megfelelőt ír be a felhasználó.
            //A végén pedig köszönjön el a program
            /*
            bool choose = false; // Ezt módosítottam false-ra, hogy a ciklus lefuthasson.


            while (!choose)
            {
                Console.WriteLine("Üdvözlöm a moziban, melyik filmre szeretne jegyet?: Akció, vígjáték, Animációs film");
                string movie = Console.ReadLine();
                if (movie == "Akció" || movie == "Vígjáték" || movie == "Animációs film")
                {
                    Console.WriteLine(" diák vagy felnőtt?");
                    string person = Console.ReadLine();
                    if (person == "felnőt")
                    {
                        Console.WriteLine("Az Ön jegye: 2000FT");
                    }
                    else if (person == "diák")
                    {
                        Console.WriteLine("Az Ön jegye: 1500FT");
                    }
                    choose = true; // Itt változtattam meg a choose értékét true-ra, hogy kilépjen a ciklusból.
                }
                else
                {
                    Console.WriteLine("Nem választott filmet");
                }
            }*/

            /*
             * 
            //Legyen egy random szám generátor 1-10-ig.
            //Kérj be a felhasználótól 1-10-ig terjedő számot.
            //Ha a két szám egyezik akkor írja ki, hogy nyert, ha nem egyezik, akkor azt írja ki, hogy vesztett.
            //Addig kérje be a program a számot a felhasználótól ameddig nem nyert.
            //2.Feladat
            //Kérjen be a felhasználótól 1-10-ig számot
            Random random = new Random();
            int randomSzam = random.Next(1, 11);
            bool nyert = false;

            Console.WriteLine("Gondoltam egy számra 1 és 10 között. Találd ki!");

            while (!nyert)
            {
                string input = Console.ReadLine();
                int inputNumber;

                if (int.TryParse(input, out inputNumber))
                {
                    if (inputNumber == randomSzam)
                    {
                        Console.WriteLine("Gratulálok! Nyertél!");
                        nyert = true;
                    }
                    else
                    {
                        Console.WriteLine("Nem találtad el, próbáld újra!");
                    }
                }
                else
                {
                    Console.WriteLine("Érvénytelen szám. Kérlek, adj meg egy érvényes számot.");
                }
            }
            
            
           //3.Feladat
           for(int i = 1; i < 21; i++)
            {
                if(i % 3 == 0)
                Console.WriteLine(i);
            }
            */
          
            //Fizz Buzz feladat
            //A számok 1-100-ig legyenek
            //Ha a szám osztható 3-al akkor írja ki, hogy Fizz.
            //Ha a szám osztható 5-el akkor írja ki, hogy Buzz.
            //Ha 3-al és 5-el is osztható akkor azt írja ki, hogy Fizz Buzz.
            //Legyen kiírva a többi szám is.
            for (int i = 1;i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(i); }
            }

            Console.ReadKey();
            }

        
        }
    }

