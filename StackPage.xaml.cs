using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layouts;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }
    
    private async void OnNavigateToFlexPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexPage());
    }
}