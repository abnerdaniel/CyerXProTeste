using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades
{   
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
