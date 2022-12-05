using System;
using UnityEngine;

namespace HyperCasual.UI
{
    abstract class BaseUI : MonoBehaviour
    {
        public Action ShowUI = delegate { };
        public Action HideUI = delegate { };
        public abstract void Show();
        public abstract void Hide();
    }
}