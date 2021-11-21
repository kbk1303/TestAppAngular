using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppAngular.DataTransferObjects
{
    public class InformationUpdateDto
    {
        [Required]
        [MaxLength(80)]
        public string HeadLine { get; set; }

        [Required]
        [MaxLength(300)]
        public string BreadText { get; set; }

        [Required]
        [MaxLength(80)]
        public string Footer { get; set; }
    }
}
