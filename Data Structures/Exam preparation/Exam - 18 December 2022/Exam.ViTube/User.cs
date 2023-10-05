using System.Collections.Generic;

namespace Exam.ViTube
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }
        
        public List<string> Likes { get; set; }

        public List<string> WatchedVideo { get; set; }

        public List<string> Dislikes { get; set; }
        public User(string id, string username)
        {
            Id = id;
            Username = username;
            this.Dislikes = new List<string>();
            this.Likes = new List<string>();
            this.WatchedVideo = new List<string>();
        }
    }
}
