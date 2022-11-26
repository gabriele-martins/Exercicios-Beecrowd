using System; 
class URI {
    static void Main(string[] args) { 
        int k=int.Parse(Console.ReadLine());
        if(k==1){
            Console.WriteLine("Top 1");
        }
        else if(k>=2 && k<=3){
            Console.WriteLine("Top 3");
        }
        else if(k>=4 && k<=5){
            Console.WriteLine("Top 5");
        }
        else if(k>=6 && k<=10){
            Console.WriteLine("Top 10");
        }
        else if(k>=11 && k<=25){
            Console.WriteLine("Top 25");
        }
        else if(k>=26 && k<=50){
            Console.WriteLine("Top 50");
        }
        else if(k>=51 && k<=100){
            Console.WriteLine("Top 100");
        }
    }
}