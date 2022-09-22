using System;
namespace Classes1
{
    public class Cars
    {
        public Cars()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}

