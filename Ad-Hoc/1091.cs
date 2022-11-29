using System; 
class URI {
    static void Main(string[] args) { 
        int k=int.Parse(Console.ReadLine());
        while(k!=0){
            string[] entrada1=Console.ReadLine().Split();
            int[] divisor=Array.ConvertAll(entrada1,int.Parse);
            for(int i=0; i<k; i++){
                string[] entrada2=Console.ReadLine().Split();
                int[] coordenadas=Array.ConvertAll(entrada2,int.Parse);
                if(coordenadas[0]==divisor[0] || coordenadas[1]==divisor[1]){
                    Console.WriteLine("divisa");
                }
                else if(coordenadas[0]>divisor[0] && coordenadas[1]>divisor[1]){
                    Console.WriteLine("NE");
                }
                else if(coordenadas[0]<divisor[0] && coordenadas[1]>divisor[1]){
                    Console.WriteLine("NO");
                }
                else if(coordenadas[0]>divisor[0] && coordenadas[1]<divisor[1]){
                    Console.WriteLine("SE");
                }
                else if(coordenadas[0]<divisor[0] && coordenadas[1]<divisor[1]){
                    Console.WriteLine("SO");
                }
            }
            k=int.Parse(Console.ReadLine());
        }
    }
}