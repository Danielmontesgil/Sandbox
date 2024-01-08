using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox
{
    public enum UILayer
    {
        Game,
        Debug
    }
    
    public class UIFactory : MonoBehaviour
    {
        [SerializeField] private List<RectTransform> UILayers;
        public IProduct GetProduct(UILayer layer, string dialogName)
        {
            var prefab = Resources.Load<GameObject>($"UI/Dialogs/{dialogName}");
            // create a Prefab instance and get the product component
            GameObject instance = Instantiate(prefab, GetUIRoot(layer));
            var newProduct = instance.GetComponent<IProduct>();

            // each product contains its own logic
            newProduct.Initialize();

            return newProduct;
        }

        private RectTransform GetUIRoot(UILayer layer)
        {
            switch (layer)
            {
                case UILayer.Game:
                    return UILayers[0];
                case UILayer.Debug:
                    return UILayers[1];
                default:
                    throw new ArgumentOutOfRangeException(nameof(layer), layer, null);
            }
        }
    }
}
