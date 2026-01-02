namespace TwelfthConsoleApp.models
{
    internal class VideoPlayer : IMediaPlayer
    {
        public uint Volume { get; set; }

        public void Play()
        {
            Console.WriteLine($"Video started playing.");
        }

        public void Pause()
        {
            Console.WriteLine($"Video paused.");
        }

        public void Stop()
        {
            Console.WriteLine($"Video stopped playing.");
        }
    }
}
