using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace _5951071057_BuiVanManh.Models
{
    public class WeatherInfo
    {
        [DataMember(Name ="Location")]
        public string Location { get; set; }
        [DataMember(Name = "dagree")]
        public float Degree { get; set; }
        [DataMember(Name = "dateTime")]
        public DateTime DateTime { get; set; }
       
    }
}