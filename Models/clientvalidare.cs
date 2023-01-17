using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [MetadataType(typeof(clientmetadata))]
    public partial class client
    {
        public class clientmetadata
        {
            [DisplayName("Nume Client")]
            public string numeclient { get; set; }
            [DisplayName("Adresa")]
            public string adresa { get; set; }
            [DisplayName("Numar Telefon")]
            public Nullable<int> telefon { get; set; }
        }

    }
}