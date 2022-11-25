using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int c=int.Parse(input[2]);
        if(a>b){
            if(b>c){
                if((b-c)<(a-b)){
                    Console.WriteLine(":)");
                }
                else{
                    Console.WriteLine(":(");
                }
            }
            else{
                Console.WriteLine(":)");
            }
        }
        else if(b>a){
            if(c>b){
                if((c-b)<(b-a)){
                    Console.WriteLine(":(");
                }
                else{
                    Console.WriteLine(":)");
                }
            }
            else{
                Console.WriteLine(":(");
            }
        }
        else{
            if(c>b){
                Console.WriteLine(":)");
            }
            else{
                Console.WriteLine(":(");
            }
        }
    }
}