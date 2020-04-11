using MySportBets.Model.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace MySportBets.Server.UserService
{
    [ServiceContract]
    public interface IUserValidator
    {
        [OperationContract]
        IList<User> CheckRegUser(string login, string password);

        [OperationContract]
        int RegistrationNewUser(string userLogin, string userPassword, string name, string secondName, string surName, DateTime birthday, string role, decimal balance);

        int CheckLoginUser(string login);
    }
}
