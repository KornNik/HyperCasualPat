using HyperCasual.Movable;
using HyperCasual.Controller.Input;

namespace HyperCasual.Controller
{
    internal class PlayerController : IFixedExecute
    {

        private IInput _input;

        public PlayerController(IMovable motor)
        {
            _input = new CreatorInput().CheckDevice().CreateObject(motor);
            UnityMethodsController.Instance.AttachUpdate<PlayerController>(this);
        }

        #region IExecute

        public void FixedExecute()
        {
            _input.InputsEntry();
        }

        #endregion
    }
}
