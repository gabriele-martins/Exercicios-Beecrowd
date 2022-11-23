using System;
public class Program {
    public static void Main(string[] args) {
        double valor=double.Parse(Console.ReadLine());
        int nota100=(int)(valor/100);
        valor-=100*nota100;
        int nota50=(int)(valor/50);
        valor-=50*nota50;
        int nota20=(int)(valor/20);
        valor-=20*nota20;
        int nota10=(int)(valor/10);
        valor-=10*nota10;
        int nota5=(int)(valor/5);
        valor-=5*nota5;
        int nota2=(int)(valor/2);
        valor-=2*nota2;
        valor *= 100;
        int moeda100=(int)(valor/100);
        valor-=100*moeda100;
        int moeda50=(int)(valor/50);
        valor-=50*moeda50;
        int moeda25=(int)(valor/25);
        valor-=25*moeda25;
        int moeda10=(int)(valor/10);
        valor-=10*moeda10;
        int moeda5=(int)(valor/5);
        valor-=5*moeda5;
        Console.WriteLine("NOTAS:");
        Console.WriteLine("{0} nota(s) de R$ 100.00",nota100);
        Console.WriteLine("{0} nota(s) de R$ 50.00",nota50);
        Console.WriteLine("{0} nota(s) de R$ 20.00",nota20);
        Console.WriteLine("{0} nota(s) de R$ 10.00",nota10);
        Console.WriteLine("{0} nota(s) de R$ 5.00",nota5);
        Console.WriteLine("{0} nota(s) de R$ 2.00",nota2);
        Console.WriteLine("MOEDAS:");
        Console.WriteLine("{0} moeda(s) de R$ 1.00",moeda100);
        Console.WriteLine("{0} moeda(s) de R$ 0.50",moeda50);
        Console.WriteLine("{0} moeda(s) de R$ 0.25",moeda25);
        Console.WriteLine("{0} moeda(s) de R$ 0.10",moeda10);
        Console.WriteLine("{0} moeda(s) de R$ 0.05",moeda5);
        Console.WriteLine("{0} moeda(s) de R$ 0.01",(int)valor);
    }
}