using System; 
class URI {
    static void Main(string[] args) {
        double soma=0, input;
        int aux=0, input1;
        do{
            aux=0; 
            soma=0;
            while(aux<2){
                input=double.Parse(Console.ReadLine());
                if(input>=0.0 && input<=10.0){
                    soma+=input;
                    aux+=1;
                }
                else{
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine("media = {0:F2}",soma/2);
            do{
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                input1=int.Parse(Console.ReadLine());
            } while(input1<1|input1>2);
        } while(input1==1);   
    }
}