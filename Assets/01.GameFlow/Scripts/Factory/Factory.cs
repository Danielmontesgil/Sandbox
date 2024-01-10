using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox.Factory
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(RectTransform parent);
    }
}
