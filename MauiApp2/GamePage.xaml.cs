using Microsoft.Maui.Controls;

namespace MauiApp2.TruthOrDrink;

public partial class GamePage : ContentPage
{
    private readonly List<string> questions = new()
    {
        "What’s your most embarrassing memory?",
        "Have you ever lied to a friend?",
        "What’s the most illegal thing you’ve done?",
        "If you could erase one thing from your past, what would it be?",
        "What’s your deepest fear?",
        "Who’s the last person you stalked on social media?",
        "What’s a secret you’ve never told anyone?",
        "Have you ever cheated on someone?",
        "What’s your worst habit?",
        "What’s something you’re ashamed of?"
    };

    private int drinkCounter = 0;

    public GamePage()
    {
        InitializeComponent();
    }

    private void OnStartGameClicked(object sender, EventArgs e)
    {
        // Show the question and buttons
        ShowNextQuestion();
        TruthButton.IsVisible = true;
        DrinkButton.IsVisible = true;
        StartGameButton.IsVisible = false;
    }

    private void OnTruthClicked(object sender, EventArgs e)
    {
        // Show a message to indicate the question was answered
        DisplayAlert("Answered!", "Great job answering the question!", "Next");
        ShowNextQuestion();
    }

    private void OnDrinkClicked(object sender, EventArgs e)
    {
        // Increment the drink counter
        drinkCounter++;
        DrinkCounterLabel.Text = $"Drinks Taken: {drinkCounter}";
        ShowNextQuestion();
    }

    private void ShowNextQuestion()
    {
        // Randomly select a question
        var random = new Random();
        int index = random.Next(questions.Count);
        QuestionLabel.Text = questions[index];
    }
}
