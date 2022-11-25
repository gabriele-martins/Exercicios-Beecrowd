using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string frase="LIFE IS NOT A PROBLEM TO BE SOLVED";
        string print=frase.Substring(0,n);
        Console.WriteLine(print);
    }
}