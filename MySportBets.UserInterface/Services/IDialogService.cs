using MySportBets.Model.Model;
using MySportBets.UserInterface.ViewModel;
using System;
using System.Collections.Generic;

namespace MySportBets.UserInterface.Services
{
    public interface IDialogService
    {
        bool ShowDialog<TViewModel>(TViewModel viewModel)
            where TViewModel : BaseViewModel;

        IList<User> ValidationUser(string login, string password);

        bool RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance);

        void ShowMessage(string message);
    }
}