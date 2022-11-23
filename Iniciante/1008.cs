using System;
class URI {
    static void Main(string[] args) { 
        int number=int.Parse(Console.ReadLine());
        int hours=int.Parse(Console.ReadLine());
        double value=double.Parse(Console.ReadLine());
        double salary=value*hours;
        Console.WriteLine("NUMBER = {0}",number);
        Console.WriteLine("SALARY = U$ {0:F2}",salary);
    }
}