using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int r,q;
        if(a>=0){
            r=a%b;
            q=(int)a/b;
        }
        else{
            int x=0, y=0;
            if(b<0){
                x=b*-1;
            }
            else{
                x=b;
            }
            for(r=0; r<x; r++){
                y=a-r;
                if(y%b==0){
                    break;
                }
            }
            q=y/b;
        }
        Console.WriteLine("{0} {1}",q,r);
    }
}