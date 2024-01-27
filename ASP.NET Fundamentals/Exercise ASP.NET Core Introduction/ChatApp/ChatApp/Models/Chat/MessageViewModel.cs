using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models.Chat
{
    public class MessageViewModel
    {
        [Required]
        public string Sender { get; set; } = null!;

        [Required]
        public string MessageText { get; set; } = null!;
    }
}
