using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.ScriptableObjects
{
    [CreateAssetMenu(fileName ="PlayerCharactersBundle",menuName ="Data/Bundles/Characters")]
    internal class PlayerCharactersBundle : ScriptableObject
    {
        [SerializeField] private GameObjectData<CharacterTypes>[] _characters;

        public GameObjectData<CharacterTypes>[] Characters => _characters;
    }
}
