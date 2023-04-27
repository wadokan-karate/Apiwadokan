namespace Apiwadokan.IService
{
    public interface IUserSecurityService
    {
        //string GenerateAuthorizationToken(string userName, string userPassword);
        Task<string> GenerateAuthorizationTokenAsync(string userName, string userPassword);
        Task<bool> ValidateUserTokenAsync(string authorization, List<string> authorizedRols);
    }
}
