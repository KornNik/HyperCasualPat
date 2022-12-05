using UnityEngine;
using HyperCasual.Movable;
using HyperCasual.Helpers;
using HyperCasual.Controller;
using HyperCasual.ScriptableObjects;

namespace HyperCasual.Unit
{
    class UnitBehaviour : Singleton<UnitBehaviour>
    {
        [SerializeField]private CharacterParemeters _paremeters;

        protected IMovable _motor;
        protected PlayerController _controller;

        public IMovable Motor => _motor;

        public static UnitBehaviour Instance
        {
            get
            {
                return (UnitBehaviour)_instanceSingleton;
            }
            set
            {
                _instanceSingleton = value;
            }
        }

        protected virtual void Awake()
        {
            _motor = new CharacterMove(transform, _paremeters);
            _controller = new PlayerController(_motor);
        }
    }
}
