using System; 
class URI {
    static void Main(string[] args) { 
        int valor=int.Parse(Console.ReadLine());
        int valor_inicial=valor;
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
        int nota1=(int)(valor);
        Console.WriteLine(valor_inicial);
        Console.WriteLine("{0} nota(s) de R$ 100,00",nota100);
        Console.WriteLine("{0} nota(s) de R$ 50,00",nota50);
        Console.WriteLine("{0} nota(s) de R$ 20,00",nota20);
        Console.WriteLine("{0} nota(s) de R$ 10,00",nota10);
        Console.WriteLine("{0} nota(s) de R$ 5,00",nota5);
        Console.WriteLine("{0} nota(s) de R$ 2,00",nota2);
        Console.WriteLine("{0} nota(s) de R$ 1,00",nota1);
    }
}