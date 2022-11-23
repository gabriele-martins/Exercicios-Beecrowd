using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(input==String.Empty){
                break;
            }
            int n=int.Parse(input);
            int[,] matriz=new int[n,n];
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    matriz[i,j]=3;
                    if(j==i){
                        matriz[i,j]=1;
                    }
                    if(i+j==n-1){
                        matriz[i,j]=2;
                    }
                }
            }
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    Console.Write(matriz[i,j]);
                }
                Console.Write("\n");
            }
            input=Console.ReadLine();
        }
    }
}