using MySportBets.UserInterface.Services;
using MySportBets.UserInterface.ViewModel;
using System.Windows;

namespace MySportBets.UserInterface.View
{
    public partial class MainMenuView : Window, IView<MainMenuViewModel>
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        MainMenuViewModel IView<MainMenuViewModel>.DataContext
        {
            get => base.DataContext as MainMenuViewModel;
            set => base.DataContext = value;
        }
    }
}
