using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        char[] linha1=Console.ReadLine().ToCharArray();
        char[] linha2=Console.ReadLine().ToCharArray();
        bool aux=true;
        if(n%2==0){
            for(int i=0; i<linha1.Length; i++){
                if(linha1[i]!=linha2[i]){
                    aux=false;
                    break;
                }
            }
            if(aux){
                Console.WriteLine("Deletion succeeded");
            }
            else{
                Console.WriteLine("Deletion failed");
            }
        }
        else{
            for(int i=0; i<linha1.Length; i++){
                if(linha1[i]==linha2[i]){
                    aux=false;
                    break;
                }
            }
            if(aux){
                Console.WriteLine("Deletion succeeded");
            }
            else{
                Console.WriteLine("Deletion failed");
            }
        }
    }
}