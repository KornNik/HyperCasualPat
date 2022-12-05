using UnityEngine;
using HyperCasual.Unit;
using HyperCasual.Helpers;
using HyperCasual.ScriptableObjects;

namespace HyperCasual.Controller.Loader
{
    internal class CreatorCharacter : ICreatorObject<UnitBehaviour, CharacterTypes>
    {
        public UnitBehaviour CreateObject(CharacterTypes characterType)
        {
            var currentLevelParameters = Resources.Load<LevelParameters>
                (AssetsPathLevelParameters.LevelParametersPath
                [Resources.Load<CurrentGameData>
                (AssetsPathData.DataPath[DataTypes.CurrentSaveData]).CurrentLevel]
                );
            var resources = Resources.Load<UnitBehaviour>(AssetsPathCharacter.CharactersPath[characterType]);
            return Object.Instantiate(resources, currentLevelParameters.CharacterPosition, Quaternion.identity);
        }
    }
}
