﻿Console.WriteLine("---- Entrada Válida ----\n");

int numeroDigitado = -1;

while (numeroDigitado  < 0 || numeroDigitado > 9)
{
Console.Write("Digite um númer entre 1 e 9 (ou 0 pra cancelar)...:");
numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 0)
{
Console.WriteLine("\nOperação cancelada.");    
}
else
{
Console.WriteLine($"\nNúmero selecionado = {numeroDigitado}");    
}

Console.WriteLine("\nVolte sempre!");