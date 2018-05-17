using AppPropina.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPropina.Model
{
    public class Propina: Notificable
    {

        private int numeroPersonas;

        public int NumeroPersonas
        {
            get
            {
                return numeroPersonas;
            }

            set
            {
                if (numeroPersonas == value)
                {
                    return;
                }
                numeroPersonas = value;
                OnPropertyChanged();
            }
        }


        private decimal totalCuenta;

        public decimal TotalCuenta
        {
            get
            {
                return totalCuenta;
            }

            set
            {
                if (totalCuenta == value)
                {
                    return;
                }
                totalCuenta = value;
                OnPropertyChanged();
            }
        }
        

        private double laPropina;

        public double LaPropina
        {
            get
            {
                return laPropina;
            }

            set
            {
                if (laPropina == value)
                {
                    return;
                }
                laPropina = value;
                OnPropertyChanged();
            }
        }

        private double porcentajePropina;

        public double PorcentajePropina
        {
            get
            {
                return porcentajePropina;
            }

            set
            {
                if (porcentajePropina == value)
                {
                    return;
                }
                porcentajePropina = value;
                OnPropertyChanged();
            }
        }


        private int totalconPropina;

        public int TotalconPropina
        {
            get
            {
                return totalconPropina;
            }

            set
            {
                if (totalconPropina == value)
                {
                    return;
                }
                totalconPropina = value;
                OnPropertyChanged();
            }
        }


        private int propinaporPersona;

        public int PropinaporPersona
        {
            get
            {
                return propinaporPersona;
            }

            set
            {
                if (propinaporPersona == value)
                {
                    return;
                }
                propinaporPersona = value;
                OnPropertyChanged();
            }
        }

        private int totalporPersona;

        public int TotalporPersona
        {
            get
            {
                return totalporPersona;
            }

            set
            {
                if (totalporPersona == value)
                {
                    return;
                }
                totalporPersona = value;
                OnPropertyChanged();
            }
        }

    }
}
