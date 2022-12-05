using System.Collections.Generic;

namespace HyperCasual.Controller
{
    sealed class ControllerInitializer : IInitialization, ICleanUp
    {
        private ICleanUp[] _cleanUps;
        private IInitialization[] _initializations;

        private List<IExecute> _executes;
        private List<IFixedExecute> _fixedExecutes;

        public int ExecutesLength => _executes.Count;
        public int FixedExecutesLenght => _fixedExecutes.Count;
        public List<IExecute> Executes => _executes;
        public List<IFixedExecute> FixedExecutes => _fixedExecutes;


        public ControllerInitializer()
        {
            _executes = new List<IExecute>();

            _fixedExecutes = new List<IFixedExecute>();

            _initializations = new IInitialization[1];
            _initializations[0] = new GameSettingsInitialization();

            _cleanUps = new ICleanUp[0];
        }


        #region IInitialization

        public void Initialize()
        {
            for (var i = 0; i < _initializations.Length; i++)
            {
                var initialization = _initializations[i];
                initialization.Initialize();
            }
            for (var i = 0; i < _executes.Count; i++)
            {
                var execute = _executes[i];
                if (execute is IInitialization initialization)
                {
                    initialization.Initialize();
                }
            }
            for (var i = 0; i < _fixedExecutes.Count; i++)
            {
                var fixedExecutes = _fixedExecutes[i];
                if (fixedExecutes is IInitialization initialization)
                {
                    initialization.Initialize();
                }
            }
        }

        #endregion


        #region ICleanUp

        public void CleanUp()
        {
            for (var index = 0; index < _cleanUps.Length; index++)
            {
                var cleanUp = _cleanUps[index];
                cleanUp.CleanUp();
            }
        }

        #endregion
    }
}