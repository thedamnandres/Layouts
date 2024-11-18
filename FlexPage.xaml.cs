using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layouts;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }
    
    private async void OnImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsolutePage());
    }
}