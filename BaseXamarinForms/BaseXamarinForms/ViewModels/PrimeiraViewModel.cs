using BaseXamarinForms.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class PrimeiraViewModel
    {
        #region Propriedade
        public ICommand PrimeiraCommand { get; }
        #endregion


        #region Construtor
        public PrimeiraViewModel()
        {
            PrimeiraCommand = new Command(Primeira);
        }
        #endregion


        #region Método
        private async void Primeira()
        {
            MainViewModel.GetInstance().Segunda = new SegundaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SegundaPage());
        }
        #endregion
    }
}
