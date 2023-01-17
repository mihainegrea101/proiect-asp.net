using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [MetadataType(typeof(inrmasinaMetaData))]
    public partial class inrmasina
    {
        public class inrmasinaMetaData
        {
            [DisplayName("Numar Masina")]
            public string nrmasina { get; set; }
            [DisplayName("Marca")]
            public string marca { get; set; }
            [DisplayName("Model")]
            public string model { get; set; }
            [DisplayName("Disponibilitate")]
            public string disponibilitate { get; set; }
        }
    }
}