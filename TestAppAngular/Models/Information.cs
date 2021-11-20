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
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string HeadLine { get; set; }
        [MaxLength(300)]
        public string BreadText { get; set; }
        [MaxLength(80)]
        public string Footer { get; set; }

    }
}
