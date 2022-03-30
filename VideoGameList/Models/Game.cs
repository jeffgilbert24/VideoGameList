using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameList.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage ="Enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter a yea.r")]
        [Range(1889, 2999, ErrorMessage ="Year must be after 1889.")]
        public int year { get; set; }

        [Required(ErrorMessage ="Enter a rating.")]
        [Range(1, 5, ErrorMessage ="Rating must be between 1 and 5. ")]
        public int Rating { get; set; }
    }
}
