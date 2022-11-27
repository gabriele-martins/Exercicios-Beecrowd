using System; 
class URI {
    static void Main(string[] args) { 
        int roupas=int.Parse(Console.ReadLine());
        string[] lavadora=Console.ReadLine().Split();
        int la=int.Parse(lavadora[0]);
        int lb=int.Parse(lavadora[1]);
        string[] secadora=Console.ReadLine().Split();
        int sa=int.Parse(secadora[0]);
        int sb=int.Parse(secadora[1]);
        string uso="";
        if(roupas>=la && roupas>=sa && roupas<=lb && roupas<=sb){
            uso="possivel";
        }
        else{
            uso="impossivel";
        }
        Console.WriteLine(uso);
    }
}