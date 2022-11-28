using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            int fink=0;
            for(int i=1; fink+i<=n; i++){
                fink+=i;
            }
            int picapau=n-fink;
            Console.WriteLine("{0} {1}",fink,picapau);
            n=int.Parse(Console.ReadLine());
        }
    }
}