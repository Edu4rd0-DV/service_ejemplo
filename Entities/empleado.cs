using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entities
{    [DataContract]
    public class empleado
    {
        [DataMember(Order = 1)]
        public Int64 id { get; set; }
        [DataMember(Order = 2)]
        public string nombre { get; set; }
        [DataMember(Order = 3)]
        public string apellido { get; set; }
        [DataMember(Order = 4)]
        public DateTime fecha_nacimiento { get; set; }
        [DataMember(Order = 5)]
        public int sexo { get; set; }
        [DataMember(Order = 6)]
        public int dui { get; set; }
        [DataMember(Order = 7)]
        public string contacto { get; set; }
        [DataMember(Order = 8)]
        public string dirrecion { get; set; }
        [DataMember(Order = 9)]
        public int fk_cargo { get; set; }
        [DataMember(Order = 10)]
        public string nombresexo { get; set; }
        [DataMember (Order =11)]
        public string nombrecargo { get; set; }
    }
}
