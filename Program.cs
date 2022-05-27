namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "NewVideo" };
            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encoded(video);
        }
    }
}
