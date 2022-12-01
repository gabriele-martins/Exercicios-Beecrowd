using System; 
class URI {
    static void Main(string[] args) { 
        int[] numeros=new int[5];
        int cont=0;
        for(int i=0; i<5; i++){
            numeros[i]=-1*(int.Parse(Console.ReadLine()));
            if(numeros[i]%2==0){
                cont+=1;
            }
        }
        Console.WriteLine("{0} valores pares",cont);
    }
}