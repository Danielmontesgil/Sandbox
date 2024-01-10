using UnityEngine;

namespace Sandbox
{
    public class ExecutionOrder : MonoBehaviour
    {
        private bool _updateFlag;
        private bool _lateUpdateFlag;
        private bool _onGUIFlag;
        
        void Awake()
        {
            Debug.Log("This is the Awake method");
        }

        private void OnEnable()
        {
            Debug.Log("This is the OnEnable method");
        }

        void Start()
        {
            Debug.Log("This is the Start method");
        }

        void Update()
        {
            if (!_updateFlag)
            {
                _updateFlag = true;
                Debug.Log("This is the Update method");
            }
        }

        private void LateUpdate()
        {
            if (!_lateUpdateFlag)
            {
                _lateUpdateFlag = true;
                Debug.Log("This is the LateUpdate method");
            }
        }

        private void OnGUI()
        {
            if(!_onGUIFlag)
            {
                _onGUIFlag = true;
                Debug.Log("This is the OnGui method");
            }
        }

        private void OnApplicationQuit()
        {
            Debug.Log("This is the OnApplicationQuit method");
        }

        private void OnDisable()
        {
            Debug.Log("This is the OnDisable method");
        }

        private void OnDestroy()
        {
            Debug.Log("This is the OnDestroy method");

        }
    }
}
