// See https://aka.ms/new-console-template for more information
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;

Console.WriteLine("Programa Para saber saber qual mês tem 30 , 31 ou 28 dias.\n");
Console.WriteLine("Digite um Mês:\n");

var mes = Console.ReadLine().ToLower() ;

switch (mes)
{
    case "janeiro":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":

        Console.WriteLine("\nEste mes tem 31 dias!!\n");

        break;
    case "fevereiro":

        Console.WriteLine("\nEsse mes tem 28 dias\n");
        break;

    default: Console.WriteLine("\nEsse mes tem 30 dias\n");

        break;
}
