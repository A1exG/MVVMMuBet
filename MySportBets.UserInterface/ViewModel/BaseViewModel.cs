using MySportBets.UserInterface.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MySportBets.UserInterface.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private readonly IDialogService _dialogService;

        protected BaseViewModel(IDialogService dialogService)
        {
            this._dialogService = dialogService;
        }

        protected IDialogService DialogService => _dialogService;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
