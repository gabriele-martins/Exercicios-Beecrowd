using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        for(int i=0; i<n; i++){
            string[] entrada=Console.ReadLine().Split();
            int a=int.Parse(entrada[0]);
            int b=int.Parse(entrada[1]);
            int sonares=(a/3)*(b/3);
            Console.WriteLine(sonares);
        }            
    }
}