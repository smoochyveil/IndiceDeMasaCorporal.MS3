
using Imc.Maui.models;

namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ImcLabel.Text = string.Empty;
        EstadoNutricionalLabel.Text = string.Empty;
    }

    private void OnCalcularButtonClicked(object sender, EventArgs e)
    {
        try
        {
            decimal peso = decimal.Parse(PesoEntry.Text);
            decimal altura = decimal.Parse(AlturaEntry.Text);
            decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, altura);
            ImcLabel.Text = imc.ToString("f4");
            EstadoNutricionalLabel.Text = CalculadoraImc.EstadoNutricional(imc);

        }
        catch (Exception)
        {
            throw;
        }
    }
    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
       PesoEntry.Text = string.Empty;
        AlturaEntry.Text = string.Empty;
        ImcLabel.Text = string.Empty;
        EstadoNutricionalLabel.Text = string.Empty;

    }
}