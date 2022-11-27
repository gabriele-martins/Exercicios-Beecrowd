using System; 
class URI {
    static void Main(string[] args) { 
        int testes=int.Parse(Console.ReadLine());
        while(testes!=0){
            int retangulos=0, soma=0;
            int[,] varetas=new int[testes,2];
            for(int i=0; i<testes; i++){
                string[] input=Console.ReadLine().Split();
                varetas[i,0]=int.Parse(input[0]);
                varetas[i,1]=int.Parse(input[1]);
            }
            for(int i=0; i<testes; i++){
                if(varetas[i,1]%2==0){
                    soma+=varetas[i,1];
                }
                else{
                    soma+=varetas[i,1]-1;
                }
            }
            retangulos=(int)soma/4;
            Console.WriteLine(retangulos);
            testes=int.Parse(Console.ReadLine());
        }
    }
}