using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebApi.DataTransferObject
{
    public class TitlesDTO // Data Transfer Object
    {
        public string type { get; set; }
        public string pub_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> advance { get; set; }
        public string TypePrice { get; set; }
    }
}