using Entities.Entities;
using Entities.Models;

namespace Apiwadokan.IService
{
    public interface IUserService
    {
        int InsertUser(NewUserRequest newProductRequest);
        int InsertUser(UserEntity userItem);
        void UpdateUser(UserEntity userEntity);
        void DeleteUser(int id);
        List<UserEntity> GetAllUsers();
       
    }
}
