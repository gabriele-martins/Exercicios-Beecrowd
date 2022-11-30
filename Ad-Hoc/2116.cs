using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        int n=int.Parse(entrada[0]);
        int m=int.Parse(entrada[1]);
        int p1=0,p2=0;
        for(int i=n; i>1; i--){
            for(int j=2; j<i; j++){
                if(i%j==0){
                    p1=0;
                    break;
                }
                else{
                    p1=i;
                }
            }
            if(p1!=0){
                break;
            }
        }
        for(int i=m; i>1; i--){
            for(int j=2; j<i; j++){
                if(i%j==0){
                    p2=0;
                    break;
                }
                else{
                    p2=i;
                }
            }
            if(p2!=0){
                break;
            }
        }
        Console.WriteLine(p1*p2);
    }
}