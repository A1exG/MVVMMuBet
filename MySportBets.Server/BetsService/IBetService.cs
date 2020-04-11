using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MySportBets.Server.BetsService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IBetService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IBetService
    {
        [OperationContract]
        void DoWork();
    }
}
