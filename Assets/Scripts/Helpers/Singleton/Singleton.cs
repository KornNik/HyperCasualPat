using UnityEngine;

namespace HyperCasual.Helpers
{
    class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private bool _alive = true;
        private static T _instance;

        public static bool IsAlive
        {
            get
            {
                if (_instance == null)
                    return false;
                return _instance._alive;
            }
        }

        private void OnEnable()
        {
            if (!_instance)
            {
                T[] managers = FindObjectsOfType(typeof(T)) as T[];

                if (managers != null)
                {
                    if (managers.Length == 1)
                    {
                        _instance = managers[0];
                        DontDestroyOnLoad(_instance.gameObject);
                        return;
                    }
                    else if (managers.Length > 1)
                    {
                        for (int i = 1; i < managers.Length; ++i)
                        {
                            T manager = managers[i];
                            Destroy(manager.gameObject);
                        }
                        _instance = managers[0];
                        DontDestroyOnLoad(_instance.gameObject);
                    }
                }
            }
        }
        private void OnDestroy() { _alive = false; }
        private void OnApplicationQuit() { _alive = false; }

        protected static Singleton<T> _instanceSingleton
        {
            get
            {
                if (!_instance)
                {
                    T[] managers = FindObjectsOfType(typeof(T)) as T[];

                    if (managers != null)
                    {
                        if (managers.Length == 1)
                        {
                            _instance = managers[0];
                            return _instance;
                        }
                        else if (managers.Length > 1)
                        {
                            for (int i = 0; i < managers.Length; ++i)
                            {
                                T manager = managers[i];
                                Destroy(manager.gameObject);
                            }
                        }
                    }

                    GameObject gameObject = new GameObject(typeof(T).Name, typeof(T));
                    _instance = gameObject.GetComponent<T>();
                    DontDestroyOnLoad(_instance.gameObject);
                }
                return _instance;
            }
            set { _instance = value as T; }
        }
    }
}
