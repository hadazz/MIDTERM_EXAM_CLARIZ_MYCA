using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Section>? Sections { get; set; } // Links to sections
    }
}