// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira nota do aluno:\t");

var nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine("Aluno Aprovado!!");

}
else if (nota < 9 && nota >= 6)
{
    Console.WriteLine("Aluno de Recuperação!!");
}
else if(nota < 6)
{
    Console.WriteLine("Aluno reprovado");
}