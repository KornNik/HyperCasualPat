using UnityEngine;
using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    class TouchScreenInput : PlayerInput
    {
        private Touch[] _touches;

        public TouchScreenInput(IMovable motor) : base(motor)
        {
            _motor = motor;
        }

        public override void InputsEntry()
        {
            if (UnityEngine.Input.touchCount > 0)
            {
                _touches = UnityEngine.Input.touches;
                var ray = _camera.ScreenPointToRay(_touches[0].position);
                if (Physics.Raycast(ray.origin, ray.direction, out _hit, 200f, LayerMask.GetMask("Ground")))
                {
                    MoveToTap(_hit.point);
                }
            }
        }
    }
}
