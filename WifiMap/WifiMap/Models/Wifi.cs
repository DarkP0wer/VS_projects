using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WifiMap.Models
{
    public class Wifi
    {
        [Key]
        public long Time { get; set; }
        public string SSID { get; set; }
        public string Description { get; set; }
        public double GeoLong { get; set; }
        public double GeoLat { get; set; }
    }
}
