using MySportBets.UserInterface.Services;
using MySportBets.UserInterface.ViewModel;
using System;
using System.Windows;

namespace MySportBets.UserInterface.View
{
    public partial class AuthView : Window, IView<AuthViewModel>
    {
        public AuthView()
        {
            InitializeComponent();
        }
        AuthViewModel IView<AuthViewModel>.DataContext
        {
            get => base.DataContext as AuthViewModel;
            set => base.DataContext = value;
        }
    }
}
