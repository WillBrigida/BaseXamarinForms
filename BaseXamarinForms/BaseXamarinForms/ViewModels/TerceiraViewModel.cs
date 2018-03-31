using BaseXamarinForms.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class TerceiraViewModel
    {
        #region Propriedade
        public ICommand TerceiraCommand { get; set; }
        #endregion

        #region Construtor
        public TerceiraViewModel()
        {
            TerceiraCommand = new Command(Terceira);
        }

        private async void Terceira()
        {
            MainViewModel.GetInstance().Modal = new ModalViewModel();
            await Application.Current.MainPage.Navigation.PushModalAsync(new ModalPage());
        }
        #endregion
    }
}