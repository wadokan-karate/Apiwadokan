using Apiwadokan.Attributes;
using Apiwadokan.IService;
using Entities.Entities;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserSecurityService _userSecurityService;
        private readonly IUserService _userService;

        public UserController(IUserSecurityService userSecurityService, IUserService userService)
        {
            _userSecurityService = userSecurityService;
            _userService = userService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "LoginUser")]

        public Tuple <string,int> Login([FromBody] LoginRequest loginRequest)
        {
            var UsersData = _userService.GetAllUsers();
            UserEntity user = UsersData.Where(user=> user.UserName== loginRequest.UserName).First();
            int userIdRol = user.IdRol;
            string token = _userSecurityService.GenerateAuthorizationToken(loginRequest.UserName, loginRequest.UserPassword);
            return new Tuple<string, int> ( token, userIdRol );

        }
        //public string Login([FromBody] LoginRequest loginRequest)
        //{

        //    return _userSecurityService.GenerateAuthorizationToken(loginRequest.UserName, loginRequest.UserPassword);
        //}

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPost(Name = "InsertUser")]
        public int InsertUser([FromBody] NewUserRequest newUserRequest)
        {
            return _userService.InsertUser(newUserRequest); //newUserRequest
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Operario")]
        [HttpGet(Name = "GetAllUsers")]
        public List<UserEntity> GetAll()
        {
            return _userService.GetAllUsers();
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserEntity userItem)
        {
            _userService.UpdateUser(userItem);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
