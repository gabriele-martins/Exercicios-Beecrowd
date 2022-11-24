using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        while(true){
            if(input=="0"){
                break;
            }
            else{
                string[] input_vet=input.Split();
                int a=int.Parse(input_vet[0]);
                int b=int.Parse(input_vet[1]);
                int c=int.Parse(input_vet[2]);
                int area_casa=a*b;
                double area_terreno=Convert.ToDouble(area_casa*100)/Convert.ToDouble(c);
                double lado_terreno=Math.Sqrt(area_terreno);
                Console.WriteLine(Math.Truncate(lado_terreno));
            }
            input=Console.ReadLine();
        }
    }
}