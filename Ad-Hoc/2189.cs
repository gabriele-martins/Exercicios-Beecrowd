using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int teste=1;
        while(n!=0){
            string[] input=Console.ReadLine().Split();
            int[] participantes=Array.ConvertAll(input,int.Parse);
            int ganhador=0, contador=1;
            for(int i=0; i<n; i++){
                if(participantes[i]==contador){
                    ganhador=participantes[i];
                }
                contador++;
            }
            Console.WriteLine("Teste {0}",teste);
            teste++;
            Console.WriteLine(ganhador);
            Console.WriteLine();
            n=int.Parse(Console.ReadLine());
        }
    }
}