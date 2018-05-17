using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.ViewModel
{

    using Model;
    class PropinaViewModel
    {
        #region Propiedades

        public Propina PropinaModel { get; set; }

        #endregion

        #region Constructores

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
        }

        #endregion


    }
}
