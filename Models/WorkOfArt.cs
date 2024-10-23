using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GalleryProject.Models
{
    public class WorkOfArt
    {
        [Key]
        public int ID { get; set; }
        public string WorkOfArtName { get; set; }
        public bool MadeByArtist { get; set; }
        [ForeignKey(nameof(Gallery.ID))]
        public int MadeByArtistID { get; set; }
        public string MadeBySomoneElseName { get; set; }
        [ForeignKey(nameof(Models.WorkOfArtGroup.ID))]
        public int WorkOfArtGroup { get; set; }
    }
}
