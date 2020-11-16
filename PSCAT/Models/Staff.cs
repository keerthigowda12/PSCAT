using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PSCAT.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Column("StaffID")]
        public string StaffID { get; set; }

        [Column("StaffName")]
        public string StaffName { get; set; }
    }
}
