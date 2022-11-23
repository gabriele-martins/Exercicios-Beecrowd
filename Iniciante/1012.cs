using System; 
class URI {
    static void Main(string[] args) { 
        string[] valores=Console.ReadLine().Split();
        const double PI=3.14159;
        double a=double.Parse(valores[0]);
        double b=double.Parse(valores[1]);
        double c=double.Parse(valores[2]);
        double triangulo=(a*c)/2;
        double circulo=PI*(c*c);
        double trapezio=((a+b)*c)/2;
        double quadrado=b*b;
        double retangulo=a*b;
        Console.WriteLine("TRIANGULO: {0:F3}",triangulo);
        Console.WriteLine("CIRCULO: {0:F3}",circulo);
        Console.WriteLine("TRAPEZIO: {0:F3}",trapezio);
        Console.WriteLine("QUADRADO: {0:F3}",quadrado);
        Console.WriteLine("RETANGULO: {0:F3}",retangulo);
    }
}