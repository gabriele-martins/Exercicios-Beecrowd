using System; 
class URI {
    static void Main(string[] args) { 
        int I_valor=1, J_valor=7;
        for(int i=0; i<5; i++){
            for(int j=0; j<3; j++){
                Console.WriteLine("I={0} J={1}",I_valor,J_valor);
                J_valor-=1;    
            }
            I_valor+=2;
            J_valor+=5;
        }
    }
}