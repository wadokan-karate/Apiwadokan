using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserSecurityLogic
    {
        Task<string> GenerateAuthorizationTokenAsync(string userName, string userPasswordEncrypted);
        Task<string> HashStringAsync(string key);
        Task<bool> ValidateUserTokenAsync(string userName, string token, List<string> authorizedRols);
    }
}
