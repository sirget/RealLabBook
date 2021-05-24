using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RealLabBook.Models
{
    public class Tool
    {
        [Key]
        [Required]
        public int ToolID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Toolname { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
