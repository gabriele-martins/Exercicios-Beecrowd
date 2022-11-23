using System; 
class URI {
    static void Main(string[] args) { 
        string[] input=Console.ReadLine().Split();
        int codigo=int.Parse(input[0]);
        int quantidade=int.Parse(input[1]);
        double total;
        if(codigo==1){
            total=quantidade*4.00;
            Console.WriteLine("Total: R$ {0:F2}", total);
        }
        else if(codigo==2){
            total=quantidade*4.50;
            Console.WriteLine("Total: R$ {0:F2}", total);
        }
        else if(codigo==3){
            total=quantidade*5.00;
            Console.WriteLine("Total: R$ {0:F2}", total);
        }
        else if(codigo==4){
            total=quantidade*2.00;
            Console.WriteLine("Total: R$ {0:F2}", total);
        }
        else{
            total=quantidade*1.50;
            Console.WriteLine("Total: R$ {0:F2}", total);
        }
    }
}