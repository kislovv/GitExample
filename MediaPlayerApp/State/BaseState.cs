namespace MediaPlayerApp.State;

public abstract class BaseState<T> : IPlaybackState<T>
{
    public IPlaybackState<T> ChangeState(PlayerState newState)
    {
        return newState switch
        {
            PlayerState.Stop => throw new System.NotImplementedException(),
        };
    }

    public abstract void Play(T item);

    public abstract void Pause(T item);

    public abstract void Stop(T item);
}