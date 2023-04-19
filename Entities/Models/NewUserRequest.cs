using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class NewUserRequest
    {
        public int IdRol { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserEntity ToUserItem()
        {
            var userItem = new UserEntity();

            userItem.IdRol = IdRol;
            userItem.UserName = UserName;
            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}
