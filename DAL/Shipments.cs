﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Shipments
    {
        public int shipmentNumber { get; set; }
        public string shipmentName { get; set; }
        public string dispatchPoint { get; set; }
        public string transportationPoint { get; set; }
        public int distance { get; set; }
        public int amount { get; set; }



    }
}
