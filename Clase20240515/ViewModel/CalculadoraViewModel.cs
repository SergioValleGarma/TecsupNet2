using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240515.ViewModel
{
    public class CalculadoraViewModel : ViewModelBase
    {
        private int _Valor1 { get; set; }
        public int Valor1
        {
            get { return _Valor1; }
            set
            {
                _Valor1 = value;
                OnPropertyChanged(nameof(Valor1));
            }
        }
        private int _Valor2 { get; set; }
        public int Valor2
        {
            get { return _Valor2; }
            set
            {
                _Valor2 = value;
                OnPropertyChanged(nameof(Valor2));
            }
        }

        private int _Resultado;
        public int Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        private int _ResultadoRestar;
        public int ResultadoRestar
        {
            get { return _ResultadoRestar; }
            set
            {
                _ResultadoRestar = value;
                OnPropertyChanged(nameof(ResultadoRestar));
            }
        }

        private int _ResultadoMultiplicar;
        public int ResultadoMultiplicar
        {
            get { return _ResultadoMultiplicar; }
            set
            {
                _ResultadoMultiplicar = value;
                OnPropertyChanged(nameof(ResultadoMultiplicar));
            }
        }

        private int _ResultadoDividir;
        public int ResultadoDividir
        {
            get { return _ResultadoDividir; }
            set
            {
                _ResultadoDividir = value;
                OnPropertyChanged(nameof(ResultadoDividir));
            }
        }

        public RelayCommand SumarCommand { get; }
        public RelayCommand RestarCommand { get; }
        public RelayCommand MultiplicarCommand { get; }
        public RelayCommand DividirCommand { get; }
        //public CalculadoraViewModel()
        //{
        //    SumarCommand = new RelayCommand(Sumar);
        //}

        #region Métodos Privados
        public void Sumar()
        {
            Resultado = Valor1 + Valor2;
        }
        public void Restar()
        {
            ResultadoRestar = Valor1 - Valor2;
        }
        public void Multiplicar()
        {
            ResultadoMultiplicar = Valor1 * Valor2;
        }
        public void Dividir()
        {
            ResultadoDividir = Valor1 / Valor2;
        }
        #endregion


        public CalculadoraViewModel()
        {
            SumarCommand = new RelayCommand(Sumar);
            RestarCommand = new RelayCommand(Restar);
            MultiplicarCommand = new RelayCommand(Multiplicar);
            DividirCommand = new RelayCommand(Dividir);
        }

        
    }
}
