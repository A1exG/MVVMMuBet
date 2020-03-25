using MySportBets.Ui.Services;
using MySportBets.Userinterface.Auth;
using Ninject;
using System.Windows;

namespace MySportBets.UserInterface
{
    public partial class App : Application
    {
        public App()
        {
            new Bootstrapper().InitDependencies().Prepaire().Run();
        }
    }
}
