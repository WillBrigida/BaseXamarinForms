namespace BaseXamarinForms.ViewModels
{
    public class MainViewModel
    {
        #region Propriedade
        public LoginViewModel Login { get; set; }
        public PrimeiraViewModel Primeira { get; set; }
        public SegundaViewModel Segunda { get; set; }
        public TerceiraViewModel Terceira { get; set; }
        public ModalViewModel Modal { get; set; }

        #endregion


        #region Construtor
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
            this.Primeira = new PrimeiraViewModel();
            this.Segunda = new SegundaViewModel();
            this.Terceira = new TerceiraViewModel();
            this.Modal = new ModalViewModel();
            
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