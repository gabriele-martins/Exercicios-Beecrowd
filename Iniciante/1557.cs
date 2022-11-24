using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int[,] matriz=new int[n,n];
            
            string maior=(matriz.Cast<int>().Max()).ToString();
            Console.WriteLine("Quantidade de caracteres do maior valor: {0}",maior.Length);
            int maior_int=Convert.ToInt32(maior.Length);
            
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    if(j==0){
                        Console.Write("{0,3}",matriz[i,j]);
                    }
                    else{
                        Console.Write(" {0,3}",matriz[i,j]);
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            n=int.Parse(Console.ReadLine());
        }
    }
}