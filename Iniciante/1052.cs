using System; 
using System.Collections.Generic;
class URI {
    static void Main(string[] args) { 
        int mes=int.Parse(Console.ReadLine());
        Dictionary<int,string> meses=new Dictionary<int, string>(){
            {1,"January"},
            {2,"February"},
            {3,"March"},
            {4,"April"},
            {5,"May"},
            {6,"June"},
            {7,"July"},
            {8,"August"},
            {9,"September"},
            {10,"October"},
            {11,"November"},
            {12,"December"},
        };
        for(int i=1; i<13; i++){
            if(mes==i){
              Console.WriteLine(meses[i]);  
            }
        }
    }
}