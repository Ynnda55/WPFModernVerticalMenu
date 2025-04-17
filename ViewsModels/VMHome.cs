using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFModernVerticalMenu.Models;
using WPFModernVerticalMenu.Utilities;

namespace WPFModernVerticalMenu.ViewsModels
{
    class VMHome : ViewModelBase
    {
        // TODO: Hacer los repositorios o clases de cada tabla con sus metodos para obtener los datos de la base de datos :)

        private readonly Article _article;
        public VMHome()
        {
            _article = new Article();
        }

        private string _codigoArticulo;
        public string CodigoArticulo
        {
            get { return _codigoArticulo; }
            set
            {
                _codigoArticulo = value;
                OnPropertyChanged(nameof(CodigoArticulo));
            }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                _descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        private string _marca;
        public string Marca
        {
            get { return _marca; }
            set
            {
                _marca = value;
                OnPropertyChanged(nameof(Marca));
            }
        }

        private RelayCommand _ejemplo;
        public RelayCommand Ejemplo
        {
            get
            {
                return _ejemplo ?? (_ejemplo = new RelayCommand(
                    () =>
                    {
                        // Lo que se ejecuta al dartle click al boton
                        MessageBox.Show("Hola mundo");
                    },
                    () =>
                    {
                        // Condicional que se tiene que cumplir para que el boton se habilite
                        return true;
                    }));
            }
        }




        // Codigo generado por visual studio de como declarar un propiedad
        //private string _title;
        //public string Title
        //{
        //    get { return _title; }
        //    set
        //    {
        //        _title = value;
        //        OnPropertyChanged(nameof(Title));
        //    }
        //}

        // ejemplo de como declarar un RelayCommand que lleve parametros el lamda
        //private RelayCommand _ejemplo;
        //public RelayCommand Ejemplo
        //{
        //    get
        //    {
        //        return _ejemplo ?? (_ejemplo = new RelayCommand(
        //            (obj) =>
        //            {
        //                Lo que se ejecuta al darle click al botón
        //                MessageBox.Show("Hola mundo");
        //            },
        //            (obj) =>
        //            {
        //                Condicional que se tiene que cumplir para que el botón se habilite
        //                return true;
        //            }));
        //    }
        //}
    }
}
