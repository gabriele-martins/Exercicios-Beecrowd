using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada,int.Parse);
        int esquerdo=valores[0]*valores[1];
        int direito=valores[2]*valores[3];
        if(esquerdo==direito){
            Console.WriteLine(0);
        }
        else if(esquerdo>direito){
            Console.WriteLine(-1);
        }
        else{
            Console.WriteLine(1);
        }
    }
}