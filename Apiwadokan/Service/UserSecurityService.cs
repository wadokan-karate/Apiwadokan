using Apiwadokan.IService;
using Logic.ILogic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{
    public class UserSecurityService : IUserSecurityService
    {
        private readonly IUserSecurityLogic _userSecurityLogic;
        public UserSecurityService(IUserSecurityLogic userSecurityLogic)
        {
            _userSecurityLogic = userSecurityLogic;
        }

        public async Task<string> GenerateAuthorizationTokenAsync(string userName, string userPassword)
        {
            return await _userSecurityLogic.GenerateAuthorizationTokenAsync(userName, userPassword);
        }

        public async Task<bool> ValidateUserTokenAsync(string authorization, List<string> authorizedRols)
        {
            var userName = GetUserNameFromAuthorization(authorization);
            var token = GetTokenFromAuthorization(authorization);
            return await _userSecurityLogic.ValidateUserTokenAsync(userName, token, authorizedRols);
        }

        private string GetUserNameFromAuthorization(string authorization)
        {
            var indexToSplit = authorization.IndexOf(':');
            return authorization.Substring(7, indexToSplit - 7);
        }

        private string GetTokenFromAuthorization(string authorization)
        {
            var indexToSplit = authorization.IndexOf(':');
            var userName = authorization.Substring(7, indexToSplit - 7);
            return authorization.Substring(indexToSplit + 1, authorization.Length - userName.Length - 8);
        }
    }
}