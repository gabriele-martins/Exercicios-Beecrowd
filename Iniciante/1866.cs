using System; 
class URI {
    static void Main(string[] args) { 
        int c=int.Parse(Console.ReadLine());
        for(int i=0; i<c; i++){
            int n=int.Parse(Console.ReadLine());
            if(n%2==0){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(1);
            }
        }
    }
}