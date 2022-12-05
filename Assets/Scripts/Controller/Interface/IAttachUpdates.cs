namespace HyperCasual.Controller
{
    interface IAttachUpdates
    {
        void AttachUpdate<T>(T update);
        void DettachUpdate<T>(T update);
    }
}
