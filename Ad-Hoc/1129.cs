using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            for(int i=0; i<n; i++){
                string[] entrada=Console.ReadLine().Split();
                int[] valores=Array.ConvertAll(entrada,int.Parse);
                string[] alternativas=new string[5] {"A","B","C","D","E"};
                int aux=0;
                string nota="";
                for(int j=0; j<5; j++){
                    if(valores[j]<=127){
                        aux++;
                        nota=alternativas[j];
                    }
                }
                if(aux!=1){
                    Console.WriteLine("*");
                }
                else{
                    Console.WriteLine(nota);
                }
            }
            n=int.Parse(Console.ReadLine());
        }
    }
}