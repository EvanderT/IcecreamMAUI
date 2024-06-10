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
            // Aqui você pode adicionar o código para lidar com a exceção, como logging
            Console.WriteLine($"Erro ao navegar para a HomePage: {ex.Message}");
        }
    }
}