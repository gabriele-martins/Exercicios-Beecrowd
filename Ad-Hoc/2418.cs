using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        double[] notas=Array.ConvertAll(entrada,double.Parse);
        Array.Sort(notas);
        double soma=notas[1]+notas[2]+notas[3];
        Console.WriteLine(soma.ToString("F1"));
    }
}