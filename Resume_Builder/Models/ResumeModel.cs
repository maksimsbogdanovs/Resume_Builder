using System;
using System.ComponentModel.DataAnnotations;

namespace Resume_Builder.Models
{
    public class ResumeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
  
        public string Phone { get; set; }
    
        public string Adress { get; set; }
    
        public string City { get; set; }
 
        public string Country { get; set; }

        public string Indexx { get; set; }
 
        public string University { get; set; }
 
        public string Study { get; set; }
 
        public string Degree { get; set; }

        public int StudyTimeFrom { get; set; }
  
        public int StudyTimeTo { get; set; }

        public string Job { get; set; }

        public string Title { get; set; }
 
        public string Description { get; set; }
     
        public int? WorkTimeFrom { get; set; }
  
        public int? WorkTimeTo { get; set; }
    }
}
