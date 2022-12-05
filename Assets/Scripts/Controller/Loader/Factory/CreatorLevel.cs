using UnityEngine;
using HyperCasual.Helpers;

namespace HyperCasual.Controller.Loader
{
    internal class CreatorLevel : ICreatorObject<GameObject, LevelTypes>
    {
        public GameObject CreateObject(LevelTypes levelType)
        {
            var resources = Resources.Load<GameObject>(AssetsPathLevel.LevelsPath[levelType]);
            return Object.Instantiate(resources, Vector3.zero, Quaternion.identity);
        }
    }
}
