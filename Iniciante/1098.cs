using System; 
class URI {
    static void Main(string[] args) { 
        double I_valor=0, J_valor=1;
        for(int i=0; I_valor<=2; i++){
            for(int j=0; j<3; j++){
                Console.WriteLine("I={0} J={1}",I_valor,J_valor);
                J_valor+=1;    
            }
            I_valor+=0.2;
            J_valor=1+I_valor;
        }
    }
}