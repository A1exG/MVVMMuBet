using MySportBets.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MySportBets.Server.GetDataService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IGetDataService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IGetDataService
    {
        [OperationContract]
        IList<SportEvent> GetDataEvent();
    }
}
