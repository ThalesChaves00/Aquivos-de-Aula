// See https://aka.ms/new-console-template for more information

namespace didaticos.redimicionador
{
   internal class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Iniciando rediminsionador1");

            Thread thread = new Thread(Redimensionar);
            thread.Start();

            Console.Read();
             }
        static void Redimensionar()
        {
            string diretorio_entrada = "Arquivo_entrada";
            string diretorio_finalidade = "Arquivo_Finalidade";
            string diretorio_redimensionado = "Arquivo_Redimensionamento";

            if (!Directory.Exists(diretorio_entrada))
            {
                Directory.CreateDirectory(diretorio_entrada);

            }
            
            if (!Directory.Exists(diretorio_finalidade))
            {
                Directory.CreateDirectory(diretorio_finalidade);

            }
            
            if (!Directory.Exists(diretorio_redimensionado))
            {
                Directory.CreateDirectory(diretorio_redimensionado);

            }
            while (true)
            {
                Thread.Sleep(new TimeSpan(0, 0, 5));
            }



        }



    }




}



