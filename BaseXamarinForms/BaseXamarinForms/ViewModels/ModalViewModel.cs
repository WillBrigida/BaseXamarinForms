using BaseXamarinForms.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class ModalViewModel
    {
        #region Propriedade
      
        public ICommand ModalCommand { get; }
        #endregion


        #region Construtor
        public ModalViewModel()
        {
            ModalCommand = new Command(Modal);
        }

        

   
        #endregion


        #region Método
        private async void Modal()
        {
            //MainViewModel.GetInstance().Terceira = new TerceiraViewModel();
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        #endregion
    }
}
