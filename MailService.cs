using System;

namespace EventExample
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message sent with video title: " + args.Video.Title);
        }
    }
}
