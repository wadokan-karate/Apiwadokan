using Apiwadokan.IService;
using Entities.Entities;
using Entities.Models;
using Logic.ILogic;

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

        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        public List<UserEntity> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

       

        public int InsertUser(NewUserRequest newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
            return _userLogic.InsertUser(newUserItem);
        }

        public void UpdateUser(UserEntity userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
    }


}
