using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    internal class CreatorToucheInput : ICreatorObject<IInput,IMovable>
    {
        public IInput CreateObject(IMovable motor)
        {
            return new TouchScreenInput(motor);
        }
    }
}
