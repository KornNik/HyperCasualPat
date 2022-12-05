using System.Collections.Generic;

namespace HyperCasual.Helpers
{
    sealed class AssetsPathData
    {
        public static readonly Dictionary<DataTypes, string>
            DataPath = new Dictionary<DataTypes, string>
            {
                {DataTypes.CurrentSaveData, "ScriptableObjects/CurrentSaveData" },
            };
    }
}