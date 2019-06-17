using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace Scrum_GTD_ToDo.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(params string[] propertyNames)
        {
            foreach(var propertyName in propertyNames)
            {
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
            }
        }
        public INavigation Navigation { get; set; }
    }
}
