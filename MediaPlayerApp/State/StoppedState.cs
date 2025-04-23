using MediaPlayerApp.Application;

namespace MediaPlayerApp.State;

public class StoppedState: BaseState<MediaPlayer>
{
    public override void Play(MediaPlayer item)
    {
        throw new NotImplementedException();
    }

    public override void Pause(MediaPlayer item)
    {
        throw new NotImplementedException();
    }

    public override void Stop(MediaPlayer item)
    {
        throw new NotImplementedException();
    }
}