using BaseXamarinForms.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get;}

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        private async void Login()
        {
            MainViewModel.GetInstance().Primeira = new PrimeiraViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProdutoPage());
        }
    }
}
