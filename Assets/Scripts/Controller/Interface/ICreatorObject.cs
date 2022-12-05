namespace HyperCasual.Controller
{
    interface ICreatorObject<T,U>
    {
        T CreateObject(U objectType);
    }
}
