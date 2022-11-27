using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        string[] input=Console.ReadLine().Split();
        int [] secoes=Array.ConvertAll(input, int.Parse);
        int total=0, index=1, parcial=0;
        for(int i=0; i<n; i++){
            total+=secoes[i];
        }
        total/=2;
        for(int i=0; i<n; i++){
            parcial+=secoes[i];
            if(parcial==total){
                index+=i;
                break;
            }
        }
        Console.WriteLine(index);
    }
}