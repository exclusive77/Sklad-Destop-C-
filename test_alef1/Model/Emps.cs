using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_alef1.Model
{
    class Emps
    {
        public int Id { get; set; }
        [Display(Name ="Имя Служащего")]
        public string EmpName { get; set; }
      [Display(Name ="ИИН")]
        public string TaxCode { get; set; }
    }
}
