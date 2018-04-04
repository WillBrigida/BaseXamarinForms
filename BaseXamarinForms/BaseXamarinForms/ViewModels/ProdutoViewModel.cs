using BaseXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseXamarinForms.ViewModels
{
    public class ProdutoViewModel  : BaseViewModel
    {
        private Produto produto;

        public Produto Produto
        {
            get { return produto; }
            set {this.SetProperty(ref produto , value); }
        }
        

        public ProdutoViewModel(Produto produto)
        {
            this.Produto = produto; 
        }
    }
}
