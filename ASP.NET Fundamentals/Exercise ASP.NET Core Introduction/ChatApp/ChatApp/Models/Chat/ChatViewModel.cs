namespace ChatApp.Models.Chat
{
    public class ChatViewModel
    {
        
        public MessageViewModel CurrentMessage { get; set; } = null!;

        public ICollection<MessageViewModel> Messages { get; set; } = null!;
    }
}
