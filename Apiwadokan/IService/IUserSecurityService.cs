namespace Apiwadokan.IService
{
    public interface IUserSecurityService
    {
        Task<string> GenerateAuthorizationTokenAsync(string userName, string userPassword);
        Task<bool> ValidateUserTokenAsync(string authorization, List<string> authorizedRols);
    }
}
