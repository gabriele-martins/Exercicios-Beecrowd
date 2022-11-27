using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        for(int i=0; i<n; i++){
            int registro=int.Parse(Console.ReadLine());
            registro++;
            string ataque="No";
            bool primo=true;
            for(int j=2; j<registro+2; j++){
                if((registro+2)%j==0){
                    primo=false;
                }
            }
            if(registro%7==0){
                if(registro%2==1){
                    if(primo){
                        ataque="Yes";
                    }
                }
            }
            Console.WriteLine(ataque);
        }
    }
}