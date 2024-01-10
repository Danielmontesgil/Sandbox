using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox.UI.Models
{
    public class LoadingDialogModel : IDialogModel
    {
        private bool isDataLoaded;
        public bool IsDataLoaded => isDataLoaded;

        public  void UpdateData()
        {
            isDataLoaded = true;
        }
    }
}
