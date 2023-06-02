namespace task5
{
    public interface ITransport
    {
        int capacity { get; set; }
        void move();
        void stop();
    }

}