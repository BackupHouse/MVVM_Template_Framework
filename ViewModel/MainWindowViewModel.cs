using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTemplate.ViewModel
{
    public partial class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
    }


    public partial class MainWindowViewModel : BaseViewModel
    {
        public readonly MainWindow mainWindow;

        private int _percent;
        public int Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;
                NotifyPropertyChanged(nameof(Percent));
            }
        }

        private int _restnum;
        public int Restnum
        {
            get
            {
                return _restnum;
            }
            set
            {
                _restnum = value;
                NotifyPropertyChanged(nameof(Restnum));
            }
        }
    }


    /*
     ICommand definites
     
     */
    public partial class MainWindowViewModel : BaseViewModel
    {
        public ICommand testcommand { get; set; }
    }
}
