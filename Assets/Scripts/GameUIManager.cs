using System.Collections;
using System.Collections.Generic;
using Sandbox.UI;
using UnityEngine;

namespace Sandbox
{
    public class GameUIManager
    {
        private UIFactory _uiFactory;
        private Stack<DialogPresenterBase> _dialogsStack;

        public GameUIManager()
        {
            _dialogsStack = new Stack<DialogPresenterBase>();
            _uiFactory = GameObject.Find("Bootstrap").GetComponent<UIFactory>();
        }

        public void AddDialog(UILayer layer, string dialogName)
        {
            if (_dialogsStack.Count > 0)
            {
                var dialog = _dialogsStack.Peek();
                dialog.OnDeactivate();
            }
            var product = _uiFactory.GetProduct(layer, dialogName);
            product.Initialize();
            _dialogsStack.Push(product as DialogPresenterBase);
        }

        public void PopAllDialogs()
        {
            while (_dialogsStack.Count > 0)
            {
                var dialog = _dialogsStack.Pop();
                dialog.OnRemove();
            }
        }

        public void PopDialog()
        {
            if (_dialogsStack.Count > 0)
            {
                var dialogToRemove = _dialogsStack.Pop();
                dialogToRemove.OnRemove();
            }

            if (_dialogsStack.Count > 0)
            {
                var currentDialog = _dialogsStack.Peek();
                currentDialog.OnActivate();
            }
        }
    }
}
