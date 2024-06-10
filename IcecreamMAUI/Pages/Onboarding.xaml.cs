namespace IcecreamMAUI.Pages;

public partial class Onboarding : ContentPage
{
	public Onboarding()
	{
		InitializeComponent();
	}

    private async Task Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
        catch (Exception ex)
        {
            // Aqui voc� pode adicionar o c�digo para lidar com a exce��o, como logging
            Console.WriteLine($"Erro ao navegar para a HomePage: {ex.Message}");
        }
    }
}