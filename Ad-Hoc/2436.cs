using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada1=Console.ReadLine().Split();
        int l=int.Parse(entrada1[0]);
        int c=int.Parse(entrada1[1]);
        string[] entrada2=Console.ReadLine().Split();
        int a=int.Parse(entrada2[0]);
        int b=int.Parse(entrada2[1]);
        int[,] matriz=new int[l+2,c+2];
        int quantVizinhos=0, aux=0;
        for(int i=0; i<=l+1; i++){
            matriz[i,0]=0;
            matriz[i,c+1]=0;
        }
        for(int j=0; j<=c+1; j++){
            matriz[0,j]=0;
            matriz[l+1,j]=0;
        }
        for(int i=1; i<=l; i++){
            string[] entrada3=Console.ReadLine().Split();
            for(int j=1; j<=c; j++){
                matriz[i,j]=int.Parse(entrada3[aux]);
                aux++;
            }
            aux=0;
        }
        for(int i=1; i<=l; i++){
            for(int j=1; j<=c; j++){
                if(matriz[i,j]==0){
                    continue;
                }
                else{
                    quantVizinhos=matriz[i+1,j]+matriz[i-1,j]+matriz[i,j+1]+matriz[i,j-1];
                    if(quantVizinhos==1 && (i!=a || j!=b)){
                        Console.WriteLine("{0} {1}",i,j);
                    }
                }
            }
        }
    }
}