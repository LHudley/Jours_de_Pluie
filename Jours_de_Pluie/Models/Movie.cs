using Jours_de_Pluie.Data.Enums;

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
        

    }
}
