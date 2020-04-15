using MySportBets.Model.Model;
using MySportBets.UserInterface.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MySportBets.UserInterface.Services
{
    public interface IDialogService
    {
        bool ShowDialog<TViewModel>(TViewModel viewModel)
            where TViewModel : BaseViewModel;

        IList<User> ValidationUser(User user);

        bool RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance);

        IList<SportEvent> GetDataSportEvent();

        void ShowMessage(string message);

    }
}