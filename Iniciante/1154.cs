using System;
using System.Collections.Generic;
class URI {
    static void Main(string[] args) { 
        int idade=int.Parse(Console.ReadLine());
        double cont=0.0, media;
        int soma=0;
        List<int> idades=new List<int>();
        idades.Add(idade);
        while(idade>0){
            idade=int.Parse(Console.ReadLine());
            idades.Add(idade);
            cont+=1.0;
        }
        for(int i=0; i<idades.Count-1; i++){
            soma+=idades[i];
        }
        media=soma/cont;
        Console.WriteLine("{0:F2}",media);
    }
}