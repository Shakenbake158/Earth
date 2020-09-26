using Earth.Core;

namespace Earth.Renderer
{
    public enum SynchronizationStatus
    {
        Unsignaled,
        Signaled
    }

    public enum ClientWaitResult
    {
        AlreadySignaled,
        Signaled,
        TimeoutExpired
    }

    public abstract class Fence : Disposable
    {
        public abstract void ServerWait();
        public abstract ClientWaitResult ClientWait();
        public abstract ClientWaitResult ClientWait(int timeoutInNanoseconds);
        public abstract SynchronizationStatus Status();
    }
}