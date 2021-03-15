using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071057_BuiVanManh.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "tentruong")]
        public string Tentruong { get; set; }
        [DataMember(Name = "hoten")]
        public string Hoten { get; set; }
        [DataMember(Name = "mssv")]
        public string Mssv { get; set; }
        [DataMember(Name = "lop")]
        public string Lop { get; set; }
    }
}