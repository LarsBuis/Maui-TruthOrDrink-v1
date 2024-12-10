using MauiApp2.Models;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private readonly TodoDatabase _database;

        public MainPage(TodoDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshTodoList();
        }

        private async Task RefreshTodoList()
        {
            var items = await _database.GetItemsAsync();
            TodoListView.ItemsSource = items;
        }

        private async void AddItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
            {
                var newItem = new TodoItem { Name = TaskEntry.Text, IsCompleted = false };
                await _database.SaveItemAsync(newItem);
                TaskEntry.Text = string.Empty;
                await RefreshTodoList();
            }
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is TodoItem selectedTask)
            {
                var delete = await DisplayAlert("Delete Task", $"Do you want to delete '{selectedTask.Name}'?", "Yes", "No");
                if (delete)
                {
                    await _database.DeleteItemAsync(selectedTask);
                    await RefreshTodoList();
                }
            }
        }
    }
}
