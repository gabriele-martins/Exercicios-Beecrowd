using System; 
class URI {
    static void Main(string[] args) { 
        double[] numeros=new double[6];
        int cont=0;
        for(int i=0; i<6; i++){
            numeros[i]=double.Parse(Console.ReadLine());
            if(numeros[i]>0.0){
                cont+=1;
            }
        }
        Console.WriteLine("{0} valores positivos", cont);
    }   
}