using MySportBets.Model.Model;
using MySportBets.Server.DataBase;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySportBets.Server.GetDataService
{
    public class GetDataService : IGetDataService
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public IList<SportEvent> GetDataEvent()
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    List<SportEvent> eventBetL =
                        db.SportEvents.ToList();
                    return eventBetL;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка");
                return null;
            }
        }
    }
}

        
    

