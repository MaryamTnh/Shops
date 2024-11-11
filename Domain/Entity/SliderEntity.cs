using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class SliderEntity : BaseEntity
    {
        public string? Title { get; set; }
        public string? Link { get; set; }
        public string? Image { get; set; }
    }
}
