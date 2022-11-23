using System; 
class URI {
    static void Main(string[] args) { 
        int N=int.Parse(Console.ReadLine());
        int cont=1;
        for(int j=0; j<N; j++){
            for(int i=0; i<4; i++){
                if(cont%4==0){
                    Console.WriteLine("PUM");
                }
                else{
                    Console.Write("{0} ",cont);
                }
                cont+=1;
            }
        }
    }
}