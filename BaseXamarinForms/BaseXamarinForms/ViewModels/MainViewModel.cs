using BaseXamarinForms.Models;

namespace BaseXamarinForms.ViewModels
{
    public class MainViewModel
    {
        // A classe mais importante de todas
        #region Propriedade
        public LoginViewModel Login { get; set; }
        public SegundaViewModel Segunda { get; set; }
        public TerceiraViewModel Terceira { get; set; }
        public ModalViewModel Modal { get; set; }
        public ProdutosViewModel Produtos { get; set; }
        public ProdutoViewModel Produto { get; set; }
        public ItemViewModel Item { get; internal set; }
        #endregion


        #region Construtor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion


        #region MyRegion
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}