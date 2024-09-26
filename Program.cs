using ExercicioNatal24_09_24;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente objCli = new Cliente("Natal", 123);
        Conta objCon = new Conta(1001, 100, objCli);


    int contador=0;
    while(contador==0){
            int opcao = 0;
            Console.WriteLine("Digite 1 para Creditar");
            Console.WriteLine("Digite 2 para Debitar");
            Console.WriteLine("Digite 3 para Mostrar Saldo");
            Console.WriteLine("Digite 0 para sair");
            opcao=Convert.ToInt16(Console.ReadLine());

            switch(opcao){
                case 1 : 
                Console.WriteLine("Digite o valor a ser creditado:");
                objCon.Creditar(Convert.ToDouble(Console.ReadLine()));
                break;
                case 2 :
                Console.WriteLine("Digite o valor a ser debitado");
                objCon.Debitar(Convert.ToDouble(Console.ReadLine()));
                break;
                case 3 :
                objCon.MostrarSaldo();
                break;
                case 0 :
                contador=1;
                break;
                default:
                Console.WriteLine("Valor inválido");
                break;
            }
        }
    }    
}