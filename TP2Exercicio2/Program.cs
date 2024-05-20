namespace TP2Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com intervalo inferior: ");
            int intervaloInferior = int.Parse(Console.ReadLine());

            
            Console.Write("Entre com intervalo superior: ");
            int intervaloSuperior = int.Parse(Console.ReadLine());

            
            int somaPares = 0;
            int somaImpares = 0;

            
            for (int i = intervaloInferior; i <= intervaloSuperior; i++)
            {
                if (i % 2 == 0) 
                {
                    somaPares += i;
                }
                else 
                {
                    somaImpares += i;
                }
            }

           
            Console.WriteLine("Soma de pares = " + somaPares);
            Console.WriteLine("Soma dos ímpares = " + somaImpares);
        }
    }
}

