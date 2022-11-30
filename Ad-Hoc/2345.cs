using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada,int.Parse);
        Array.Sort(valores);
        int d1=valores[3]-valores[2];
        int d2=valores[1]-valores[0];
        int dif=Math.Abs(d1-d2);
        Console.WriteLine(dif);
    }
}