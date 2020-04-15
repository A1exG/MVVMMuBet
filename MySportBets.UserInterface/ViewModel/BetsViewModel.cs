using Caliburn.Micro;
using MySportBets.Model.Model;
using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Input;

namespace MySportBets.UserInterface.ViewModel
{
    public class BetsViewModel : BaseViewModel
    {
        private readonly IViewFactory viewFactory;

        public BindableCollection<SportEvent> SportEvents { get; set; }

        public BetsViewModel(IDialogService dialogService, IViewFactory viewFactory) : base(dialogService)
        {
            this.viewFactory = viewFactory;
            SportEvents = new BindableCollection<SportEvent>(DialogService.GetDataSportEvent());
        }
        

    }
}
