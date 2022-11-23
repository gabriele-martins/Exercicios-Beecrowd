using System; 
class URI {
    static void Main(string[] args) { 
        int distancia=int.Parse(Console.ReadLine());
        double combustivel=double.Parse(Console.ReadLine());
        double consumo=distancia/combustivel;
        Console.WriteLine("{0:F3} km/l", consumo);
    }
}