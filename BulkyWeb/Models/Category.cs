using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]    // Data Annotation--  it is used to specifically define a primary key if the name is other that Id.
        public int Id { get; set; }   // If name is Id, then it is automatically considered as primary key, but we can also explicitly specify it using [Key] attribute.
        [Required]   // Data Annotation-- it is used  to specify that the property is required and cannot be null or empty.
        [MaxLength(30 )]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Display Order must be Between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
