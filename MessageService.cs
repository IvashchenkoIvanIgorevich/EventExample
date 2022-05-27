using System;

namespace EventExample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail sent with video title: " + args.Video.Title);
        }
    }
}
