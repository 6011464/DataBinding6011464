using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBindingMauiApp1
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                    OnPropertyChanged(nameof(MostrarNombre));
                }
            }
        }

        public string MostrarNombre => $"Nombre ingresado: {nombre}";

        void OnPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
