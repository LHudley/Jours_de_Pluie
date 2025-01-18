using System.ComponentModel.DataAnnotations;

namespace Jours_de_Pluie.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        
        public string ProfilePicture { get; set; }
        
        public string FullName { get; set; }
       
        public string Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
