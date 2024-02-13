using System;

namespace quiz1
{
    public class Person
    {
        public string Name { get; set; }

        public int Weight { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            while (true)
            {
                Console.WriteLine("Enter new data? [Y/N]");

                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Person person1 = new Person();

                Console.WriteLine("Enter your name=");
                person1.Name = Console.ReadLine();


                Console.WriteLine("Enter your weight =");
                person1.Weight = int.Parse(Console.ReadLine());

                list.Add(person1);

            }

            list.ForEach(x =>
            {
                Console.WriteLine("Name: " + x.Name);
                Console.WriteLine("Weight: " + x.Weight);
                Console.WriteLine("======================");
            });


        }
    }

}