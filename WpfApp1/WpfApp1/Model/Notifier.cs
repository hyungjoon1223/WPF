using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1.Model
{
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
    public virtual void NotifyChanged(params string[] propertyNames)
    {
        foreach (string name in propertyNames)
        {
            //OnPropertyChanged(name);
            OnPropertyChanged(new PropertyChangedEventArgs(name));
        }
    }

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, e);
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
}
