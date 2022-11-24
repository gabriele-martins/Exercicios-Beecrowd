using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(string.IsNullOrEmpty(input)){
                break;
            }
            int n=int.Parse(input);
            if(n==0){
                Console.WriteLine("vai ter copa!");
            }
            else{
                Console.WriteLine("vai ter duas!");
            }
            input=Console.ReadLine();
        }
    }
}