using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entities
{
    [DataContract]
    public class bitacora
    {
        [DataMember(Order = 1)]
        public int id { get; set; }
        [DataMember(Order = 2)]
        public string actividad { get; set; }
        [DataMember(Order = 3)]
        public string fecha_hora { get; set; }
        [DataMember(Order = 4)]
        public Int64  fk_usuario { get; set; }
        //--------------
        [DataMember (Order =5)]
        public string  nickname { get; set; }
    }
}
