using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class MainMenuViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;

        private ICommand _showMainMenuView;

        public MainMenuViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            _showMainMenuView = new RelayCommand((x) => ShowEditor());
        }

        public ICommand ShowMainMenuView
        {
            get
            {
                return _showMainMenuView;
            }
        }

        private void ShowEditor()
        {
            MainMenuViewModel viewModel = viewFactory.Build<MainMenuViewModel>();

            DialogService.ShowDialog<MainMenuViewModel>(viewModel);
        }
    }
}
