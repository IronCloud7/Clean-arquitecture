namespace Assets.Scripts.Observer
{
    public interface Subject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}