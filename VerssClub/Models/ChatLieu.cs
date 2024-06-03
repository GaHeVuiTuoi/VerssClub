using System.ComponentModel.DataAnnotations;

namespace VerssClub.Models
{
    public class ChatLieu
    {
        [Key]
        public int MaChatLieu { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenChatLieu { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
