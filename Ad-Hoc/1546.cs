using System; 
class URI {
    static void Main(string[] args) { 
        int casos=int.Parse(Console.ReadLine());
        for(int i=0; i<casos; i++){
            int nfeedbacks=int.Parse(Console.ReadLine());
            for(int j=0; j<nfeedbacks; j++){
                int categoria=int.Parse(Console.ReadLine());
                if(categoria==1){
                    Console.WriteLine("Rolien");
                }
                else if(categoria==2){
                    Console.WriteLine("Naej");
                }
                else if(categoria==3){
                    Console.WriteLine("Elehcim");
                }
                else if(categoria==4){
                    Console.WriteLine("Odranoel");
                }
            }
        }
    }
}