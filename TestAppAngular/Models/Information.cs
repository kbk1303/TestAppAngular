using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestAppAngular.Models
{
    public class Information
    {
        public Information()
        {

        }
        public Information(int v1, string v2, string v3, string v4)
        {
            this.Id = v1;
            this.HeadLine = v2;
            this.BreadText = v3;
            this.Footer = v4;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(80)]
        [Required]
        public string HeadLine { get; set; }
        [MaxLength(300)]
        [Required]
        public string BreadText { get; set; }
        [MaxLength(80)]
        [Required]
        public string Footer { get; set; }

    }
}
