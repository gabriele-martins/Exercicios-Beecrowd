using System;
using System.Linq; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int[,] matriz=new int[n,n];
            int cont=1;
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    matriz[i,j]=cont;
                    cont+=cont;
                }
                cont=(int)Math.Pow(2.0,i+1);
            }
            string maior=(matriz.Cast<int>().Max()).ToString();
            int maior_int=Convert.ToInt32(maior.Length);
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    if(j==0){
                        Console.Write(matriz[i,j].ToString().PadLeft(maior_int));
                    }
                    else{
                        Console.Write(" {0}",matriz[i,j].ToString().PadLeft(maior_int));
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            n=int.Parse(Console.ReadLine());
        }
    }
}