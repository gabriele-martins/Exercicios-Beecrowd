using System;
using System.Collections.Generic;
class URI {
    static void Main(string[] args) { 
        string input;
        string[] val_str=new string[2];
        int[] val_int=new int[2];
        List<int> val=new List<int>();
        int aux=0;
        while(aux==0){
            input=Console.ReadLine();
            val_str=input.Split();
            val_int=Array.ConvertAll(val_str, int.Parse);
            if(val_int[0]==val_int[1]){
                aux=1;
            }
            else{
                val.Add(val_int[0]);
                val.Add(val_int[1]);
            }
            Array.Clear(val_str,0,2);
            Array.Clear(val_int,0,2);
        }
        for(int i=0; i<val.Count; i+=2){
            if(val[i]<val[i+1]){
                Console.WriteLine("Crescente");
            }
            else{
                Console.WriteLine("Decrescente");
            }
        }
    }
}