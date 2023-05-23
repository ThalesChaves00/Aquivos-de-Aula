
internal class Program
{
    private static void Main(string[] args)
    {
         int cargo = 0;
         int funcao = 0;
         Console.WriteLine("Se for Gerente precione (1) se for Programador Precione (2)\n");
         cargo = Convert.ToInt32(Console.ReadLine());

         if (cargo == 2)
         {

            Console.WriteLine("Seja Bem vindo Programador\n");
            Console.WriteLine("Se for Junior precione(1) se for senior precione (2)!!\n");
             funcao = Convert.ToInt32(Console.ReadLine());
         }
         switch (cargo)
         {


             case 1:
                 Console.WriteLine("Seja bem Vindo Gerente\n");

                 break;

             case 2:
                 //Console.WriteLine("Seja Bem vindo Programador");

                 switch (funcao)
                 {
                     case 1:

                         Console.WriteLine("Seja bem vindo Probramador Junior!!\n");
                         break;
                     case 2:
                         Console.WriteLine("Voçe e um programador senior\n");
                         break;

                     default:
                         Console.WriteLine("Voce esolheu uma opção que nao existe!!\n");
                         break;
                 }
                 break;


             default:
                 Console.WriteLine("Não identificado\n");

                 break;
         }
     

       
        }

    }


       
        
