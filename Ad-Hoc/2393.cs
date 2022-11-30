using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        int[,] plano=new int[100,100];
        for(int k=0; k<n; k++){
            string[] entrada=Console.ReadLine().Split();
            int xi=int.Parse(entrada[0]);
            int xf=int.Parse(entrada[1]);
            int yi=int.Parse(entrada[2]);
            int yf=int.Parse(entrada[3]);
            for(int i=xi; i<xf; i++){
                for(int j=yi; j<yf; j++){
                    plano[i,j]=1;
                }
            }
        }
        int areaTotal=0;
        for(int i=0; i<100; i++){
            for(int j=0; j<100; j++){
                if(plano[i,j]==1){
                    areaTotal++;
                }
            }
        }
        Console.WriteLine(areaTotal);
    }
}