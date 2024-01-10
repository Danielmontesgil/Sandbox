using System.Collections;
using System.Collections.Generic;
using Sandbox.UI.Models;
using UnityEngine;

namespace Sandbox.UI
{
    public abstract class DialogPresenterBase: MonoBehaviour, IProduct
    {
        public string ProductName { get; set; }
        public abstract void Initialize();

        public virtual void OnActivate()
        {
            gameObject.SetActive(true);
        }

        public virtual void OnDeactivate()
        {
            gameObject.SetActive(false);
        }

        public virtual void OnRemove()
        {
            Destroy(this);
        }
    }
}
