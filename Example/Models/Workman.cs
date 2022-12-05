using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Workman
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)] 
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Required]
        [Range(25,55,ErrorMessage ="Bu iş için yaşınız yeterlli değil.")]
        [DisplayName("Yıl")]
        public int Age { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Bu iş için tecrübeniz yeterlli değil.")]
        [DisplayName("Toplam Çalışma Yılı")]
        public int Experience { get; set; }   

    }
}
