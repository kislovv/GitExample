using MediaPlayerApp.Data;
using MediaPlayerApp.Models;
using MediaPlayerApp.State;

namespace MediaPlayerApp.Application;

public class MediaPlayer
{
    private IRepository<IMediaItem> _repository;
    public event Action<string> OnStateChanged = (message) => {};
    private IPlaybackState<MediaPlayer> _playbackState = new PauseState();

    public MediaPlayer(IRepository<IMediaItem> repository)
    {
        _repository = repository;
    }

    public void ChangeState(PlayerState state)
    {
        _playbackState = _playbackState.ChangeState(state);
    }

    public void Pause()
    {
        _playbackState.Pause(this);
        OnStateChanged("pause");
    }
    
    public void Play()
    {
        _playbackState.Play(this);
        OnStateChanged("Play");
    }
    
    public void Stop()
    {
        _playbackState.Stop(this);
        OnStateChanged("Stop");
    }
}