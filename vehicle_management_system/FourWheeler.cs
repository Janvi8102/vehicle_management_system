using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system
{
    public class FourWheeler : TwoWheeler
    {
        public int SpeakerCount { get; set;}
        public int WindowCount { get; set; }
        public int SeatBeltCount { get; set; }
        public int DiscBrakeCount { get; set; }
    }
}
