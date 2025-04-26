using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<StudentSection>? StudentSections { get; set; } // Links to sections
    }
}