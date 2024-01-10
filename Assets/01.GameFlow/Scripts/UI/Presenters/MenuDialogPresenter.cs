using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Sandbox.UI.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Sandbox.UI.Presenters
{
    public class MenuDialogPresenter : DialogPresenterBase
    {
        [Header("View")]
        
        [SerializeField] 
        private Button playButton;

        private MenuDialogModel _model;
        
        public override void Initialize()
        {
            playButton.gameObject.transform.DOShakeScale(2);
        }
    }
}
