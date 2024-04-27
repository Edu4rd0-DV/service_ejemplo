using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entities
{    [DataContract]
    public class usuario
    {
        [DataMember (Order =1)]
        public Int64 id { get; set; }
        [DataMember(Order =2)]
        public string nickmane { get; set; }
        [DataMember (Order =3)]
        public string  pass { get; set; }
        [DataMember (Order =4)]
        public int fk_empleado { get; set; }
        //
        [DataMember (Order = 5)]
        public int dui { get; set; }
    }
}
