using System; 
using System.Collections.Generic;
using System.Linq;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        char[,] tabuleiro=new char[n,n];
        List<int> valores=new List<int>();
        for(int i=0; i<n; i++){
            char[] input=Console.ReadLine().ToCharArray();
            for(int j=0; j<n; j++){
                tabuleiro[i,j]=input[j];
            }
        }
        int soma=0;
        for(int i=0; i<n; i++){
            if(i%2==0){
                for(int j=0; j<n; j++){
                    if(tabuleiro[i,j]=='o'){
                        soma++;
                    }
                    else if(tabuleiro[i,j]=='A'){
                        valores.Add(soma);
                        soma=0;
                    }
                }
            }
            else{
                for(int k=n-1; k>=0; k--){
                    if(tabuleiro[i,k]=='o'){
                        soma++;
                    }
                    else if(tabuleiro[i,k]=='A'){
                        valores.Add(soma);
                        soma=0;
                    }
                }
            }
        }
        valores.Add(soma);
        Console.WriteLine(valores.Max());
    }
}