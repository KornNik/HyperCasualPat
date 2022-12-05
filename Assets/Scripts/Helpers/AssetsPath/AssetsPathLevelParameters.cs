using System.Collections.Generic;

namespace HyperCasual.Helpers
{
    sealed class AssetsPathLevelParameters
    {
        public static readonly Dictionary<LevelTypes, string>
            LevelParametersPath = new Dictionary<LevelTypes, string>
            {
                {LevelTypes.LevelOne,"ScriptableObjects/Levels/LevelOneParameters" }
            };
    }
}
