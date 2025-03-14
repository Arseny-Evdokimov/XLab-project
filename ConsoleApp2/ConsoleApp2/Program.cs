using System;

internal class Program
{
    class House
    {
        public string street;
        public int number;

        public void Print()
        {
            Console.WriteLine($"{street}, {number}");
        }
        static void Main(string[] args)
        {
            House tower = new House();
            tower.street = "Садовая";
            tower.number = 23;

            tower.Print();
        }
    }
}
