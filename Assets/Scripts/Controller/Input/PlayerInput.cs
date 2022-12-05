using UnityEngine;
using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    abstract class PlayerInput : IInput
    {
        protected IMovable _motor;
        protected Camera _camera;
        protected RaycastHit _hit;

        public PlayerInput(IMovable motor)
        {
            _motor = motor;
            _camera = Camera.main;
        }

        protected void MoveToTap(Vector3 position)
        {
            _motor.Move(position);
        }

        public abstract void InputsEntry();
    }
}
