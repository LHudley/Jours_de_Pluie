using Jours_de_Pluie.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jours_de_Pluie.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategoryEnum MovieCategory { get; set; }
        public List<ActorMovie> Actor_Movies { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
    

