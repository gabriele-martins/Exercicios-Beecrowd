using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int x=int.Parse(input[0]);
        int y=int.Parse(input[1]);
        if(x>=0 && x<=432 && y>=0 && y<=468){
            Console.WriteLine("dentro");
        }
        else{
            Console.WriteLine("fora");
        }
    }
}