using System.Collections.Generic;

namespace Interfaces_and_Polymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video ecoding logic
            // ...
            foreach (var channel in _notificationChannels)
                channel.Send(new Massage());
        }
        
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
} 