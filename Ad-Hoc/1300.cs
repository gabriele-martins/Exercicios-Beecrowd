using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(input)){
                break;
            }
            else{
                int n=int.Parse(input);
                if(n%6==0){
                    Console.WriteLine("Y");
                }
                else{
                    Console.WriteLine("N");
                }
            }
            input=Console.ReadLine();
        }
    }
}