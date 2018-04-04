using BaseXamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BaseXamarinForms.ViewModels
{
    public class ProdutosViewModel : BaseViewModel
    {
        private ObservableCollection<ItemViewModel> produtos;

        public ObservableCollection<ItemViewModel> Produtos
        {
            get { return produtos; }
            set { this.SetProperty (ref produtos , value); }
        }


        public ProdutosViewModel()
        {
            Produtos = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel{IdProduto = 1, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 2, NomeProduto = "Feijão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 3, NomeProduto = "Carne", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 4, NomeProduto = "Ovo", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 5, NomeProduto = "Cebola", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 6, NomeProduto = "Macarrão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 7, NomeProduto = "Leite", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 8, NomeProduto = "Biscoito", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 9, NomeProduto = "Doce", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 10, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 1, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 2, NomeProduto = "Feijão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 3, NomeProduto = "Carne", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 4, NomeProduto = "Ovo", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 5, NomeProduto = "Cebola", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 6, NomeProduto = "Macarrão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 7, NomeProduto = "Leite", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 8, NomeProduto = "Biscoito", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 9, NomeProduto = "Doce", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 10, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 1, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 2, NomeProduto = "Feijão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 3, NomeProduto = "Carne", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 4, NomeProduto = "Ovo", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 5, NomeProduto = "Cebola", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 6, NomeProduto = "Macarrão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 7, NomeProduto = "Leite", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 8, NomeProduto = "Biscoito", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 9, NomeProduto = "Doce", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 10, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 1, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 2, NomeProduto = "Feijão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 3, NomeProduto = "Carne", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 4, NomeProduto = "Ovo", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 5, NomeProduto = "Cebola", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 6, NomeProduto = "Macarrão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 7, NomeProduto = "Leite", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 8, NomeProduto = "Biscoito", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 9, NomeProduto = "Doce", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 10, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 1, NomeProduto = "Arroz", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 2, NomeProduto = "Feijão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 3, NomeProduto = "Carne", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 4, NomeProduto = "Ovo", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 5, NomeProduto = "Cebola", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 6, NomeProduto = "Macarrão", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 7, NomeProduto = "Leite", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 8, NomeProduto = "Biscoito", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 9, NomeProduto = "Doce", QuantidadeDeItens = 0},
                new ItemViewModel{IdProduto = 10, NomeProduto = "Arroz", QuantidadeDeItens = 0},

            };
        }
    }
}
