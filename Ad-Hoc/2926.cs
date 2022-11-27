using System; 
class URI {
    static void Main(string[] args) { 
        int intensidade=int.Parse(Console.ReadLine());
        string a="";
        for(int i=0; i<intensidade; i++){
            a+="a";
        }
        Console.WriteLine("Ent{0}o eh N{1}t{2}l!",a,a,a);
    }
}