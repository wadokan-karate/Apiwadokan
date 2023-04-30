using Apiwadokan.Attributes;
using Apiwadokan.IService;
using Apiwadokan.Service;
using Entities.Entities;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [EnableCors]
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

        public async Task<Tuple<string, int>> Login([FromBody] LoginRequest loginRequest)
        {
            var UsersData = await _userService.GetAllUsersAsync();
            UserEntity user = UsersData.Where(user => user.UserName == loginRequest.UserName).First();
            int userIdRol = user.IdRol;
            string token = await _userSecurityService.GenerateAuthorizationTokenAsync(loginRequest.UserName, loginRequest.UserPassword);
            return new Tuple<string, int>(token, userIdRol);

        }
        //public async Task<string> Login([FromBody] LoginRequest loginRequest)
        //{
        //    return await _userSecurityService.GenerateAuthorizationTokenAsync(loginRequest.UserName, loginRequest.UserPassword);
        //}

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPost(Name = "InsertUser")]
        public async Task<int> InsertUser([FromBody] NewUserRequest newUserRequest)
        {
            return await _userService.InsertUserAsync(newUserRequest);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Operario")]
        [HttpGet(Name = "GetAllUsers")]
        public async Task<List<UserEntity>> GetAll()
        {
            return await _userService.GetAllUsersAsync();
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpGet(Name = "GetUserById")]
        public async Task<UserEntity> GetUserById(int id)

        {
            return await _userService.GetUserByIdAsync(id);

        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPatch(Name = "ModifyUser")]
        public async Task Patch([FromBody] UserEntity userItem)
        {
            await _userService.UpdateUserAsync(userItem);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeleteUser")]
        public async Task Delete([FromQuery] int id)
        {
            await _userService.DeleteUserAsync(id);
        }
    }
}
