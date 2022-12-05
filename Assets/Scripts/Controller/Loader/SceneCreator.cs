using UnityEngine;
using HyperCasual.Unit;
using HyperCasual.Helpers;
using HyperCasual.Movable;

namespace HyperCasual.Controller.Loader
{
    internal class SceneCreator
    {
        ICreatorObject<IInput, IMovable> _iCreator;

        public ICreatorObject<UnitBehaviour,CharacterTypes> LoadCharacter()
        {
            return new CreatorCharacter();
        }
        public ICreatorObject<GameObject, LevelTypes> LoadLevel()
        {
            return new CreatorLevel();
        }
    }
}
