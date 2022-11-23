using System; 
class URI {
    static void Main(string[] args) { 
        int T=int.Parse(Console.ReadLine());
        int[] N=new int[1000];
        int cont=0;
        for(int i=0; i<1000; i++){
            N[i]=cont;
            cont+=1;
            if(cont==T){
                cont=0;
            }
        }
        for(int i=0; i<1000; i++){
            Console.WriteLine("N[{0}] = {1}",i,N[i]);
        }
    }
}