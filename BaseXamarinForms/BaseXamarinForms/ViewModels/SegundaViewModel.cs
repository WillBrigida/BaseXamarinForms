using BaseXamarinForms.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class SegundaViewModel
    {
        #region Propriedades
        public ICommand SegundaCommand { get; }
        #endregion


        #region Construtor
        public SegundaViewModel()
        {
            SegundaCommand = new Command(Segunda);
        }
        #endregion


        #region Método
        private async void Segunda()
        {
            MainViewModel.GetInstance().Terceira = new TerceiraViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new TerceiraPage());
        }
        #endregion
    }
}
