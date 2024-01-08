using DG.Tweening;
using Sandbox.UI.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Sandbox.UI.Presenters
{
    public class LoadingDialogPresenter : DialogPresenterBase
    {
        [Header("View")]
        
        [SerializeField] 
        private Image fillBar;

        private LoadingDialogModel _model;
        
        public override void Initialize()
        {
            _model = new LoadingDialogModel();
            
            FakeLoadingBarProgress();
        }

        private void FakeLoadingBarProgress()
        {
            fillBar.DOFillAmount(1, 3).onComplete = () =>
            {
                GameManager.Instance.GameUIManager.PopAllDialogs();
                GameManager.Instance.GameUIManager.AddDialog(UILayer.Game, "Menu");
            };
            _model.UpdateData();
        }
    }
}
