namespace NavigationOverlayIssue;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        else
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}

