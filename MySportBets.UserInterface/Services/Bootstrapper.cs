using MySportBets.Server.BetsService;
using MySportBets.Server.GetDataService;
using MySportBets.Server.PaymentService;
using MySportBets.Server.UserService;
using MySportBets.Userinterface.Auth;
using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using Ninject;

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
            _kernel.Bind<IBetService>().To<BetService>().InSingletonScope();

            _kernel.Bind<IGetDataService>().To<GetDataService>().InSingletonScope();

            _kernel.Bind<IPayService>().To<PayService>().InSingletonScope();

            _kernel.Bind<IUserValidator>().To<UserValidator>().InSingletonScope();

            _kernel.Bind<IViewFactory>().To<ViewFactory>().InSingletonScope();

            _kernel.Bind<ProgrammRunner>().To<ProgrammRunner>().InTransientScope();

            _kernel.Bind<Authorization>().ToSelf().InTransientScope(); ;

            return this;
        }
        public ProgrammRunner Prepaire()
        {
            return _kernel.Get<ProgrammRunner>();
        }
    }
}
