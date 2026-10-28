using Imc.models;
using System;

Console.WriteLine("Aplicación que calcula el índice de masa corporal de una persona");
Console.WriteLine();

decimal peso = ReadDecimal("Ingrese el peso de la persona en kilogramos: ");
decimal estatura = ReadDecimal("Ingrese la estatura de la persona en metros: ");

decimal imc = CalculadoraImc
    .IndiceDeMasaCorporal(peso, estatura);

var estadoNutricional = CalculadoraImc
    .EstadoNutricional(imc);

Console.WriteLine();
Console.WriteLine($"El índice de masa corporal de la persona es: {imc:F2}");
Console.WriteLine($"El estado nutricional de la persona es: {estadoNutricional}");

static decimal ReadDecimal(string indicacion)
{
    string? entrada;
    bool entradaEsValida;
    decimal valor;

    do
    {
        Console.Write(indicacion);
        entrada = Console.ReadLine();

        entradaEsValida = decimal.TryParse(entrada, out valor);

        if (!entradaEsValida)
        {
            Console.WriteLine("Error: ingrese un valor numérico.");
            entradaEsValida = false;
        }

    } while (!entradaEsValida);

    return valor;
}
