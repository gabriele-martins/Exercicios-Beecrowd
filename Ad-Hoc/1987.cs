using System; 
class URI {
    static void Main(string[] args) { 
        string entrada=Console.ReadLine();
        while(true){
            if(String.IsNullOrEmpty(entrada)){
                break;
            }
            else{
                string[] x=entrada.Split();
                int n=int.Parse(x[0]);
                char[] valores=x[1].ToCharArray();
                int soma=0;
                for(int i=0; i<n; i++){
                    soma+=valores[i]-'0';
                }
                if(soma%3==0){
                    Console.WriteLine("{0} sim",soma);
                }
                else{
                    Console.WriteLine("{0} nao",soma);
                }
                entrada=Console.ReadLine();
            }
        }
    }
}