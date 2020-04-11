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
    public partial class UserMainMenuView : Window, IView<UserMainMenuViewModel>
    {
        public UserMainMenuView()
        {
            InitializeComponent();
        }
        UserMainMenuViewModel IView<UserMainMenuViewModel>.DataContext
        {
            get => base.DataContext as UserMainMenuViewModel;
            set => base.DataContext = value;
        }
    }
}
