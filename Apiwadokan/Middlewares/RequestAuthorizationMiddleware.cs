using Apiwadokan.Attributes;
using Apiwadokan.IService;

namespace Apiwadokan.Middlewares
{
    public class RequestAuthorizationMiddleware
    {
        private readonly IUserSecurityService _userSecurityService;

        public RequestAuthorizationMiddleware(IUserSecurityService userSecurityService)
        {
            _userSecurityService = userSecurityService;
        }

        public async Task ValidateRequestAutorizathion(HttpContext context)
        {
            if (context.Request.Method == "OPTIONS")
            {
                return;
            }

            EndpointAuthorizeAttribute authorization = new EndpointAuthorizeAttribute(context);

            if (authorization.Values.AllowsAnonymous)
            {
                return;
            }

            await _userSecurityService.ValidateUserTokenAsync(context.Request.Headers.Authorization.ToString(),
                                                 authorization.Values.AllowedUserRols);
        }
    }
}
