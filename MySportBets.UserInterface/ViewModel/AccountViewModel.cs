using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class AccountViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;

        //private ICommand _showMainMenuView;

        public AccountViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            //_showMainMenuView = new RelayCommand((x) => ShowEditor());
        }
    }
}
