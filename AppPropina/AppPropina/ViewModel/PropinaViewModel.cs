using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.ViewModel
{

    using Model;
    using Xamarin.Forms;

    class PropinaViewModel
    {
        #region Propiedades

        public Propina PropinaModel { get; set; }
        public Command CalcularCommand { get; set; }

        #endregion

        #region Constructores

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
        }

        private void Calcular(object obj) {

            PropinaModel.TotalCuenta = decimal.Parse(entTotal.Text);
            PropinaModel.LaPropina = int.Parse(entPropina.Text);
            PropinaModel.NumeroPersonas = int.Parse(entPersonas.Text);

            var totalPropina = (total * (propina / 100)).ToString();

            txtPropina.Detail = totalPropina.ToString();
            txtPersona.Detail = (total / personas).ToString();
            txtTotal.Detail = (total + totalPropina).ToString();

        }

        #endregion


    }
}
