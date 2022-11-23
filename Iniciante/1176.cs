using System; 
class URI {
    static void Main(string[] args) { 
        int T=int.Parse(Console.ReadLine());
        int[] index=new int[T];
        for(int i=0; i<T; i++){
            index[i]=int.Parse(Console.ReadLine());
        }
        int maior=index[0];
        for(int i=0; i<T; i++){
            if(index[i]>maior){
                maior=index[i];
            }
        }
        long[] fib=new long[maior+1];
        fib[0]=0;
        fib[1]=1;
        for(int i=2; i<maior+1; i++){
            fib[i]=fib[i-1]+fib[i-2];
        }
        for(int i=0; i<T; i++){
            Console.WriteLine("Fib({0}) = {1}",index[i],fib[index[i]]);
        } 
    }
}