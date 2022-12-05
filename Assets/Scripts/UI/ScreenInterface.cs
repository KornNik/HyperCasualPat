using System;
using HyperCasual.Helpers;

namespace HyperCasual.UI
{
    internal sealed class ScreenInterface : IDisposable
    {

        private BaseUI _currentWindow;
        private readonly ScreenFactory _screenFactory;
        private static ScreenInterface _instance;

        private ScreenInterface()
        {
            _screenFactory = new ScreenFactory();
        }

        public BaseUI CurrentWindow => _currentWindow;

        public static ScreenInterface GetInstance()
        {
            return _instance ?? (_instance = new ScreenInterface());
        }

        public void Execute(ScreenTypes screenType)
        {
            if (CurrentWindow != null)
            {
                CurrentWindow.Hide();
            }

            switch (screenType)
            {
                case ScreenTypes.MenuUI:
                    _currentWindow = _screenFactory.GetMenuUI();
                    break;
                case ScreenTypes.GameUI:
                    _currentWindow = _screenFactory.GetGameUI();
                    break;

                default:
                    break;
            }

            CurrentWindow.Show();
        }

        public void AddObserver(ScreenTypes screenType, IListenerScreen listenerScreen)
        {
            switch (screenType)
            {
                case ScreenTypes.MenuUI:
                    _screenFactory.GetMenuUI().ShowUI += listenerScreen.ShowScreen;
                    _screenFactory.GetMenuUI().HideUI += listenerScreen.HideScreen;
                    _screenFactory.GetMenuUI().Hide();
                    break;
                case ScreenTypes.GameUI:
                    _screenFactory.GetGameUI().ShowUI += listenerScreen.ShowScreen;
                    _screenFactory.GetGameUI().HideUI += listenerScreen.HideScreen;
                    _screenFactory.GetGameUI().Hide();
                    break;

                default:
                    break;
            }
        }

        public void RemoveObserver(ScreenTypes screenType, IListenerScreen listenerScreen)
        {
            switch (screenType)
            {
                case ScreenTypes.MenuUI:
                    _screenFactory.GetMenuUI().ShowUI -= listenerScreen.ShowScreen;
                    _screenFactory.GetMenuUI().HideUI -= listenerScreen.HideScreen;
                    _screenFactory.GetMenuUI().Hide();
                    break;
                case ScreenTypes.GameUI:
                    _screenFactory.GetGameUI().ShowUI -= listenerScreen.ShowScreen;
                    _screenFactory.GetGameUI().HideUI -= listenerScreen.HideScreen;
                    _screenFactory.GetGameUI().Hide();
                    break;

                default:
                    break;
            }
        }


        #region IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
