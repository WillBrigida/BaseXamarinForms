using BaseXamarinForms.Infrastructure;
using BaseXamarinForms.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class SegundaViewModel
    {
        public ICommand SegundaCommand
        {
            get
            {
                return new RelayCommand(Segunda);
            }
        }

        private async void Segunda()
        {


            MainViewModel.GetInstance().Terceira = new TerceiraViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new TerceiraPage());


        }
    }
}
