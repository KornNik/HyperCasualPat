using UnityEngine;
using HyperCasual.ScriptableObjects;

namespace HyperCasual.Movable
{
    internal class CharacterMove : IMovable
    {
        private Transform _transform;
        private CharacterParemeters _paremeters;
        private Vector3 _directionMovement;

        public CharacterMove(Transform transform, CharacterParemeters paremeters)
        {
            _transform = transform;
            _paremeters = paremeters;
        }

        public void Move(Vector3 position)
        {
            _directionMovement = position - _transform.position;

            _transform.Translate(_directionMovement * _paremeters.Speed * Time.fixedDeltaTime);
        }
    }
}
