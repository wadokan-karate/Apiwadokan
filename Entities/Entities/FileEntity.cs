using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class FileEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public FileExtensionEnum FileExtension { get; set; }
        [NotMapped]
        public string Base64Content
        {
            get
            {
                return Convert.ToBase64String(FileContent);
            }
        }
    }
}
