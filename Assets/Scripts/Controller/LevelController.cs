using UnityEngine;
using HyperCasual.Unit;
using HyperCasual.Helpers;
using HyperCasual.Controller.Loader;
using HyperCasual.ScriptableObjects;

namespace HyperCasual.Controller
{
    internal class LevelController : Singleton<LevelController>
    {
        private GameObject _level;
        private UnitBehaviour _player;
        private CurrentGameData _currentGameData;

        public GameObject Level => _level;
        public UnitBehaviour Player => _player;

        public static LevelController Instance
        {
            get
            {
                return (LevelController)_instanceSingleton;
            }
            set
            {
                _instanceSingleton = value;
            }
        }

        private void Awake()
        {
            _currentGameData = Resources.Load<CurrentGameData>
                (AssetsPathData.DataPath[DataTypes.CurrentSaveData]);
        }

        public void LoadScene()
        {
            if (_level == null && _player == null)
            {
                var sceneCreator = new SceneCreator();
                _level = sceneCreator.LoadLevel().CreateObject(_currentGameData.CurrentLevel);
                _player = sceneCreator.LoadCharacter().CreateObject(_currentGameData.CurrentCharacter);
            }else
            {
                DestroyLevel();
                LoadScene();
            }
        }

        public void DestroyLevel()
        {
            Destroy(_level);
            Destroy(_player);
            _level = null;
            _player = null;
        }
    }
}
