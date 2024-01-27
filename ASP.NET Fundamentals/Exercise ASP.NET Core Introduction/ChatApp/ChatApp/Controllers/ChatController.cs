using ChatApp.Models.Chat;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
      private static readonly IList<KeyValuePair<string, string>> messages =
            new List<KeyValuePair<string, string>>();

        public IActionResult Show()
        {
            if(messages.Count < 1) 
            {
                return View(new ChatViewModel());
            }

            var chat = new ChatViewModel()
            {
                Messages = messages.Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value
                }).ToList(),
            };
            return View(chat);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat) 
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Show");
            }
            var newMessage = chat.CurrentMessage;
            messages.Add(new KeyValuePair<string, string>(newMessage.Sender, newMessage.MessageText));

            return RedirectToAction("Show");
        }
    }
}
