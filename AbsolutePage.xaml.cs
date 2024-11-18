using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layouts;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
    }
    
    private async void OnNavigateToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }
}