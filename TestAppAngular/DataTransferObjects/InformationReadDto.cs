using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppAngular.DataTransferObjects
{
    public class InformationReadDto
    {
        public int Id { get; set; }
        public string HeadLine { get; set; }
        public string BreadText { get; set; }
        public string Footer { get; set; }
    }
}
