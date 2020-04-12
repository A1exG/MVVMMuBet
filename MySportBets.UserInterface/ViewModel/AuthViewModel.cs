using MySportBets.Model.Model;
using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using NLog;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class AuthViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;
        private string _userLogin;
        private string _userPassword;

        private ICommand _showMainMenuView;
        private ICommand _showRegistrationView;

        public AuthViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            _showMainMenuView = new RelayCommand((x) => ShowMainMenu());
            _showRegistrationView = new RelayCommand((x) => ShowRegistation());
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

        public ICommand ShowMainMenuView
        {
            get
            {
                return _showMainMenuView;
            }
        }

        public ICommand ShowRegistrationView
        {
            get
            {
                return _showRegistrationView;
            }
        }

        private void ShowMainMenu()
        {
            if (_userLogin != null && _userPassword != null)
            {
                User user = new User(_userLogin, _userPassword);
                var userC = DialogService.ValidationUser(user);
                if (userC[0].Role == "Admin")
                {
                    MainMenuViewModel viewModel = viewFactory.Build<MainMenuViewModel>();
                    DialogService.ShowDialog<MainMenuViewModel>(viewModel);
                }
                else
                {
                    if (userC[0].Role == "ProgrammUser")
                    {
                        UserMainMenuViewModel viewModel = viewFactory.Build<UserMainMenuViewModel>();
                        DialogService.ShowDialog<UserMainMenuViewModel>(viewModel);
                    }
                }
            }
            else
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error($"Ошибка! Пользователя с логином {_userLogin} не существует");
            }
        }

        private void ShowRegistation()
        {
            RegistrationNewUserViewModel viewModel = viewFactory.Build<RegistrationNewUserViewModel>();
            DialogService.ShowDialog<RegistrationNewUserViewModel>(viewModel);
        }
    }
}
