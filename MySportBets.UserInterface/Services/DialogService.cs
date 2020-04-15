using MySportBets.Model.Model;
using MySportBets.Server.GetDataService;
using MySportBets.Server.UserService;
using MySportBets.UserInterface.View;
using MySportBets.UserInterface.ViewModel;
using Ninject;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MySportBets.UserInterface.Services
{
    public class DialogService : IDialogService
    {
        private readonly IKernel kernel;

        public DialogService(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IList<SportEvent> GetDataSportEvent()
        {
            GetDataService dataService = kernel.Get<GetDataService>();
            var gdse = dataService.GetDataEvent();
            return gdse;
        }

        public bool RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance)
        {
            UserValidator validator = kernel.Get<UserValidator>();

            User user = new User(userLogin);

            var check = validator.CheckLoginUser(user);
            if(check)
            {
                user.UserPass = userPassword;
                user.Name = name;
                user.SecondName = secondName;
                user.SurName = surName;
                user.Birthday = birthday;
                user.Role = "ProgrammUser";
                user.Balance = 0;

                var userC = validator.RegistrationNewUser(user);
                return true;
            }
            else
            {
                return false;
            } 
        }
        public bool ShowDialog<TViewModel>(TViewModel viewModel) where TViewModel : BaseViewModel
        {
            IView<TViewModel> view = kernel.Get<IView<TViewModel>>();
            view.DataContext = viewModel;
            return view.ShowDialog().Value;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public IList<User> ValidationUser(User user)
        {
            UserValidator validator = kernel.Get<UserValidator>();

            var us = validator.CheckRegUser(user);
            return us;
        }
    }
}
