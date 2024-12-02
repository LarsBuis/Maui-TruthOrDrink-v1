using Microsoft.Maui.Controls;

namespace MauiApp2.TruthOrDrink;

public partial class QuestionSelectionPage : ContentPage
{
    private readonly Dictionary<string, List<string>> questionLists = new()
    {
        {
            "EmbarrassingQuestions",
            new List<string>
            {
                "What’s your most embarrassing moment?",
                "Have you ever accidentally texted the wrong person?",
                "What’s the most awkward date you’ve been on?",
                "balls"
            }
        },
        {
            "PersonalSecrets",
            new List<string>
            {
                "What’s a secret you’ve never told anyone?",
                "Have you ever cheated on a test?",
                "What’s something you’ve done that you regret?"
            }
        },
        {
            "FunQuestions",
            new List<string>
            {
                "If you could be any animal, what would you be?",
                "What’s your favorite childhood memory?",
                "What’s the weirdest food you’ve ever eaten?"
            }
        }
    };

    public QuestionSelectionPage()
    {
        InitializeComponent();
    }

    private async void OnCategorySelected(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var categoryKey = (string)button.CommandParameter;

        if (questionLists.ContainsKey(categoryKey))
        {
            var selectedQuestions = questionLists[categoryKey];

            // Navigate to GamePage with the selected category
            var navigationParams = new Dictionary<string, object>
        {
            { "Questions", selectedQuestions }
        };
            await Shell.Current.GoToAsync("GamePage", navigationParams);
        }
    }
}
