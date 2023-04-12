using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class NewProductBase64Request
    {
        public Base64FileModel Base64FileModel { get; set; }
        public EventEntity EventEntity { get; set; }

        //si van a insertar varias fotos a la vez, el archivo va en forma de lista, porque son varios:
        // public List<Base64FileModel> Base64FileModel { get; set; }
        //y tendrán que adaptar al front para que mande un JSON acorde a esta estructura
    }
}
