﻿namespace Jours_de_Pluie.Models
{
    public class ActorMovie
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
   
}
