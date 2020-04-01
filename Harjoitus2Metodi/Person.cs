using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2Metodi
{
    class Person
    {
        public string name;
        public int age;
        public List<string> Hobbies = new List<string>();
        public Person friend;
        bool Old = false;

        public void Greet()
        {
            Console.WriteLine($"Terve! Miten menee?");
        }

        public void FormanGreet()
        {
            Console.WriteLine($"Terve, olen {name} ja olen {age} vuotta vanha.");
        }

        public void Ages()
        {
            {

                if (age >= 18)
                {
                    Console.WriteLine($"Olen täysi-ikäinen.");
                    Old = true;
                }

                else
                {
                    Console.WriteLine($"Olen alaikäinen.");
                    Old = false;
                }
            }

            {
                if (Old == true)
                {
                    Console.WriteLine($"Olet vanha.");
                }

                else
                {
                    Console.WriteLine($"Olet nuori.");
                }
            }

        }

        public void GrowingOld(int years)
        {
            age += years;
        }

        public void Older()
        {
            if (friend == null)
            {
                Console.WriteLine($"{name} on yksinäinen.");
            }

            else if (age < friend.age)
            {
                Console.WriteLine($"{friend.name} on vanhempi kuin {name}.");
            }

            else
            {
                Console.WriteLine($"{name} on vanhempi kuin {friend.name}.");
            }
        }
    }
}
