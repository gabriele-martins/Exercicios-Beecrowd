using System; 
class URI {
    static void Main(string[] args) { 
        int T=int.Parse(Console.ReadLine());
        string[] val_str=new string[4];
        int[] pop=new int[2];
        double[] taxa=new double[2];
        int anos=0;
        for(int i=0; i<T; i++){
            val_str=Console.ReadLine().Split();
            pop[0]=int.Parse(val_str[0]);
            pop[1]=int.Parse(val_str[1]);
            taxa[0]=double.Parse(val_str[2]);
            taxa[1]=double.Parse(val_str[3]);
            while(pop[1]>=pop[0]){
                pop[0]=(int)(pop[0]+pop[0]*(taxa[0]/100.0));
                pop[1]=(int)(pop[1]+pop[1]*(taxa[1]/100.0));
                anos+=1;
                if(anos>100){
                    pop[0]=pop[1]+1;
                }
            }
            if(anos>100){
                Console.WriteLine("Mais de 1 seculo.");
            }
            else{
                Console.WriteLine("{0} anos.", anos);
            }
            Array.Clear(val_str,0,4);
            Array.Clear(pop,0,2);
            Array.Clear(taxa,0,2);
            anos=0;
        }
    }
}