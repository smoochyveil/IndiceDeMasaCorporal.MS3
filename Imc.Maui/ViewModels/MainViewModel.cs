using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Imc.models;


namespace Imc.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _altura;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]        
        private string _estadoNutricional;

        public MainViewModel()
        {
            Limpiar();
        }
        [RelayCommand]
        private void Calcular()
        {
            decimal peso;
            decimal altura;
            bool pesoEsValido = decimal.TryParse(Peso, out peso);
            bool alturaEsValida = decimal.TryParse(Altura, out altura);
            if (pesoEsValido && alturaEsValida)
            {
                decimal imc = CalculadoraImc.
                IndiceDeMasaCorporal(peso, altura);
                Imc = imc.ToString("f4");
                EstadoNutricional = CalculadoraImc
                    .EstadoNutricional(imc);
            }
            
        }
        [RelayCommand]
        private void Limpiar()
        {
            Peso = string.Empty;
            Altura = string.Empty;
            Imc = string.Empty;
            EstadoNutricional = string.Empty;
        }
    }
}
