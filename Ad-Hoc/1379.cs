using System; 
class URI {
    static void Main(string[] args) { 
        string[] entrada=Console.ReadLine().Split();
        while(true){
            if(entrada[0]=="0" && entrada[1]=="0"){
                break;
            }
            int a=int.Parse(entrada[0]);
            int b=int.Parse(entrada[1]);
            int media=a;
            int c=(3*media)-a-b;
            Console.WriteLine(c);
            entrada=Console.ReadLine().Split();
        }
    }
}