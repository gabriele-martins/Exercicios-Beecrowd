using System;
class URI {
    static void Main(string[] args) { 
        int grenais=0, novo=1, vit_inter=0, vit_gremio=0, empates=0;
        string[] input=new string[2];
        int[] gols=new int[2];
        do{
            input=Console.ReadLine().Split();
            gols=Array.ConvertAll(input, int.Parse);
            if(gols[0]>gols[1]){
                vit_inter+=1;
            }
            else if(gols[0]<gols[1]){
                vit_gremio+=1;
            }
            else{
                empates+=1;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novo=int.Parse(Console.ReadLine());
            grenais+=1;
        }while(novo==1);
        Console.WriteLine("{0} grenais", grenais);
        Console.WriteLine("Inter:{0}", vit_inter);
        Console.WriteLine("Gremio:{0}", vit_gremio);
        Console.WriteLine("Empates:{0}", empates);
        if(vit_inter>vit_gremio){
            Console.WriteLine("Inter venceu mais");
        }
        else if(vit_inter<vit_gremio){
            Console.WriteLine("Gremio venceu mais");
        }
        else{
            Console.WriteLine("Nao houve vencedor");
        }
    }
}