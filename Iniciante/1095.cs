using System; 
class URI {
    static void Main(string[] args) { 
        int I=1, J=60;
        for(int i=0; i<13; i++){
            Console.WriteLine("I={0} J={1}",I,J);
            I+=3;
            J-=5;
        }
    }
}