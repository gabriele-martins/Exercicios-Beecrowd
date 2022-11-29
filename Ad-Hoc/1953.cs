using System; 
class URI {
    static void Main(string[] args) { 
        string entrada=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(entrada)){
                break;
            }
            else{
                int n=int.Parse(entrada);
                int epr=0, ehd=0, intrusos=0;
                for(int i=0; i<n; i++){
                    string[] entrada2=Console.ReadLine().Split();
                    if(entrada2[1]=="EPR"){
                        epr++;
                    }
                    else if(entrada2[1]=="EHD"){
                        ehd++;
                    }
                    else{
                        intrusos++;
                    }
                }
                Console.WriteLine("EPR: {0}",epr);
                Console.WriteLine("EHD: {0}",ehd);
                Console.WriteLine("INTRUSOS: {0}",intrusos);
                entrada=Console.ReadLine();
            }
        }
    }
}