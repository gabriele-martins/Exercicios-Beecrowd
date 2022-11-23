using System; 
class URI {
    static void Main(string[] args) { 
        const double PI=3.14159;
        double raio=double.Parse(Console.ReadLine());
        double volume=(4.0/3.0)*PI*(raio*raio*raio);
        Console.WriteLine("VOLUME = {0:F3}",volume);
    }
}