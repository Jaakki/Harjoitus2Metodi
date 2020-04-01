using System;

namespace Harjoitus2Metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.name = "Jimbo";
            per1.age = 27;
            per1.Hobbies.Add("gambling");
            per1.Hobbies.Add("drinking");
            per1.Greet();
            per1.FormanGreet();
            per1.Ages();

            Person per2 = new Person();
            per2.name = "Bambo";
            per2.age = 25;
            per2.Hobbies.Add("gaming");
            per2.Hobbies.Add("cycling");
            per2.Ages();

            Person per3 = new Person();
            per3.name = "Ted";
            per3.age = 13;
            per3.Hobbies.Add("writing");
            per3.Ages();

            per1.friend = per2;                 //lisätään kaverit vasta täällä, koska ne pitää luoda ensin!
            per2.friend = per1;

            Console.WriteLine($"{per1.name} {per1.age} {per1.Hobbies[0]} {per1.Hobbies[1]}");
            Console.WriteLine($"{per2.name} {per2.age} {per2.Hobbies[0]} {per2.Hobbies[1]}");
            Console.WriteLine($"{per3.name} {per3.age} {per3.Hobbies[0]}");

            per1.GrowingOld(5);
            per2.GrowingOld(4);
            per3.GrowingOld(3);

            Console.WriteLine($"{per1.name} {per1.age} {per1.Hobbies[0]} {per1.Hobbies[1]}");
            Console.WriteLine($"{per2.name} {per2.age} {per2.Hobbies[0]} {per2.Hobbies[1]}");
            Console.WriteLine($"{per3.name} {per3.age} {per3.Hobbies[0]}");


            per1.Older();
            per2.Older();
            per3.Older();

            Console.ReadLine();
        }
    }
}
