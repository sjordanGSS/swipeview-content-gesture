using System.Diagnostics;

namespace swipeview_content_gesture;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Debug.WriteLine("label tapped");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("button tapped");
    }
}
