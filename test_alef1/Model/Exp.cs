using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    class Exp
    {[Key]
        public int Id { get; set; }
        public DateTime DocData { get; set; }

        public int EmpsId { get; set; }
        public Emps Emps { get; set; }
      

    }
}
