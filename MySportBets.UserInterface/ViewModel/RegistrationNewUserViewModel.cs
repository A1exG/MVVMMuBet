using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class RegistrationNewUserViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;
        private string _userLogin;
        private string _userPassword;
        private string _name;
        private string _secondName;
        private string _surName;
        private DateTime _birthday;

        private ICommand _registrationNewUser;

        public RegistrationNewUserViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            _registrationNewUser = new RelayCommand((x) => RegistrationUser());
        }
        public string UserLogin
        {
            get => _userLogin;
            set
            {
                _userLogin = value;
            }
        }

        public string UserPassword
        {
            get => _userPassword;
            set
            {
                _userPassword = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string SecondName
        {
            get => _secondName;
            set
            {
                _secondName = value;
            }
        }

        public string SurName
        {
            get => _surName;
            set
            {
                _surName = value;
            }
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
            }
        }

        public ICommand RegistationNewUser
        {
            get
            {
                return _registrationNewUser;
            }
        }

        private void RegistrationUser()
        {
            if (_userLogin != null && _userPassword != null && _birthday != null && _name != null && _secondName != null && _surName != null)
            {

                var user = DialogService.RegistrationNewUser(_userLogin, _userPassword, _name, _secondName, _surName, _birthday, "ProgrammUser", 0);
                if(user)
                {
                    DialogService.ShowMessage($"Пользователь {_name} {_secondName} зарегистрирован");
                }
                else
                {
                    DialogService.ShowMessage($"Пользователь {_name} {_secondName} не зарегистрирован");
                }
            }
        }
    }
}
