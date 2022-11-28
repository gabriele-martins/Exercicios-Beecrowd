using System; 
class URI {
    static void Main(string[] args) { 
        int maior=0;
        for(int i=0; i<4; i++){
            string[] entrada=Console.ReadLine().Split();
            int[] valores=Array.ConvertAll(entrada,int.Parse);
            int soma=0;
            for(int j=0; j<7; j++){
                soma+=valores[j];
            }
            if(soma>maior){
                maior=soma;
            }
        }
        string binario=Convert.ToString(maior,2);
        Console.WriteLine("{0} = {1}",maior,binario);
    }
}