using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System;
using System.Windows.Data;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class MainMenuViewModel : BaseViewModel 
    {
        private readonly IViewFactory viewFactory;

        private ICommand _showAccountView;
        private ICommand _showBetsView;


        public MainMenuViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            _showAccountView = new RelayCommand((x) => ShowAccount());
            _showBetsView = new RelayCommand((x) => ShowBets());
        }

        private void ShowBets()
        {
            BetsViewModel viewModel = viewFactory.Build<BetsViewModel>();
            DialogService.ShowDialog<BetsViewModel>(viewModel);
        }

        public ICommand ShowAccountView
        {
            get
            {
                return _showAccountView;
            }
        }

        public ICommand ShowBetsView
        {
            get
            {
                return _showBetsView;
            }
        }
        private void ShowAccount()
        {
            AccountViewModel viewModel = viewFactory.Build<AccountViewModel>();
            DialogService.ShowDialog<AccountViewModel>(viewModel);
        }
    }
}
