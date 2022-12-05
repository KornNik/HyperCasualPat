using UnityEngine;

namespace HyperCasual.ScriptableObjects
{
    [CreateAssetMenu(fileName ="CharacterParameters",menuName ="Data/Parameters/Character")]
    internal class CharacterParemeters : ScriptableObject
    {
        [SerializeField] private float _speed;

        public float Speed => _speed;
    }
}
