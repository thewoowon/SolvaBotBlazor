using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SolvaBot.Models
{
    public partial class TblComAddfiles
    {
        public string Code { get; set; }
        public string CompanyCode { get; set; }
        public string Fn { get; set; }
        public string Floc { get; set; }
        public long Fsize { get; set; }
        public string Fext { get; set; }
        public DateTime Wdate { get; set; }
    }
}
