using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserSecurityLogic
    {
        string GenerateAuthorizationToken(string userName, string userPasswordEncrypted);
        string HashString(string key);
        bool ValidateUserToken(string userName, string token, List<string> authorizedRols);
    }
}
