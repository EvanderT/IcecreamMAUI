namespace IcecreamMAUI.Pages;

public partial class Onboarding : ContentPage
{
    public Onboarding()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}