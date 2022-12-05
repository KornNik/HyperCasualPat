using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.ScriptableObjects
{
    [CreateAssetMenu(fileName ="CurrentSaveData",menuName ="Data/Saves/CurrentSaveData")]
    class CurrentGameData : ScriptableObject
    {
        public CharacterTypes CurrentCharacter;
        public LevelTypes CurrentLevel;
    }
}