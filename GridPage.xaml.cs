using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layouts;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
    }
    
    private async void OnNavigateToStackPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackPage());
    }
}