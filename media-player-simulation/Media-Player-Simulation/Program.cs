using TwelfthConsoleApp;
using TwelfthConsoleApp.models;

IMediaPlayer audio = new AudioPlayer();
IMediaPlayer video = new VideoPlayer();

Console.WriteLine("Choose a media player:");
Console.WriteLine("1 - Audio");
Console.WriteLine("2 - Video");

while (true)
{
    string player = Console.ReadLine() ?? string.Empty;

    if (player == "1")
    {
        bool inAudio = true;
        while (inAudio)
        {
            Console.WriteLine("\nYou have entered the Audio Player...");
            Console.WriteLine("Now choose an action:");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Pause");
            Console.WriteLine("3 - Stop and go back");

            string action = Console.ReadLine() ?? string.Empty;

            if (action == "1")
                audio.Play();
            else if (action == "2")
                audio.Pause();
            else if (action == "3")
            {
                audio.Stop();
                inAudio = false;
            }
            else
                Console.WriteLine("Invalid action, try again.");
        }
    }
    else if (player == "2")
    {
        bool inVideo = true;
        while (inVideo)
        {
            Console.WriteLine("\nYou have entered the Video Player...");
            Console.WriteLine("Now choose an action:");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Pause");
            Console.WriteLine("3 - Stop and go back");

            string action = Console.ReadLine() ?? string.Empty;

            if (action == "1")
            {
                video.Play();
            }

            else if (action == "2")
            {
                video.Pause();
            }

            else if (action == "3")
            {
                video.Stop();
                inVideo = false;
            }

            else
            {
                Console.WriteLine("Invalid action, try again.");
            }
        }
    }

    else
    {
        Console.WriteLine("Exiting program...");
        break;
    }

    Console.WriteLine("\nChoose a media player:");
    Console.WriteLine("1 - Audio");
    Console.WriteLine("2 - Video");
    Console.WriteLine("Or type anything to leave");
}
