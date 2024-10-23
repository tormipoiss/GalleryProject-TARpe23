using System.ComponentModel.DataAnnotations;

namespace GalleryProject.Models
{
    public class Gallery
    {
        [Key]
        public int ID { get; set; }
        public string ArtistName { get; set; }
        public string ArtistGender { get; set; }
        public int ArtistAge { get; set; }
        public bool ArtistAlive { get; set; }
    }
}
