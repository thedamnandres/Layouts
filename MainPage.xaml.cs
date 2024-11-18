namespace Layouts;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToGridPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }
}