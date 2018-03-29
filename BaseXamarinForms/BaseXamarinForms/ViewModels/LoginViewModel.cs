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
    public class LoginViewModel
    {
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {


            MainViewModel.GetInstance().Produto = new ProdutoViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProdutoPage());

            
        }

    }
}
