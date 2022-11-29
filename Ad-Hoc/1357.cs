using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        while(entrada[0]!="0" && entrada[1]!="0" && entrada[2]!="0"){
            int l=int.Parse(entrada[0]);
            int c=int.Parse(entrada[1]);
            int p=int.Parse(entrada[2]);
            int[,] matriz=new int[l,c];
            int aux=0;
            for(int i=0; i<l; i++){
                string[] entrada1=Console.ReadLine().Split();
                for(int j=0; j<c; j++){
                    matriz[i,j]=int.Parse(entrada1[j]);
                }
            }
            for(int i=0; i<l; i++){
                int esquerda=0, direita=0;
                for(int j=0; j<p; j++){
                    if(matriz[i,j]!=0){
                        esquerda=matriz[i,j];
                    }
                }
                for(int j=p; j<c; j++){
                    if(matriz[i,j]!=0){
                        direita=matriz[i,j];
                        break;
                    }
                }
                p+=(esquerda-direita);
                if(matriz[i,p-1]!=0){
                    Console.WriteLine("BOOM {0} {1}",i+1,p);
                    aux=1;
                    break;
                }
            }
            if(aux==0){
                Console.WriteLine("OUT {0}",p);
            }
            entrada=Console.ReadLine().Split();
        }
    }
}