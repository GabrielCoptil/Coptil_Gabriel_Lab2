using System.ComponentModel.DataAnnotations;

namespace Coptil_Gabriel_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string FirstName { get; set; }
        public string LastName{ get; set; }
    public ICollection<Book>? Books { get; set; }
}
}
