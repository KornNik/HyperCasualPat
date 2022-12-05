using System.Collections.Generic;

namespace HyperCasual.Helpers
{
    sealed class AssetsPathLevel
    {
        public static readonly Dictionary<LevelTypes, string>
            LevelsPath = new Dictionary<LevelTypes, string>
            {
                {LevelTypes.LevelOne, "Prefabs/Levels/Prefabs_Levels_LevelOne" },
                {LevelTypes.LevelTwo, "Prefabs/Levels/Prefabs_Levels_LevelTwo"}
            };
    }
}
