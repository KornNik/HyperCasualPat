using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.Helpers
{
    sealed class AssetsPathScreen : MonoBehaviour
    {

        public static readonly Dictionary<ScreenTypes, string>
            Screens = new Dictionary<ScreenTypes, string>
            {
                {ScreenTypes.MenuUI, "Prefabs/UI/Prefabs_UI_MenuUI" },
                {ScreenTypes.GameUI, "Prefabs/UI/Prefabs_UI_GameUI"},
                {ScreenTypes.PauseUI, "Prefabs/UI/Prefabs_UI_PauseUI" }
            };
    }
}