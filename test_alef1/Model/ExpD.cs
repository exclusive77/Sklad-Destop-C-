using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    class ExpD
    {[Key]
        public int Id { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public   Prods Prod{ get; set; }

        public int ExpId { get; set; }
        public Exp Exp { get; set; }
        public int Qty { get; set; }

        public decimal Price { get; set; }
        public decimal Sum { get ; set ; }
        
    }
}
