using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.ViTube
{
    public class ViTubeRepository : IViTubeRepository
    {
        private Dictionary<string, Video> videoById = new Dictionary<string, Video>();
        private Dictionary<string, User> usersById = new Dictionary<string, User>();

        public bool Contains(User user)
        {
            return usersById.ContainsKey(user.Id);
        }

        public bool Contains(Video video)
        {
            return videoById.ContainsKey(video.Id);
        }

        public void DislikeVideo(User user, Video video)
        {
            if (!usersById.ContainsKey(user.Id) || !videoById.ContainsKey(video.Id))
            {
                throw new ArgumentException();
            }
            video.Dislikes += 1;
           
            user.Dislikes.Add(video.Id);
        }

        public IEnumerable<User> GetPassiveUsers()
        {
            return usersById.Values.Where(x => x.Likes.Count == 0 && x.Dislikes.Count == 0 && x.WatchedVideo.Count == 0);
        }

        public IEnumerable<User> GetUsersByActivityThenByName()
        {
            return usersById.Values.OrderByDescending(x => x.WatchedVideo.Count)
                .ThenByDescending(x => x.Likes.Count).ThenByDescending(x => x.Dislikes.Count).ThenBy(x => x.Username);
        }

        public IEnumerable<Video> GetVideos()
        {
           return videoById.Values;
        }

        public IEnumerable<Video> GetVideosOrderedByViewsThenByLikesThenByDislikes()
        {
            return videoById.Values.OrderByDescending(x => x.Views).ThenByDescending(x => x.Likes).ThenBy(x => x.Dislikes);
        }

        public void LikeVideo(User user, Video video)
        {
            if (!usersById.ContainsKey(user.Id) || !videoById.ContainsKey(video.Id))
            {
                throw new ArgumentException();
            }
            video.Likes += 1;
            
            user.Likes.Add(video.Id);
        }

        public void PostVideo(Video video)
        {
            videoById.Add(video.Id, video);
        }

        public void RegisterUser(User user)
        {
            usersById.Add(user.Id, user);
        }

        public void WatchVideo(User user, Video video)
        {
            if(!usersById.ContainsKey(user.Id) || !videoById.ContainsKey(video.Id))
            {
                throw new ArgumentException();
            }
            video.Views += 1;
            user.WatchedVideo.Add(video.Id);
        }
    }
}
