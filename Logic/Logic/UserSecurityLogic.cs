using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserSecurityLogic : IUserSecurityLogic
    {
        private readonly ServiceContext _serviceContext;
        public UserSecurityLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public async Task<string> GenerateAuthorizationTokenAsync(string userName, string userPassword)
        {
            var user = await _serviceContext.Set<UserEntity>()
                     .Where(u => u.UserName == userName).SingleOrDefaultAsync();

            if (user == null)
            {
                throw new InvalidCredentialException("El usuario no existe o bien está replicado.");
            }

            if (user.IsActive == false)
            {
                throw new InvalidOperationException("El usuario no está activo.");
            }

            if (!VerifyHashedKey(userPassword, user.EncryptedPassword))
            {
                throw new UnauthorizedAccessException("La contraseña es incorrecta.");
            }

            var secureRandomString = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
            user.EncryptedToken = await HashStringAsync(secureRandomString);
            user.TokenExpireDate = DateTime.Now.AddMinutes(10);

            await _serviceContext.SaveChangesAsync();

            return secureRandomString;
        }

        public async Task<string> HashStringAsync(string key)
        {
            return await Task.FromResult(BCrypt.Net.BCrypt.HashPassword(key));
        }

        public async Task<bool> ValidateUserTokenAsync(string userName, string token, List<string> authorizedRols)
        {
            var user = await _serviceContext.Set<UserEntity>()
                     .Where(u => u.UserName == userName).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new InvalidCredentialException("El usuario no existe.");
            }

            if (user.IsActive == false)
            {
                throw new InvalidCredentialException("El usuario no está activo.");
            }

            var userRol = await _serviceContext.Set<UserRolEntity>().Where(r => r.Id == user.IdRol).FirstAsync();

            bool authorizedRol = authorizedRols.Any(r => r.Equals(userRol.Name));

            if (!authorizedRol)
            {
                throw new UnauthorizedAccessException("El usuario no está autorizado para la acción.");
            }

            if (VerifyHashedKey(token, user.EncryptedToken) == false)
            {
                throw new UnauthorizedAccessException("El token es incorrecto.");
            }

            if (DateTime.Now > user.TokenExpireDate)
            {
                throw new UnauthorizedAccessException("El token ha expirado.");
            }

            user.TokenExpireDate = DateTime.Now.AddMinutes(10);
            await _serviceContext.SaveChangesAsync();

            return true;
        }

        private bool VerifyHashedKey(string key, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(key, hash);
        }
    }
}
