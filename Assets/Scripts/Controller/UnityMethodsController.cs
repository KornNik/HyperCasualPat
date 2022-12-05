using HyperCasual.Helpers;

namespace HyperCasual.Controller
{
    sealed class UnityMethodsController : Singleton<UnityMethodsController>, IAttachUpdates
    {

        private ControllerInitializer _controllers;

        public static UnityMethodsController Instance
        {
            get
            {
                return (UnityMethodsController)_instanceSingleton;
            }
            set
            {
                _instanceSingleton = value;
            }
        }

        private void Start()
        {
            _controllers = new ControllerInitializer();
            Initialization();
        }

        private void Update()
        {
            for (var i = 0; i < _controllers.ExecutesLength; i++)
            {
                _controllers.Executes[i].Execute();
            }
        }
        private void FixedUpdate()
        {
            for (int i = 0; i < _controllers.FixedExecutesLenght; i++)
            {
                _controllers.FixedExecutes[i].FixedExecute();
            }
        }

        public void Cleaner()
        {
            _controllers.CleanUp();
        }

        public void Initialization()
        {
            _controllers.Initialize();
        }

        #region IAttacheUpdates

        public void AttachUpdate<T>(T update)
        {
            if(update is IFixedExecute)
            {
                var fixedExecute = (IFixedExecute)update;
                if (!_controllers.FixedExecutes.Contains(fixedExecute))
                {
                    _controllers.FixedExecutes.Add(fixedExecute);
                }
            }
            if (update is IExecute)
            {
                var execute = (IExecute)update;
                if (!_controllers.Executes.Contains(execute))
                {
                    _controllers.Executes.Add(execute);
                }
            }
        }
        public void DettachUpdate<T>(T update)
        {
            if (update is IFixedExecute)
            {
                var fixedExecute = (IFixedExecute)update;
                for (int i = 0; i < _controllers.FixedExecutesLenght; i++)
                {
                    if (fixedExecute == _controllers.FixedExecutes[i])
                    {
                        _controllers.FixedExecutes.Remove(fixedExecute);
                    }
                }
            }
            if (update is IExecute)
            {
                var execute = (IExecute)update;
                for (int i = 0; i < _controllers.ExecutesLength; i++)
                {
                    if (execute == _controllers.Executes[i])
                    {
                        _controllers.Executes.Remove(execute);
                    }
                }
            }
        }

        #endregion
    }
}