Console.WriteLine("pesso que escreva sua idade para confirmar a doação de sangue");

int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Doação de sangue confirmada");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("sua doação de sangue foi recusada, idade invalida");
}
Console.ResetColor();