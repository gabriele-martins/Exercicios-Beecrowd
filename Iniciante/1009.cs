using System; 
class URI {
    static void Main(string[] args) { 
        string nome=Console.ReadLine();
        double salario=double.Parse(Console.ReadLine());
        double vendas=double.Parse(Console.ReadLine());
        double total=salario+(vendas*0.15);
        Console.WriteLine("TOTAL = R$ {0:F2}",total);
    }
}