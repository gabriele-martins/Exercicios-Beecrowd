using System;
class URI {
    static void Main(string[] args) { 
        int[] valores=new int[15];
        int[] par=new int[5];
        int[] impar=new int[5];
        int contPar=0, contImpar=0;
        for(int i=0; i<15; i++){
            valores[i]=int.Parse(Console.ReadLine());
            if(valores[i]%2==0){
                par[contPar]=valores[i];
                contPar++;
                if(contPar==5){
                    for(int j=0; j<5; j++){
                        Console.WriteLine("par[{0}] = {1}", j, par[j]);
                    }
                    contPar=0;
                    Array.Clear(par,0,5);
                }
            }
            else{
                impar[contImpar]=valores[i];
                contImpar++;
                if(contImpar==5){
                    for(int j=0; j<5; j++){
                        Console.WriteLine("impar[{0}] = {1}", j, impar[j]);
                    }
                    contImpar=0;
                    Array.Clear(impar,0,5);
                }
            }
        }
        for(int i=0; i<contImpar; i++){
            Console.WriteLine("impar[{0}] = {1}", i, impar[i]);
        }
        for(int i=0; i<contPar; i++){
            Console.WriteLine("par[{0}] = {1}", i, par[i]);
        }
    }
}