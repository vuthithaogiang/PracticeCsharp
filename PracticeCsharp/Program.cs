using System;

using Excercise2;

public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Hello");
        Lion lion = new Lion(200, "Simba");
        Tiger tiger = new Tiger(150, "Rajah");

        Animal[] animals = { lion, tiger };

        foreach (var animal in animals)
        {
            animal.Show();
            Console.WriteLine();
        }
    }
}