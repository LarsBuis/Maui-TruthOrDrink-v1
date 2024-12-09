using Microsoft.Maui.Controls;

namespace MauiApp2.TruthOrDrink;

public partial class GamePage : ContentPage
{
    private readonly List<string> questions;
    private int drinkCounter = 0;

    // Use a single instance of Random
    private readonly Random random = new();

    public GamePage(List<string> selectedQuestions)
    {
        InitializeComponent();

        // Use the selected list of questions
        questions = selectedQuestions;
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

        // Show the next question
        ShowNextQuestion();
    }

    private void ShowNextQuestion()
    {
        if (questions.Count == 0)
        {
            QuestionLabel.Text = "No more questions!";
            TruthButton.IsVisible = false;
            DrinkButton.IsVisible = false;
            return;
        }

        // Randomly select a question
        int index = random.Next(questions.Count);
        QuestionLabel.Text = questions[index];

        // Remove the question to avoid repetition
        questions.RemoveAt(index);
    }
}
