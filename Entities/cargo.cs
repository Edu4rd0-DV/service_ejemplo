﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Entities
{
    [DataContract]
     public  class cargo
    {   
        [DataMember (Order =1)]
        public int id{ get; set; }
        [DataMember (Order = 2)]
        public string nombre { get; set; }
        [DataMember (Order =3)]
        public string descripcion { get; set; }

    }

}
