using MySportBets.UserInterface.Services;
using MySportBets.UserInterface.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MySportBets.UserInterface.View
{
    public partial class AccountView : Window, IView<AccountViewModel>
    {
        public AccountView()
        {
            InitializeComponent();
        }

        AccountViewModel IView<AccountViewModel>.DataContext
        {
            get => base.DataContext as AccountViewModel;
            set => base.DataContext = value;
        }
    }
}
