using MySportBets.Model.Model;
using MySportBets.Server.UserService;
using MySportBets.UserInterface.ViewModel;
using Ninject;
using System;
using System.Collections.Generic;

namespace MySportBets.UserInterface.Services
{
    public class DialogService : IDialogService
    {
        private readonly IKernel kernel;

        public DialogService(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public bool RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance)
        {
            UserValidator validator = kernel.Get<UserValidator>();
            var check = validator.CheckLoginUser(userLogin);
            if(check == 0)
            {
                var user = validator.RegistrationNewUser(userLogin, userPassword, name, secondName, surName, birthday, role, balance);
                return true;
            }
            return false;
        }

        public bool ShowDialog<TViewModel>(TViewModel viewModel) where TViewModel : BaseViewModel
        {
            IView<TViewModel> view = kernel.Get<IView<TViewModel>>();
            view.DataContext = viewModel;

            return view.ShowDialog().Value;
        }

        public void ShowMessage(string message)
        {
            System.Windows.MessageBox.Show(message);
        }

        public IList<User> ValidationUser(string login, string password)
        {
            UserValidator validator = kernel.Get<UserValidator>();
            var us = validator.CheckRegUser(login, password);
            return us;
        }
    }
}
