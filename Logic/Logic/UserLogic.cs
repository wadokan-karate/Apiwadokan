using Data;
using Entities.Entities;
using Entities.Enums;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using Data;
using Entities.Entities;
using Entities.Enums;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly ServiceContext _serviceContext;
        public UserLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
        public async Task DeleteUserAsync(int id)
        {
            var userToDelete = await _serviceContext.Set<UserEntity>()
                 .Where(u => u.Id == id).FirstAsync();

            userToDelete.IsActive = false;

            await _serviceContext.SaveChangesAsync();

        }

        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            return await _serviceContext.Set<UserEntity>().ToListAsync();
        }
        public async Task<UserEntity> GetUserByIdAsync(int id)
        {
            return await _serviceContext.Set<UserEntity>()
                    .Where(u => u.Id == id).FirstAsync();
        }
        public async Task<int> InsertUserAsync(UserEntity userItem)
        {
            if (userItem.IdRol == (int)UserEnums.Administrador)
            {
                throw new InvalidOperationException();
            };

            userItem.EncryptedToken = "NOT GENERATED";

            _serviceContext.Users.Add(userItem);
            await _serviceContext.SaveChangesAsync();

            return userItem.Id;
        }
        public async Task UpdateUserAsync(UserEntity userItem)
        {
            _serviceContext.Users.Update(userItem);
            await _serviceContext.SaveChangesAsync();
        }
    }
}
