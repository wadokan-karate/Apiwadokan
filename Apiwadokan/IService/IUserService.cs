using Entities.Entities;
using Entities.Models;

namespace Apiwadokan.IService
{
    public interface IUserService
    {
        Task<int> InsertUserAsync(NewUserRequest newProductRequest);
        Task UpdateUserAsync(UserEntity userEntity);
        Task DeleteUserAsync(int id);
        Task<List<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetUserByIdAsync(int id);
        //List<UserEntity> GetAllUsers();
    }
}
