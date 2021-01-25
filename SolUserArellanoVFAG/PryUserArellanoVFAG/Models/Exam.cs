using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryUserArellanoVFAG.Models
{
    public class Exam
    {
        [key]
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Su texto ente 5 y 80 choco", MinimumLength = 5)]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string street { get; set; }
        [Required]
        public string Suite { get; set; }
        [Required]
        public string city{ get; set; }
        [Required]
        public double lat { get; set; }
        [Required]
        public double lng { get; set; }
        [Required]
        public string phone { get; set; }
        public string website { get; set; }
        public string company { get; set; }
        [Required]
        public string cathPhrase { get; set; }

    }
}