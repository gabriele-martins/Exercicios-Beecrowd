using System; 
class URI {
    static void Main(string[] args) { 
        int[] numeros=new int[5];
        int par=0,impar=0,neg=0,pos=0;
        for(int i=0; i<5; i++){
            numeros[i]=int.Parse(Console.ReadLine());
            if(numeros[i]%2==0){
                par+=1;
            }
            else{
                impar+=1;
            }
            if(numeros[i]>0){
                pos+=1;
            }
            else if(numeros[i]<0){
                neg+=1;
            }
        }
        Console.WriteLine("{0} valor(es) par(es)",par);
        Console.WriteLine("{0} valor(es) impar(es)",impar);
        Console.WriteLine("{0} valor(es) positivo(s)",pos);
        Console.WriteLine("{0} valor(es) negativo(s)",neg);
    }
}