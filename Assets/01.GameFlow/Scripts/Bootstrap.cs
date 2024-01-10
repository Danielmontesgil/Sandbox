using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox
{
    public class Bootstrap : MonoBehaviour
    {
        void Start()
        {
            GameManager.Instance.GameUIManager.AddDialog(UILayer.Game, "LoadingDialog");
        }
    }
}
