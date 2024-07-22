using System.ComponentModel.DataAnnotations.Schema;

namespace CyerXProTeste.Models
{   
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Table("Authors")]
    public class AuthorB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book Books { get; set; }
    }

}
