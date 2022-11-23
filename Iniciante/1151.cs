using System; 
class URI {
    static void Main(string[] args) { 
        int quant=int.Parse(Console.ReadLine());
        int fib1=0, fib2=1, fib3;
        Console.Write("{0} ", fib1);
        Console.Write("{0} ", fib2);
        for(int i=0; i<quant-3; i++){
            fib3=fib1+fib2;
            fib1=fib2;
            fib2=fib3;
            Console.Write("{0} ", fib3);
        }
        fib3=fib1+fib2;
        Console.WriteLine(fib3);
    }
}