using BaseXamarinForms.ViewModels;
using BaseXamarinForms.Views;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.Infrastructure
{
    public class TerceiraViewModel
    {
        public ICommand TerceiraCommand
        {
            get
            {
                return new RelayCommand(Terceira);
            }
        }

        private async void Terceira()
        {
            MainViewModel.GetInstance().Pop = new PopViewModel();
            await Application.Current.MainPage.Navigation.PushModalAsync(new PopPage());
        }
    }
}