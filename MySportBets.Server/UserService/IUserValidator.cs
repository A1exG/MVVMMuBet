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
        IList<User> CheckRegUser(User user);

        [OperationContract]
        int RegistrationNewUser(User user);

        bool CheckLoginUser(User user);

    }
}
