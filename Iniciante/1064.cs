using System; 
class URI {
    static void Main(string[] args) { 
        double[] numeros=new double[6];
        int cont=0;
        double numerador=0.0, media;
        for(int i=0; i<6; i++){
            numeros[i]=double.Parse(Console.ReadLine());
        }
        for(int i=0; i<6; i++){
            if(numeros[i]>0.0){
                cont+=1;
                numerador+=numeros[i];
            }
        }
        media=numerador/cont;
        Console.WriteLine("{0} valores positivos", cont);
        Console.WriteLine("{0:F1}", media);
    }   
}