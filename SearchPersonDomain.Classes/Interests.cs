using System.ComponentModel.DataAnnotations;

namespace SearchPersonDomain.Classes
{
    public class Interests
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InterestType Type { get; set; }
        [Required]
        public Person Person { get; set; }
    }
}
