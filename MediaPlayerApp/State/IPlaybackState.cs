namespace MediaPlayerApp.State;

public interface IPlaybackState<in T>
{
    IPlaybackState<T> ChangeState(PlayerState newState);
    void Play(T item);
    void Pause(T item);
    void Stop(T item);
}