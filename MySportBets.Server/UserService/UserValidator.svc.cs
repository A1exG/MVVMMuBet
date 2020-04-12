using MySportBets.Model.Model;
using MySportBets.Server.DataBase;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySportBets.Server.UserService
{
    public class UserValidator : IUserValidator
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public IList<User> CheckRegUser(User user)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    List<User> userL =
                        context.Users
                        .Where(b => b.UserLogin == user.UserLogin || b.UserPass == user.UserPass)
                        .ToList();
                    return userL;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка");
                return null;
            }
        }
        public int RegistrationNewUser(User user)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка");
                return 0;
            }
        }

        public bool CheckLoginUser(User user)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    List<User> userL =
                        context.Users
                        .Where(b => b.UserLogin == user.UserLogin)
                        .ToList();
                    if(userL.Count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка");
                return false;
            }
        }
    }
}
