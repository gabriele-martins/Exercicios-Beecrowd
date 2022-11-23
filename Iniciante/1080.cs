using System; 
class URI {
    static void Main(string[] args) { 
        int[] valores=new int[100];
        int maior=0, index=0;
        for(int i=0; i<100; i++){
            valores[i]=int.Parse(Console.ReadLine());
        }
        if(valores[1]>valores[0]){
            maior=valores[1];
        }
        else{
            maior=valores[0];
        }
        for(int i=0; i<100; i++){
            if(valores[i]>maior){
                maior=valores[i];
                index=i+1;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(index);
    }
}