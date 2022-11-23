using System; 
class URI {
    static void Main(string[] args) { 
        int[] N=new int[20];
        int cont=19, aux;
        for(int i=0; i<20; i++){
            N[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0; i<10; i++){
            aux=N[i];
            N[i]=N[cont];
            N[cont]=aux;
            cont-=1;
        }
        for(int i=0; i<20; i++){
            Console.WriteLine("N[{0}] = {1}",i,N[i]);
        }
    }
}