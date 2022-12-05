using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelsBundle", menuName = "Data/Bundles/Levels")]
    internal class LevelsBundle : ScriptableObject
    {
        [SerializeField] private GameObjectData<LevelTypes>[] _levels;

        public GameObjectData<LevelTypes>[] Levels => _levels;
    }
}
