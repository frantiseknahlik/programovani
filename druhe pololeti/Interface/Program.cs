var p = new MusicPlayer();
PlayAnWritteInfo(p);

void PlayAnWritteInfo(IPlayable p)
{
    Console.WriteLine("Some info");
    p.play();
}


interface IPlayable
{
    void play();
    void Pause();
}

interface ILoggable
{
    void LogInfo();
}

class MusicPlayer : IPlayable
{
    public void play()
    {
        
    }

    public void Pause()
    {
        
    }
}

