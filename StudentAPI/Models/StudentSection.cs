using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class StudentSection
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
    }
}
