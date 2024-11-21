using MauiApp2;
using MauiApp2.TruthOrDrink;
using Microsoft.Maui.Controls;

namespace MauiApp2;

public partial class LoginPage : ContentPage
{
    // Hardcoded admin credentials
    private const string AdminUsername = "admin";
    private const string AdminPassword = "admin";

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        if (username == AdminUsername && password == AdminPassword)
        {
            MessageLabel.TextColor = Colors.Green;
            MessageLabel.Text = "Login successful!";
            MessageLabel.IsVisible = true;

            // Navigate to the main page or admin page
            Navigation.PushAsync(new GamePage());
        }
        else
        {
            MessageLabel.TextColor = Colors.Red;
            MessageLabel.Text = "Invalid username or password.";
            MessageLabel.IsVisible = true;
        }
    }
}
