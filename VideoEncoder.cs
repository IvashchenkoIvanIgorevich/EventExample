using System;
using System.Threading;

namespace EventExample
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encoded(Video video)
        {
            // Some logic
            // ...

            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
