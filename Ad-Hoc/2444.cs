using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada1=Console.ReadLine().Split();
        string[] entrada2=Console.ReadLine().Split();
        int v=int.Parse(entrada1[0]);
        int t=int.Parse(entrada1[1]);
        int[] mods=Array.ConvertAll(entrada2,int.Parse);
        for(int i=0; i<t; i++){
            v+=mods[i];
            if(v>100){
                v=100;
            }
            else if(v<0){
                v=0;
            }
        }
        Console.WriteLine(v);
    }
}