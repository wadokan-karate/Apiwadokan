using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        Task<int> InsertUserAsync(UserEntity userItem);
        Task UpdateUserAsync(UserEntity userItem);
        Task DeleteUserAsync(int id);
        Task<List<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetUserByIdAsync(int id);
    }
}
