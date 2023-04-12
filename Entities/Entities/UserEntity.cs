using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public  class UserEntity
    {
        public UserEntity() { }
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string UserName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedToken { get; set; }
        public DateTime TokenExpireDate { get; set; }
     
    }
}

