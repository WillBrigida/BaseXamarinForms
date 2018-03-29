using BaseXamarinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseXamarinForms.Infrastructure
{
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
