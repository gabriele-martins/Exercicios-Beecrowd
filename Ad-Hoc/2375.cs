using System; 
class URI {
    static void Main(string[] args) { 
        int diametro=int.Parse(Console.ReadLine());
        string[] input=Console.ReadLine().Split();
        int[] tamanho=Array.ConvertAll(input,int.Parse);
        string cabe="S";
        for(int i=0; i<3; i++){
            if(diametro>tamanho[i]){
                cabe="N";
                break;
            }
        }
        Console.WriteLine(cabe);
    }
}