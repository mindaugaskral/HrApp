using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp.Models
{
    public class Candidate
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Note { get; set; }
        public DateTime ContactedFirstTime { get; set; }
        public DateTime AvalableFrom { get; set; }
        public string LinkedInLink { get; set; }
        public string Technologies { get; set; }
        public bool Avalable { get; set; }

    }
}
