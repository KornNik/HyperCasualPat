using UnityEngine;

namespace HyperCasual.ScriptableObjects
{
    internal class GameObjectData<T> : ScriptableObject where T : System.Enum
    {
        [SerializeField] private T _gameObjectType;
        [SerializeField] private string _gameObjectName;
    }
}
