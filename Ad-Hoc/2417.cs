using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int[] valores=Array.ConvertAll(entrada,int.Parse);
        int pontosC=valores[0]*3+valores[1];
        int pontosF=valores[3]*3+valores[4];
        if(pontosC>pontosF){
            Console.WriteLine("C");    
        }
        else if(pontosF>pontosC){
            Console.WriteLine("F");
        }
        else{
            if(valores[2]>valores[5]){
                Console.WriteLine("C"); 
            }
            else if(valores[5]>valores[2]){
                Console.WriteLine("F");
            }
            else{
                Console.WriteLine("=");
            }
        }
    }
}