// See https://aka.ms/new-console-template for more information
using Spectre.Console;

Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░███╗░░░███╗░█████╗░███████╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗████╗░████║██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██╔████╔██║██║░░██║█████╗░░██║░░██║███████║╚█████╗░
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║╚██╔╝██║██║░░██║██╔══╝░░██║░░██║██╔══██║░╚═══██╗
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██║░╚═╝░██║╚█████╔╝███████╗██████╔╝██║░░██║██████╔╝
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░╚══════╝╚═════╝░╚═╝░░╚═╝╚═════╝░");


string moeda25, moeda50, moeda1;
float Convertmoeda25, Convertmoeda50, Convertmoeda1, soma;

Console.WriteLine("\n\nDigite o numero de moedas de 25 centavos:\n");
moeda25 = Console.ReadLine();
Console.WriteLine("Digite o numero de moedas de 5 centavos:\n");
moeda50 = Console.ReadLine();
Console.WriteLine("Digite o numero de moedas de 1 real\n\n");
moeda1 = Console.ReadLine();   


Convertmoeda25 = Convert.ToSingle(moeda25);
Convertmoeda50 = Convert.ToSingle(moeda50);
Convertmoeda1 = Convert.ToSingle(moeda1);



Convertmoeda25 *= 0.25f;
Convertmoeda50 *= 0.50f;
Convertmoeda1 *= 1;

soma = Convertmoeda25 + Convertmoeda50 + Convertmoeda1;



var table = new Table();
table.AddColumn("Moedas 25");
table.AddColumn("Moedas 50");
table.AddColumn("Moedas 1");
table.AddColumn("Valor total");


table.AddRow(
    Convertmoeda25.ToString(),
    Convertmoeda50.ToString(),
    Convertmoeda1.ToString(),
    soma.ToString("F2") 
);



AnsiConsole.Write(table);


Console.WriteLine("\n---------------------Você economizou: "+soma+ " Reais------------------------");



