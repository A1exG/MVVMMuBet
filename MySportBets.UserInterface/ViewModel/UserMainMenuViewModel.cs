using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class UserMainMenuViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;

        private ICommand _showUserMainMenuView;

        public UserMainMenuViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;

            _showUserMainMenuView = new RelayCommand((x) => ShowEditor());
        }

        public ICommand ShowUserMainMenuView
        {
            get
            {
                return _showUserMainMenuView;
            }
        }

        private void ShowEditor()
        {
            UserMainMenuViewModel viewModel = viewFactory.Build<UserMainMenuViewModel>();

            DialogService.ShowDialog<UserMainMenuViewModel>(viewModel);
        }
    }
}
