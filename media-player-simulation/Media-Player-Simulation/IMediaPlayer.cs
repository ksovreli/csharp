namespace TwelfthConsoleApp
{
    internal interface IMediaPlayer
    {
        uint Volume { get; set; }
        void Play();
        void Pause();
        void Stop();
    }
}
