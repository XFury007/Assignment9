using MauiBankingExercise.ViewModel;
using MauiBankingExercise.Services;

namespace MauiBankingExercise.Views
{
    public partial class AccountsPage : ContentPage
    {
        public AccountsPage()
        {
            InitializeComponent();

            // Database path setup
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "banking.db3");
            var dbService = new DatabaseService(dbPath);

            // Bind ViewModel
            BindingContext = new AccountsViewModel(dbService);
        }
    }
}
