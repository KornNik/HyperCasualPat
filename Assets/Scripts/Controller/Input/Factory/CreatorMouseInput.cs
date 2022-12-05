using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    internal class CreatorMouseInput : ICreatorObject<IInput, IMovable>
    {
        public IInput CreateObject(IMovable motor)
        {
            return new MouseInput(motor);
        }
    }
}
