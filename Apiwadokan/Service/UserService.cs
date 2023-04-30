using Apiwadokan.IService;
using Entities.Entities;
using Entities.Models;
using Logic.ILogic;
using Logic.Logic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        private readonly IUserSecurityLogic _userSecurityLogic;
        public UserService(IUserLogic userLogic, IUserSecurityLogic userSecurityLogic)
        {
            _userLogic = userLogic;
            _userSecurityLogic = userSecurityLogic;
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userLogic.DeleteUserAsync(id);
        }

        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            return await _userLogic.GetAllUsersAsync();
        }

        public async Task<UserEntity> GetUserByIdAsync(int id)
        {
            return await _userLogic.GetUserByIdAsync(id);
        }

        public async Task<int> InsertUserAsync(NewUserRequest newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = await _userSecurityLogic.HashStringAsync(newUserRequest.Password);
            return await _userLogic.InsertUserAsync(newUserItem);
        }
        public async Task <int> InsertUserAsync(UserEntity userItem)
        {
            if (!ValidateModel(userItem))
            {
                throw new InvalidDataException();
            }
            await _userLogic.InsertUserAsync(userItem);
            if (!ValidateInsertedEvent(userItem))

            {
                throw new InvalidOperationException();
            }
            return userItem.IdRol;


        }


        // Creamos una nueva clase y Validamos elementos de la clase EventEntitiy
        public static bool ValidateModel(UserEntity userItem)
        {

            if (userItem == null)
            {
                return false;
            }

            if (userItem.UserName == null || userItem.UserName == "")
            {
                return false; ;
            }


            return true;
        }

        public static bool ValidateInsertedEvent(UserEntity userItem)
        {
            if (!ValidateModel(userItem))

            {
                return false;
            }
            if (userItem.IdRol < 1)
            {
                return false;
            }
            return true;
        }
    



public async Task UpdateUserAsync(UserEntity userItem)
        {
            await _userLogic.UpdateUserAsync(userItem);
        }
    }
}
