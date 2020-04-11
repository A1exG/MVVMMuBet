using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportBets.UserInterface.Factory
{
    public interface IViewFactory
    {
        TView Build<TView>() where TView : class;
    }
}
