using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelParameters", menuName = "Data/Parameters/Level")]
    internal class LevelParameters : ScriptableObject
    {
        [SerializeField] private LevelData _levelData;
        [SerializeField] private Vector3 _characterPosition;

        public LevelData LevelData => _levelData;
        public Vector3 CharacterPosition => _characterPosition;
    }
}
