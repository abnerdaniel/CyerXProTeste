using System.ComponentModel.DataAnnotations.Schema;

namespace CyerXProTeste.Models
{
    [Table("Books")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }


}
