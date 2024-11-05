using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class sobre : ContentPage
{
	public sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}