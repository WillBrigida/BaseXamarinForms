using BaseXamarinForms.Models;
using BaseXamarinForms.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BaseXamarinForms.ViewModels
{
    public class ItemViewModel : Produto
    {
        public ICommand SelectCommand { get; set; }

        public ItemViewModel()
        {
            SelectCommand = new Command(Select);
        }

        private async void Select()
        {
            MainViewModel.GetInstance().Produto = new ProdutoViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ProdutoPage());
        }
    }


}
