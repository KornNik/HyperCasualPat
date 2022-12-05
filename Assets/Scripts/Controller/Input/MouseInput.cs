using UnityEngine;
using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    internal class MouseInput : PlayerInput
    {
        public MouseInput(IMovable motor) : base(motor)
        {
            _motor = motor;
        }

        public override void InputsEntry()
        {
            if (UnityEngine.Input.GetMouseButton(0))
            {
                var ray = _camera.ScreenPointToRay(UnityEngine.Input.mousePosition);
                if (Physics.Raycast(ray.origin, ray.direction, out _hit, 200f, LayerMask.GetMask("Ground")))
                {
                    MoveToTap(_hit.point);
                }
            }
        }
    }
}
