using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            string[] entrada_str=Console.ReadLine().Split();
            int[] entrada=Array.ConvertAll(entrada_str, int.Parse);
            int ativa=10;
            for(int i=0; i<n-1; i++){
                if(entrada[i]+10<entrada[i+1]){
                    ativa+=10;
                }
                else{
                    ativa+=10-(entrada[i]+10-entrada[i+1]);
                }
            }
            Console.WriteLine(ativa);
            n=int.Parse(Console.ReadLine());
        }
    }
}