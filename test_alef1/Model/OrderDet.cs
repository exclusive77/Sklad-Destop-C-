﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    class OrderDet
    { private decimal sumVal;
        public int ProdId { get; set; }
        public string ProdName { get; set; }


        public int Qty { get; set; }

        public decimal Price { get; set; }
        public decimal Sum { get { return sumVal = Qty * Price; } set { sumVal = value; } }
    }
}
