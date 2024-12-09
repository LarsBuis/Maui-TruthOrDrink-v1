using MauiApp2.TruthOrDrink;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes
            Routing.RegisterRoute("GamePage", typeof(GamePage));
            Routing.RegisterRoute("QuestionSelectionPage", typeof(QuestionSelectionPage));
        }
    }

}
