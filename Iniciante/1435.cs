using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int[,] matriz=new int[n,n];
            int centrais=(int)n/2;
            if(n%2==1){
                centrais++;
            }
            int a=0, b=n-1;
            for(int l=1; l<=centrais; l++){
                for(int i=a; i<=b; i++){
                    for(int j=a; j<=b; j++){
                        matriz[i,j]=l;
                    }
                }
                a++;
                b--;
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