using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Models
{
    [Table("clubs")]
    public class Clubs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClubID { get; set; }
        [Required]
        public string ClubName { get; set; }
        [Required]
        public string President { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        public int? BaseTicketPrice { get; set; }
        [Required]
        public int Capacity { get; set; }
        [NotMapped]
        public Clubs Club { get; set; }     // ˇ
        [ForeignKey(nameof(Guests))]        // Navigation property 1 side ( GUESTS TABLE)
        public int GuestID { get; set; }    // ^

        [ForeignKey(nameof(Events))]
        public int EventID { get; set; }

    }
}
