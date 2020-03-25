using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportBets.UserInterface.Factory
{
    public class ViewFactory : IViewFactory
    {
        private IKernel _kernel;

        public ViewFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        public TView Build<TView>() where TView : class
        {
            return _kernel.Get<TView>();
        }
    }
}
