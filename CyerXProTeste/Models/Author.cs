using System.ComponentModel.DataAnnotations.Schema;

namespace CyerXProTeste.Models
{   
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
