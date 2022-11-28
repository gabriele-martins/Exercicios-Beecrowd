using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] entrada=Console.ReadLine().Split();
        double[] alunos=Array.ConvertAll(entrada,double.Parse);
        int total=0;
        for(int i=0; i<n; i++){
            total+=(int)(Math.Floor(alunos[i]/3.0)*3);
        }
        Console.WriteLine(total);
    }
}