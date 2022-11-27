using System; 
class URI {
    static void Main(string[] args) { 
        string[] input1=Console.ReadLine().Split();
        string[] input2=Console.ReadLine().Split();
        double tempo1=(double.Parse(input1[1])/1000.0)/double.Parse(input1[2]);
        double tempo2=(double.Parse(input2[1])/1000.0)/double.Parse(input2[2]);
        if(tempo1<tempo2){
            Console.WriteLine(input1[0]);
        }
        else{
            Console.WriteLine(input2[0]);
        }
    }
}