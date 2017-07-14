using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TabelaCervejaMobi.ViewModel
{
    public class BaseViewModel: INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanging([CallerMemberName]string propertyName = null)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }

}
