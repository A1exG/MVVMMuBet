using Ninject;
using System;
using System.Collections.Generic;
using System.Text;
using MySportBets.Server;

namespace MySportBets.Ui.Services
{
    public class Bootstrapper
    {
        private IKernel _kernel;
        public Bootstrapper()
        {
            _kernel = new StandardKernel();
        }

        public Bootstrapper InitDependencies()
        {
            _kernel.Bind<IBetService>().To<ViewModelFactory>().InSingletonScope();

            _kernel.Bind<MainWindowViewModel>().ToSelf().InTransientScope();
            _kernel.Bind<MainMenuViewModel>().ToSelf().InTransientScope();

            _kernel.Bind<IDialogService>().To<DialogService>().InSingletonScope();

            _kernel.Bind<IView<MainWindowViewModel>>().To<MainWindowView>().InTransientScope();
            _kernel.Bind<IView<MainMenuViewModel>>().To<MainMenuView>().InTransientScope();

            _kernel.Bind<MainRunner>().To<MainRunner>().InTransientScope();

            return this;
        }
        public ProgrammRunner Prepaire()
        {
            return _kernel.Get<ProgrammRunner>();
        }
    }
}
