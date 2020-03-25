using MySportBets.Userinterface.Auth;
using MySportBets.UserInterface.Factory;

namespace MySportBets.UserInterface.Services
{
    public class ProgrammRunner
    {
        private readonly IViewFactory viewFactory;
        public ProgrammRunner(IViewFactory viewFactory)
        {
            this.viewFactory = viewFactory;
        }
        public void Run()
        {
            Authorization auth = viewFactory.Build<Authorization>();
            auth.ShowDialog();
        }
    }
}
