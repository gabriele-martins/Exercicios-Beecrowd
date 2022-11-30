using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int[] pontos=new int[2] {0,0};
            for(int i=0; i<n; i++){
                string[] entrada=Console.ReadLine().Split();
                int[] rodada=Array.ConvertAll(entrada,int.Parse);
                if(rodada[0]>rodada[1]){
                    pontos[0]++;
                }
                else if(rodada[0]<rodada[1]){
                    pontos[1]++;
                }
            }
            Console.WriteLine("{0} {1}",pontos[0],pontos[1]);
            n=int.Parse(Console.ReadLine());
        }
    }
}