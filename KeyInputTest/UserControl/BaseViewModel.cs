using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KeyInputTest.UserControl
{
    internal abstract class BaseViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void InformPropertyChanged([CallerMemberName]string propName = "")
        {

            if (this.PropertyChanged != null)
            {
                System.Diagnostics.Debug.WriteLine($"propName: {propName}");
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
