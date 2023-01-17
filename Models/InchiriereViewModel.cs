using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class InchiriereViewModel
    {
        public int id { get; set; }
        public string masinaid { get; set; }
        public Nullable<int> clientid { get; set; }
        public Nullable<int> pret { get; set; }
        public Nullable<System.DateTime> sdata { get; set; }
        public Nullable<System.DateTime> edate { get; set; }

        public string disponibilitate { get; set; }





    }
}