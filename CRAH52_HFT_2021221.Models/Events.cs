using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Models
{
    [Table("events")]
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        
        [Required]
        public string EventName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string EventShortDesc { get; set; }  //Short description

        public Events Eventss { get; set; }     //ˇ
        [ForeignKey(nameof(Clubs))]             // 1:1 connections with Clubs table
        public int ClubID { get; set; }         //^
    }
}
