using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Models
{
    [Table("guests")]
    public class Guests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int BirthYear { get; set; }

        public virtual ICollection<Guests> Guest { get; set; } // REVERSE navigation property ( this is the N side)
    }

}
