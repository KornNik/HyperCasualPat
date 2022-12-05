using UnityEngine;
using HyperCasual.Movable;

namespace HyperCasual.Controller.Input
{
    internal class CreatorInput
    {
        private ICreatorObject<IInput, IMovable> _iCreator;

        public ICreatorObject<IInput, IMovable> CheckDevice()
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                return new CreatorToucheInput();
            }
            else
            {
                return new CreatorMouseInput();
            }
        }
    }
}
