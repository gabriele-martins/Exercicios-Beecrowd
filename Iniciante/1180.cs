using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int[] x=new int[n];
        string[] input=new string[n];
        input=Console.ReadLine().Split();
        x=Array.ConvertAll(input, int.Parse);
        int menor=x[0], index=0;
        for(int i=1; i<n; i++){
            if(x[i]<menor){
                menor=x[i];
                index=i;
            }
        }
        Console.WriteLine("Menor valor: {0}", menor);
        Console.WriteLine("Posicao: {0}", index);
    }
}