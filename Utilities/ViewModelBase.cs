using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Utilities
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        // Hecho por el generador de codigo automatico lo guardo por si acaso :)

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //protected bool SetField<T>(ref T field, T newValue, string propertyName)
        //{
        //    if (EqualityComparer<T>.Default.Equals(field, newValue))
        //        return false;
        //    field = newValue;
        //    OnPropertyChanged(propertyName);
        //    return true;
        //}
    }
}
