using System.Collections.Generic;

namespace HyperCasual.Helpers
{
    internal sealed class AssetsPathGameObject
    {
        public static readonly Dictionary<GameObjectType, string> 
            GameObjects = new Dictionary<GameObjectType, string>
        {
            {
                GameObjectType.Canvas, "Prefabs/UI/Prefabs_UI_Canvas"
            },
        };
    }
}
