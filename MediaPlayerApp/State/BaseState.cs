using System.Collections;

namespace MediaPlayerApp.State;

public abstract class BaseState<T> : IPlaybackState<T>
{
    public IPlaybackState<T> ChangeState(PlayerState newState)
    {
        return newState switch
        {
            PlayerState.Stop => (IPlaybackState<T>)new StoppedState(),
            PlayerState.Play => (IPlaybackState<T>)new PlayState(),
            PlayerState.Pause => (IPlaybackState<T>)new PauseState(),
            _ => throw new ArgumentOutOfRangeException(nameof(newState), newState, null)
        };
    }

    public abstract void Play(T item);

    public abstract void Pause(T item);

    public abstract void Stop(T item);
}