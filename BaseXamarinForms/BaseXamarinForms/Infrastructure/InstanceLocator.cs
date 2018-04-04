using BaseXamarinForms.ViewModels;

namespace BaseXamarinForms.Infrastructure
{
    // Tem a finalidade de encontrar a MainViewModel 
    //Ligar as páginas à MainViewModel
    //No dicionário de recurso esta classe é referenciada
    public class InstanceLocator
    {
        #region Propriedade
        public MainViewModel Main { get; set; }
        #endregion


        #region Construtor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
