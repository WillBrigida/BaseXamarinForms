using BaseXamarinForms.ViewModels;

namespace BaseXamarinForms.Infrastructure
{
    public class MainViewModel
    {
        #region Propriedade
        public LoginViewModel Login { get; set; }
        public ProdutoViewModel Produto { get; set; }
        public SegundaViewModel Segunda { get; set; }
        public TerceiraViewModel Terceira { get; set; }
        public PopViewModel Pop { get; set; }
        #endregion

        #region Construtor
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
            this.Produto = new ProdutoViewModel();
            this.Segunda = new SegundaViewModel();
            this.Terceira = new TerceiraViewModel();
            this.Pop = new PopViewModel();
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