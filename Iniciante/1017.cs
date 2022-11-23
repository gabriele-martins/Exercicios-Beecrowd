using System; 
class URI {
    static void Main(string[] args) { 
        int tempo=int.Parse(Console.ReadLine());
        int velocidade=int.Parse(Console.ReadLine());
        int distancia=velocidade*tempo;
        double litros=distancia/12.0;
        Console.WriteLine(litros.ToString("F3"));
    }
}