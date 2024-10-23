using System.ComponentModel.DataAnnotations;

namespace GalleryProject.Models
{
    public class WorkOfArtGroup
    {
        [Key]
        public int ID { get; set; }
        public bool Painting { get; set; }
        public bool Sculpture { get; set; }
        public bool Literature { get; set; }
        public bool Music { get; set; }
    }
}
