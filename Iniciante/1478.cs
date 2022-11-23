using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int[,] matriz=new int[n,n];
            int a,b;
            for(int i=0; i<n; i++){
                a=i+1;
                b=2;
                for(int j=0; j<=i; j++){
                    matriz[i,j]=a;
                    a--;
                }
                for(int j=i+1; j<n; j++){
                    matriz[i,j]=b;
                    b++;
                }
            }
            for(int i=0; i<n; i++){
                for(int j=0; j<n; j++){
                    if(j==0){
                        Console.Write("{0,3}",matriz[i,j]);
                    }
                    else{
                        Console.Write(" {0,3}",matriz[i,j]);
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            n=int.Parse(Console.ReadLine());
        }
    }
}