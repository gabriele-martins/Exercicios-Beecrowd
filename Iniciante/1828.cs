using System; 
class URI {
    static void Main(string[] args) { 
        int t=int.Parse(Console.ReadLine());
        for(int i=0; i<t; i++){
            string[] jogo=Console.ReadLine().Split();
            if(jogo[0]=="pedra"){
                if(jogo[1]=="pedra"){
                    Console.WriteLine("Caso #{0}: De novo!",i+1);
                }
                else if(jogo[1]=="lagarto" || jogo[1]=="tesoura"){
                    Console.WriteLine("Caso #{0}: Bazinga!",i+1);
                }
                else{
                    Console.WriteLine("Caso #{0}: Raj trapaceou!",i+1);
                }
            }
            else if(jogo[0]=="papel"){
                if(jogo[1]=="papel"){
                    Console.WriteLine("Caso #{0}: De novo!",i+1);
                }
                else if(jogo[1]=="pedra" || jogo[1]=="Spock"){
                    Console.WriteLine("Caso #{0}: Bazinga!",i+1);
                }
                else{
                    Console.WriteLine("Caso #{0}: Raj trapaceou!",i+1);
                }
            }
            else if(jogo[0]=="tesoura"){
                if(jogo[1]=="tesoura"){
                    Console.WriteLine("Caso #{0}: De novo!",i+1);
                }
                else if(jogo[1]=="papel" || jogo[1]=="lagarto"){
                    Console.WriteLine("Caso #{0}: Bazinga!",i+1);
                }
                else{
                    Console.WriteLine("Caso #{0}: Raj trapaceou!",i+1);
                }
            }
            else if(jogo[0]=="lagarto"){
                if(jogo[1]=="lagarto"){
                    Console.WriteLine("Caso #{0}: De novo!",i+1);
                }
                else if(jogo[1]=="papel" || jogo[1]=="Spock"){
                    Console.WriteLine("Caso #{0}: Bazinga!",i+1);
                }
                else{
                    Console.WriteLine("Caso #{0}: Raj trapaceou!",i+1);
                }
            }
            else{
                if(jogo[1]=="Spock"){
                    Console.WriteLine("Caso #{0}: De novo!",i+1);
                }
                else if(jogo[1]=="tesoura" || jogo[1]=="pedra"){
                    Console.WriteLine("Caso #{0}: Bazinga!",i+1);
                }
                else{
                    Console.WriteLine("Caso #{0}: Raj trapaceou!",i+1);
                }
            }
        }
    }
}