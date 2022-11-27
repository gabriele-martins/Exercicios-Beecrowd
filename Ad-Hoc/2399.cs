using System; 
using System.Collections.Generic;
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        List<int> tabuleiro=new List<int>(n+1);
        int[] minas=new int[n];
        for(int i=0; i<n; i++){
            tabuleiro.Add(int.Parse(Console.ReadLine()));
            minas[i]=0;
        }
        tabuleiro.Add(0);
        if(tabuleiro[0]==1){
            minas[0]++;
        }
        if(tabuleiro[1]==1){
            minas[0]++;
        }
        for(int i=1; i<n; i++){
            if(tabuleiro[i]==1){
                minas[i]++;
            }
            if(tabuleiro[i-1]==1){
                minas[i]++;
            }
            if(tabuleiro[i+1]==1){
                minas[i]++;
            }
        }
        for(int i=0; i<n; i++){
            Console.WriteLine(minas[i]);
        }
    }
}