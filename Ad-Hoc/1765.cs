using System; 
class URI {
    static void Main(string[] args) { 
        int n=int.Parse(Console.ReadLine());
        while(n!=0){
            for(int i=0; i<n; i++){
                string[] input=Console.ReadLine().Split();
                int quant=int.Parse(input[0]);
                double a=double.Parse(input[1]);
                double b=double.Parse(input[2]);
                double area=((a+b)*5.0)/2.0;
                Console.WriteLine("Size #{0}:",i+1);
                Console.WriteLine("Ice Cream Used: {0:F2} cm2",area*quant);
            }
            Console.Write("\n");
            n=int.Parse(Console.ReadLine());
        }
    }
}