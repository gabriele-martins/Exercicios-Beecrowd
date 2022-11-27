using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] frase=Console.ReadLine().Split();
        string saida="";
        foreach(string hex in frase){
            int valor=Convert.ToInt32(hex, 16);
            char charValor=(char)valor;
            saida+=charValor;
        }
        Console.WriteLine(saida);
    }
}