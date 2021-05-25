using KeyInputTest.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace KeyInputTest.UserControl
{
    /// <summary>
    /// Interaction logic for PageA.xaml
    /// </summary>
    public partial class PageA : System.Windows.Controls.UserControl, INotifyPropertyChanged
    {

        public PageA()
        {
            InitializeComponent();
            this.DataContext = this;
        
        }


        private string _input;

        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
                InformPropertyChanged();

            }
        }
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
