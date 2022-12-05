using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.UI
{
    sealed class ScreenFactory
    {
        private MenuUI _menuUI;
        private GameUI _gameUI;
        //private PauseUI _pauseUI;

        private Canvas _canvas;

        public ScreenFactory()
        {
            var resources = Resources.Load<Canvas>(AssetsPathGameObject.GameObjects[GameObjectType.Canvas]);
            _canvas = Object.Instantiate(resources, Vector3.one, Quaternion.identity);
        }

        public MenuUI GetMenuUI()
        {
            if (_menuUI == null)
            {
                var resources = Resources.Load<MenuUI>(AssetsPathScreen.Screens[ScreenTypes.MenuUI]);
                _menuUI = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
            }
            return _menuUI;
        }
        public GameUI GetGameUI()
        {
            if (_gameUI == null)
            {
                var resources = Resources.Load<GameUI>(AssetsPathScreen.Screens[ScreenTypes.GameUI]);
                _gameUI = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
            }
            return _gameUI;
        }
    }
}