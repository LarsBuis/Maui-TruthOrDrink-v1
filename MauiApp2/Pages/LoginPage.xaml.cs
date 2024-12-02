using MauiApp2;
using MauiApp2.TruthOrDrink;
using Microsoft.Maui.Controls;

namespace MauiApp2;

public partial class LoginPage : ContentPage
{
    // Hardcoded admin credentials
    private const string AdminUsername = "1";
    private const string AdminPassword = "1";

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        if (username == AdminUsername && password == AdminPassword)
        {
            MessageLabel.TextColor = Colors.Green;
            MessageLabel.Text = "Login successful!";
            MessageLabel.IsVisible = true;

            // Navigate to the main page or admin page
            await Navigation.PushAsync(new QuestionSelectionPage());
        }
        else
        {
            MessageLabel.TextColor = Colors.Red;
            MessageLabel.Text = "Invalid username or password.";
            MessageLabel.IsVisible = true;
        }
    }

    private void HomeToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new QuestionSelectionPage());
    }


}
