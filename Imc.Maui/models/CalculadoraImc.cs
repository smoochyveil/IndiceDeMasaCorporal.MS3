using System;
using System.Collections.Generic;
using System.Text;

namespace Imc.Maui.models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(
            decimal peso,
            decimal altura)
        {
            return peso / (altura * altura);
        }
        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Bajo peso";
            }
             if (imc < 25m)
            {
                return "Normal";
            }
             if (imc < 30m)
            {
                return "Sobrepeso";
            }
            if (imc < 40m)
            {
                return "Obesidad";
            }
            return "Obesidad";
        } 
        }
    }

