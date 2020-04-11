using MySportBets.UserInterface.Services;
using MySportBets.UserInterface.ViewModel;
using System.Windows;


namespace MySportBets.UserInterface.View
{
    public partial class RegistrationNewUserView : Window, IView<RegistrationNewUserViewModel>
    {
        public RegistrationNewUserView()
        {
            InitializeComponent();
        }

        RegistrationNewUserViewModel IView<RegistrationNewUserViewModel>.DataContext
        {
            get => base.DataContext as RegistrationNewUserViewModel;
            set => base.DataContext = value;
        }
    }
}
