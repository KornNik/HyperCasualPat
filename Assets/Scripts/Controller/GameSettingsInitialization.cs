using UnityEngine;
using HyperCasual.UI;

namespace HyperCasual.Controller
{
    internal class GameSettingsInitialization : IInitialization
    {
        public void Initialize()
        {
            QualitySettings.vSyncCount = 1;
            Application.targetFrameRate = 60;
            ScreenInterface.GetInstance().Execute(Helpers.ScreenTypes.MenuUI);
        }
    }
}
