using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada,int.Parse);
        if(valores[1]-valores[2]-valores[3]>=valores[0]+1){
            Console.WriteLine("Igor feliz!");
        }
        else if(valores[2]>valores[3]/2){
            Console.WriteLine("Caio, a culpa eh sua!");
        }
        else{
            Console.WriteLine("Igor bolado!");
        }
    }
}