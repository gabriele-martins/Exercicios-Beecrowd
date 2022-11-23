using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int c=int.Parse(input[2]);
        int maior=(a+b+Math.Abs(a-b))/2;
        maior=(maior+c+Math.Abs(maior-c))/2;
        Console.WriteLine("{0} eh o maior",maior);
    }
}