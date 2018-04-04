using BaseXamarinForms.Models;
using BaseXamarinForms.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class SegundaViewModel : BaseViewModel
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
            Console.WriteLine("Teste");
            await Application.Current.MainPage.Navigation.PushAsync(new TerceiraPage());
        }
        #endregion
    }
}
