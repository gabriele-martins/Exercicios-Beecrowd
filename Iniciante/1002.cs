using System; 
class URI {
    static void Main(string[] args) { 
        double area,raio;
        const double PI=3.14159;
        raio=double.Parse(Console.ReadLine());
        area=PI*(raio*raio);
        Console.WriteLine("A={0:F4}",area);
    }
}