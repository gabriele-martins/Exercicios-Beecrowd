using System; 
class URI {
    static void Main(string[] args) { 
        string[] valor=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(valor, int.Parse);
        Array.Sort(valores);
        Console.WriteLine("{0}",valores[0]);
        Console.WriteLine("{0}",valores[1]);
        Console.WriteLine("{0}",valores[2]);
        Console.Write("\n");
        Console.WriteLine("{0}",valor[0]);
        Console.WriteLine("{0}",valor[1]);
        Console.WriteLine("{0}",valor[2]);
    }
}