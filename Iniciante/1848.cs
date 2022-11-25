using System; 
class URI {
    static void Main(string[] args) { 
        string input=Console.ReadLine();
        int gritos=0, soma=0;
        while(true){
            if(input=="caw caw"){
                gritos++;
                Console.WriteLine(soma);
                soma=0;
            }
            if(gritos==3){
                break;
            }
            if(input=="--*"){
                soma+=1;
            }
            else if(input=="-*-"){
                soma+=2;
            }
            else if(input=="-**"){
                soma+=3;
            }
            else if(input=="*--"){
                soma+=4;
            }
            else if(input=="*-*"){
                soma+=5;
            }
            else if(input=="**-"){
                soma+=6;
            }
            else if(input=="***"){
                soma+=7;
            }
            input=Console.ReadLine();
        }
    }
}