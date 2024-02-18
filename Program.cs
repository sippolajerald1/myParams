using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many items would you like to enter?");
        int size = int.Parse(Console.ReadLine());
        int[] stringArr = new int[size];
        Random r = new Random();
        Console.WriteLine("Here are your random numbers");

        for (int i = 0; i < size; i++)
        {
            stringArr[i] = r.Next(1,20);
            Console.WriteLine(stringArr[i]);
        }
    
        
        
       
        Console.WriteLine($"Total of the numbers array={Add(stringArr)}");
        Console.WriteLine($"The total of the numbers array={Multiply(stringArr)}");
       

    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }


}
