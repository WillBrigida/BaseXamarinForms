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
    public class ProdutoViewModel : BaseViewModel
    {
        public ICommand ProdutoCommand
        {
            get
            {
                return new RelayCommand(Produto);
            }
        }

        private async void Produto()
        {


            MainViewModel.GetInstance().Segunda = new SegundaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SegundaPage());


        }
    }
}
