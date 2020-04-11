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
        public IList<User> CheckRegUser(string login, string password)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    List<User> userL =
                        context.Users
                        .Where(b => b.UserLogin == login.ToString() || b.UserPass == password.ToString())
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
        public int RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    User user = new User();
                    user.UserLogin = userLogin;
                    user.UserPass = userPassword;
                    user.Name = name;
                    user.SecondName = secondName;
                    user.SurName = surName;
                    user.Birthday = birthday;
                    user.Role = "ProgrammUser";
                    user.Balance = 0;

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

        public int CheckLoginUser(string login)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    List<User> userL =
                        context.Users
                        .Where(b => b.UserLogin == login.ToString())
                        .ToList();
                    return userL.Count;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ошибка");
                return 12345;
            }
        }
    }
}
