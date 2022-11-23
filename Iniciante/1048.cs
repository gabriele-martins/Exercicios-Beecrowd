using System; 
class URI {
    static void Main(string[] args) { 
        double valor=double.Parse(Console.ReadLine());
        double novoValor, diferenca, reajuste;
        if(valor>0.00 && valor<=400.00){
            reajuste=15;
            novoValor=valor+valor*(reajuste/100.00);
            diferenca=novoValor-valor;
            Console.WriteLine("Novo salario: {0:F2}", novoValor);
            Console.WriteLine("Reajuste ganho: {0:F2}", diferenca);
            Console.WriteLine("Em percentual: {0} %", reajuste);
        }
        else if(valor>400.00 && valor<=800.00){
            reajuste=12;
            novoValor=valor+valor*(reajuste/100.00);
            diferenca=novoValor-valor;
            Console.WriteLine("Novo salario: {0:F2}", novoValor);
            Console.WriteLine("Reajuste ganho: {0:F2}", diferenca);
            Console.WriteLine("Em percentual: {0} %", reajuste);
        }
        else if(valor>800.00 && valor<=1200.00){
            reajuste=10;
            novoValor=valor+valor*(reajuste/100.00);
            diferenca=novoValor-valor;
            Console.WriteLine("Novo salario: {0:F2}", novoValor);
            Console.WriteLine("Reajuste ganho: {0:F2}", diferenca);
            Console.WriteLine("Em percentual: {0} %", reajuste);
        }
        else if(valor>1200.00 && valor<=2000.00){
            reajuste=7;
            novoValor=valor+valor*(reajuste/100.00);
            diferenca=novoValor-valor;
            Console.WriteLine("Novo salario: {0:F2}", novoValor);
            Console.WriteLine("Reajuste ganho: {0:F2}", diferenca);
            Console.WriteLine("Em percentual: {0} %", reajuste);
        }
        else{
            reajuste=4;
            novoValor=valor+valor*(reajuste/100.00);
            diferenca=novoValor-valor;
            Console.WriteLine("Novo salario: {0:F2}", novoValor);
            Console.WriteLine("Reajuste ganho: {0:F2}", diferenca);
            Console.WriteLine("Em percentual: {0} %", reajuste);
        }
    }
}