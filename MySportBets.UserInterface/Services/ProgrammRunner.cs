using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.ViewModel;

namespace MySportBets.UserInterface.Services
{
    public class ProgrammRunner
    {
        private readonly IDialogService dialogService;
        private readonly IViewFactory viewFactory;

        public ProgrammRunner(IDialogService dialogService, IViewFactory viewFactory)
        {
            this.dialogService = dialogService;
            this.viewFactory = viewFactory;
        }


        public void Run()
        {
            AuthViewModel auth = viewFactory.Build<AuthViewModel>();

            dialogService.ShowDialog(auth);
        }
    }
}
