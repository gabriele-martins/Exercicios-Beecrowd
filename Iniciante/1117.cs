using System; 
class URI {
    static void Main(string[] args) {
        double soma=0, input;
        int aux=0;
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
    }
}