namespace HyperCasual.Helpers
{
    internal interface IObserver<T>
    {
        void UpdateObserver(T info);
    }
}
